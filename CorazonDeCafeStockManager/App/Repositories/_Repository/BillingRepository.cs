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
        LocalStorage.Employees = await _context.Employees!.Include(e => e.User).ToListAsync() ?? throw new LocalException("No se encontraron empleados");
    }

    public async Task<IEnumerable<Order>> GetAllBillings()
    {
        LocalStorage.Orders ??= await _context.Orders!.Include(o => o.Customer).ThenInclude(c => c!.User).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        return LocalStorage.Orders;
    }
    public async Task<IEnumerable<Order>> GetAllBillingsByEmployeeId(int id)
    {
        return await _context.Orders!.Include(o => o.Customer).ThenInclude(c => c!.User).Where(o => o.EmployeeId == id).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
    }

    public async Task<Order> GetBillingById(int id)
    {
        Order order = await _context.Orders!.Include(o => o.Customer).ThenInclude(c => c!.User).ThenInclude(u => u.Address)
            .Include(o => o.BillingType).Include(o => o.PaymentMethod).Include(o => o.OrderProducts)
            .ThenInclude(op => op.Product).FirstOrDefaultAsync(o => o.Id == id) ?? throw new LocalException("No se encontró la orden");
        return order;
    }

    public async Task AddBilling(OrderData order)
    {
        try
        {
            Order orderToAdd = new()
            {
                CustomerId = order.CustomerId,
                EmployeeId = (int)SessionManager.Id!,
                BillingTypeId = order.BillingType,
                PaymentMethodId = order.PaymentMethod,
                CustomerCuit = order.CustomerCuit.IsNullOrEmpty() ? null : order.CustomerCuit,
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
                LocalStorage.Orders ??= await _context.Orders!.ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
            }

        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
    }

    public async Task<Order> GetLastBilling()
    {
        Order order = await _context.Orders!.Include(o => o.Customer).ThenInclude(c => c!.User).ThenInclude(u => u.Address)
            .Include(o => o.BillingType).Include(o => o.PaymentMethod).Include(o => o.OrderProducts)
            .ThenInclude(op => op.Product).OrderByDescending(o => o.Id).FirstOrDefaultAsync() ?? throw new LocalException("No se encontró la orden");
        return order;
    }

    public async Task<IEnumerable<Order>> GetBillingsByCustomerId(int id)
    {
        return await _context.Orders!.Include(o => o.Customer).Where(o => o.CustomerId == id).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
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

    public async Task<Product> GetProductPop()
    {
        IEnumerable<OrderProduct> orderProducts = await _context.OrderProducts!.ToListAsync() ?? throw new LocalException("No se encontraron productos");
        var productPop = orderProducts.GroupBy(op => op.ProductId).Select(op => new { ProductId = op.Key, Amount = op.Sum(op => op.Amount) }).OrderByDescending(op => op.Amount).FirstOrDefault();

        Product product = await _context.Products!.FirstOrDefaultAsync(p => p.Id == productPop!.ProductId) ?? throw new LocalException("No se encontró el producto");

        return product;
    }

    public async Task<Customer> GetCustomerPop()
    {

        if(SessionManager.RoleId == 3 || SessionManager.RoleId == 4)
        {
            IEnumerable<Order> ordersEmp = await _context.Orders!.Where(o => o.EmployeeId == SessionManager.Id).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
            var customerPopEmp = ordersEmp.GroupBy(o => o.CustomerId).Select(o => new { CustomerId = o.Key, Amount = o.Count() }).OrderByDescending(o => o.Amount).FirstOrDefault();
            Customer customerEmp = await _context.Customers!.Include(c => c.User).FirstOrDefaultAsync(c => c.Id == customerPopEmp!.CustomerId) ?? throw new LocalException("No se encontró el cliente");
            return customerEmp;
        }

        IEnumerable<Order> orders = await _context.Orders!.ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        var customerPop = orders.GroupBy(o => o.CustomerId).Select(o => new { CustomerId = o.Key, Amount = o.Count() }).OrderByDescending(o => o.Amount).FirstOrDefault();
        Customer customer = await _context.Customers!.Include(c => c.User).FirstOrDefaultAsync(c => c.Id == customerPop!.CustomerId) ?? throw new LocalException("No se encontró el cliente");

        return customer;
    }

    public async Task<PaymentMethod> GetPaymentMethodPop()
    {

        if(SessionManager.RoleId == 3 || SessionManager.RoleId == 4)
        {
            IEnumerable<Order> ordersEmp = await _context.Orders!.Where(o => o.EmployeeId == SessionManager.Id).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
            var paymentMethodPopEmp = ordersEmp.GroupBy(o => o.PaymentMethodId).Select(o => new { PaymentMethodId = o.Key, Amount = o.Count() }).OrderByDescending(o => o.Amount).FirstOrDefault();
            PaymentMethod paymentMethodEmp = await _context.PaymentMethods!.FirstOrDefaultAsync(pm => pm.Id == paymentMethodPopEmp!.PaymentMethodId) ?? throw new LocalException("No se encontró el método de pago");
            return paymentMethodEmp;
        }   

        IEnumerable<Order> orders = await _context.Orders!.ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        var paymentMethodPop = orders.GroupBy(o => o.PaymentMethodId).Select(o => new { PaymentMethodId = o.Key, Amount = o.Count() }).OrderByDescending(o => o.Amount).FirstOrDefault();
        PaymentMethod paymentMethod = await _context.PaymentMethods!.FirstOrDefaultAsync(pm => pm.Id == paymentMethodPop!.PaymentMethodId) ?? throw new LocalException("No se encontró el método de pago");

        return paymentMethod;
    }

    public async Task<int> GetLastMonthBillings()
    {

        if(SessionManager.RoleId == 3 || SessionManager.RoleId == 4)
        {
            IEnumerable<Order> ordersEmp = await _context.Orders!.Where(o => o.EmployeeId == SessionManager.Id && o.Status == 1).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
            DateTime startMonthEmp = DateTime.Now;
            startMonthEmp = new DateTime(startMonthEmp.Year, startMonthEmp.Month, 1);
            DateTime endMonthEmp = startMonthEmp.AddMonths(1).AddDays(-1);
            IEnumerable<Order> lastMonthBillingsEmp = ordersEmp.Where(o => o.CreatedAt >= startMonthEmp && o.CreatedAt <= endMonthEmp);
            return lastMonthBillingsEmp.Count();
        }


        IEnumerable<Order> orders = await _context.Orders!.Where(o => o.Status == 1).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        DateTime startMonth = DateTime.Now;
        startMonth = new DateTime(startMonth.Year, startMonth.Month, 1);
        DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);
        IEnumerable<Order> lastMonthBillings = orders.Where(o => o.CreatedAt >= startMonth && o.CreatedAt <= endMonth);

        return lastMonthBillings.Count();
    }
    public async Task<IEnumerable<OrderCantStats>> GetBillingsCantByDateAndEmployeeId(DateTime startDate, DateTime endDate, int? employeeId)
    {
        IEnumerable<Order> orders;
        if (employeeId == 0)
        {
            orders = await _context.Orders!.Where(o => o.Status == 1).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        }
        else
        {
            orders = await _context.Orders!.Where(o => o.Status == 1 && o.EmployeeId == employeeId).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        }

        endDate = endDate.AddDays(1);
        IEnumerable<Order> billings = orders.Where(o => o.CreatedAt >= startDate && o.CreatedAt <= endDate);

        var groupedOrders = billings.GroupBy(o => o.CreatedAt?.Date);

        var billingsGrouped = groupedOrders.Select(group =>
            new OrderCantStats
            {
                Amount = group.Count(),
                CreatedAt = (DateTime)group.Key!
            });
        return billingsGrouped;
    }

    public async Task<IEnumerable<OrderStats>> GetBillingsByDateAndEmployeeId(DateTime startDate, DateTime endDate, int? employeeId)
    {

        IEnumerable<Order> orders;
        if (employeeId == 0)
        {
            orders = await _context.Orders!.Where(o => o.Status == 1).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        }
        else
        {
            orders = await _context.Orders!.Where(o => o.Status == 1 && o.EmployeeId == employeeId).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        }

        endDate = endDate.AddDays(1);
        IEnumerable<Order> billings = orders.Where(o => o.CreatedAt >= startDate && o.CreatedAt <= endDate);

        var groupedOrders = billings.GroupBy(o => o.CreatedAt?.Date);

        var billingsGrouped = groupedOrders.Select(group =>
            new OrderStats
            {
                Amount = group.Where(o => o != null).Sum(o => o.TotalPrice),
                CreatedAt = (DateTime)group.Key!,
            });


        return billingsGrouped;
    }

    public async Task<IEnumerable<OrderByEmployee>> GetBillingsByEmployee(DateTime startDate, DateTime endDate, int? employeeId)
    {
        IEnumerable<Order> orders;
        if (employeeId == 0)
        {
            orders = await _context.Orders!.Where(o => o.Status == 1).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        }
        else
        {
            orders = await _context.Orders!.Where(o => o.Status == 1 && o.EmployeeId == employeeId).ToListAsync() ?? throw new LocalException("No se encontraron ordenes");
        }

        endDate = endDate.AddDays(1);
        IEnumerable<Order> billings = orders.Where(o => o.CreatedAt >= startDate && o.CreatedAt <= endDate);

        var groupedOrders = billings.GroupBy(o => o.Employee);

        var billingsGrouped = groupedOrders.Select(group =>
            new OrderByEmployee
            {
                Employee = group.Key,
                TotalOrders = group.Count()
            });
        return billingsGrouped;
    }
}

