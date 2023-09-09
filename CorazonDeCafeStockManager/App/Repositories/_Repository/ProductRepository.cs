using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
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
        await _context.Categories!.LoadAsync();
        await _context.Types!.LoadAsync();

        LocalStorage.Categories = await _context.Categories!.ToListAsync();
        LocalStorage.Types = await _context.Types!.ToListAsync();
    }

    public async Task AddProduct(Product product)
    {
        await _context.Products!.AddAsync(product);
        await _context.SaveChangesAsync();

        LocalStorage.Products!.Add(product);
    }

    public async void DeleteProduct(Product product)
    {
        product.Status = 0;
        _context.Products!.Update(product);
        await _context.SaveChangesAsync();
    }

    // Get All Products
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        if (LocalStorage.Categories == null || LocalStorage.Types == null)
            await LoadCategoriesAndTypes();
        LocalStorage.Products ??= await _context.Products!.ToListAsync();
        return LocalStorage.Products;
    }
    public Product GetProductById(int id)
    {
        return _context.Products!.First(p => p.Id == id);
    }

    public IEnumerable<Product> GetProductsByCategory(int categoryId)
    {
        return _context.Products!.Where(p => p.CategoryId == categoryId).ToList();
    }

    public IEnumerable<Product> GetProductsByType(int typeId)
    {
        return _context.Products!.Where(p => p.TypeId == typeId).ToList();
    }

    public async void UpdateProduct(Product product)
    {
        _context.Products!.Update(product);
        await _context.SaveChangesAsync();
    }
}

