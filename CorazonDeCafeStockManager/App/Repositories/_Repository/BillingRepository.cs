using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Common;
using Microsoft.EntityFrameworkCore;
using CorazonDeCafeStockManager.App.EntityData;
using Microsoft.IdentityModel.Tokens;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class BillingRepository : IBillingRepository
{
    private readonly CorazonDeCafeContext _context;

    public BillingRepository(CorazonDeCafeContext context)
    {
        _context = context;
        _ = Task.Run(() => LoadBillingInfo());
    }
    public async Task LoadBillingInfo()
    {
        LocalStorage.PaymentMethods = await _context.PaymentMethods!.ToListAsync() ?? throw new LocalException("No se encontraron métodos de pago");
        LocalStorage.BillingTypes = await _context.BillingTypes!.ToListAsync() ?? throw new LocalException("No se encontraron tipos de facturación");
    }

    public async Task<IEnumerable<Order>> GetAllBillings()
    {
        return await _context.Orders!.ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
    }

    public async Task<Order> GetBillingById(int id)
    {
        return await _context.Orders!.FirstOrDefaultAsync(o => o.Id == id) ?? throw new LocalException("No se encontró la orden");
    }

    public async Task AddBilling(OrderData order)
    {
        try
        {
            Order orderToAdd = new()
            {
                CustomerId = order.CustomerId,
                BillingTypeId = order.BillingType,
                PaymentMethodId = order.PaymentMethod,
                CustomerCuil = order.CustomerCuil.IsNullOrEmpty() ? null : order.CustomerCuil,
                TotalPrice = order.TotalPrice,
                Status = order.Status
            };

            await _context.Orders!.AddAsync(orderToAdd);
            await _context.SaveChangesAsync();

            foreach (OrderProductData product in order.Products!)
            {
                OrderProduct orderProduct = new()
                {
                    OrderId = orderToAdd.Id,
                    ProductId = product.ProductId,
                    Amount = product.Amount,
                    Price = product.Price
                };

                Product productToUpdate = await _context.Products!.FirstOrDefaultAsync(p => p.Id == product.ProductId) ?? throw new LocalException("No se encontró el producto");

                productToUpdate.Stock -= product.Amount;
                _context.Products!.Update(productToUpdate);

                await _context.OrderProducts!.AddAsync(orderProduct);
                await _context.SaveChangesAsync();

                _context.ChangeTracker.Clear();
                LocalStorage.Products = null;
            }

            LocalStorage.Orders!.Add(orderToAdd);
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
    }

    public async Task<bool> DeleteBilling(int id)
    {
        try
        {
            Order order = await _context.Orders!.FirstOrDefaultAsync(o => o.Id == id) ?? throw new LocalException("No se encontró la orden");
            order.Status = 0;
            await _context.SaveChangesAsync();

            IEnumerable<OrderProduct> orderProducts = await _context.OrderProducts!.Where(op => op.OrderId == id).ToListAsync() ?? throw new LocalException("No se encontraron productos");

            foreach (OrderProduct orderProduct in orderProducts)
            {
                Product product = await _context.Products!.FirstOrDefaultAsync(p => p.Id == orderProduct.ProductId) ?? throw new LocalException("No se encontró el producto");
                product.Stock += orderProduct.Amount;
                _context.Products!.Update(product);
            }
            await _context.SaveChangesAsync();

            return true;
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
    }
}

