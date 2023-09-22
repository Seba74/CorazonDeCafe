using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class ProductRepository : IProductRepository
{

    private readonly CorazonDeCafeContext _context;

    public ProductRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    private async Task LoadCategoriesAndTypes()
    {
        try
        {
            await _context.Categories!.LoadAsync();
            await _context.Types!.LoadAsync();


            LocalStorage.Categories = await _context.Categories!.ToListAsync();
            LocalStorage.Types = await _context.Types!.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public async Task AddProduct(Product product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        await _context.Products!.AddAsync(product);

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        LocalStorage.Products!.Add(product);
    }

    public async Task<bool> DeleteProduct(int id)
    {
        Product? productToDelete = await _context.Products!.FirstOrDefaultAsync(p => p.Id == id);
        if (productToDelete == null) return false;
        productToDelete.Status = 0;

        try
        {
            int isDeleted = await _context.SaveChangesAsync();
            if (isDeleted > 0) LocalStorage.Products!.Remove(productToDelete);

            return isDeleted > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        if (LocalStorage.Categories == null || LocalStorage.Types == null)
            await LoadCategoriesAndTypes();
        // if is empty
        if (!LocalStorage.Products.IsNullOrEmpty()) return LocalStorage.Products!;

        try
        {
            LocalStorage.Products = await _context.Products!.Where(p => p.Status == 1).ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return LocalStorage.Products ?? new();
    }
    public async Task<Product> GetProductById(int id)
    {
        return await _context.Products!.FirstOrDefaultAsync(p => p.Id == id) ?? throw new ArgumentException("Producto no encontrado");
    }

    public async Task<bool> UpdateProduct(Product product)
    {
        try
        {
            Product? productToUpdate = await _context.Products!.FirstOrDefaultAsync(p => p.Id == product.Id);

            if (productToUpdate == null)
            {
                return false;
            }

            productToUpdate!.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.TypeId = product.TypeId;
            productToUpdate.Stock = product.Stock;
            productToUpdate.Status = product.Status;
            productToUpdate.Imagen = product.Imagen;
            productToUpdate.Active = product.Active;
            productToUpdate.UpdatedAt = DateTime.Now;
            productToUpdate.UpdatedById = SessionManager.Id;

            int fieldAct = await _context.SaveChangesAsync();
            return fieldAct > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

