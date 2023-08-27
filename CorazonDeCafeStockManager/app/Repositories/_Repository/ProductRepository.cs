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

    public async void AddProduct(Product product)
    {
        // Add Product
        await _context.Products!.AddAsync(product);
    }

    public async void DeleteProduct(Product product)
    {
        product.Estado = "NO";
        await Task.Run(() => _context.Products!.Update(product));
    }

    // Get All Products
    public IEnumerable<Product> GetAllProducts()
    {
        IEnumerable<Product> products = _context.Products!.ToList();
        return products;
    }

    public async Task<IEnumerable<Product>> GetAllProductsByFilter(string filter)
    {
        IEnumerable<Product> products = new List<Product>();
        if (int.TryParse(filter, out int id))
        {
            products = await _context.Products!.Where(p => p.Id == id).ToListAsync();
        }
        else
        {
            products = await _context.Products!.Where(p => p.Nombre.Contains(filter)).ToListAsync();
        }

        return products;
    }

    public async Task<Product> GetProductById(int id)
    {
        return await _context.Products!.FirstAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
    {
        return await _context.Products!.Where(p => p.CategoriaId == categoryId).ToListAsync();
    }

    public async Task<IEnumerable<Product>> GetProductsByType(int typeId)
    {
        return await _context.Products!.Where(p => p.TipoId == typeId).ToListAsync();
    }

    public async void UpdateProduct(Product product)
    {
        await Task.Run(() => _context.Products!.Update(product));
    }
}

