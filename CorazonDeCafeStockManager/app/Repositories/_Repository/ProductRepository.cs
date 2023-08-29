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
        await _context.Categorias!.LoadAsync();
        await _context.Tipos!.LoadAsync();
    }

    public void AddProduct(Product product)
    {
        _context.Products!.Add(product);
    }

    public async void DeleteProduct(Product product)
    {
        product.Estado = "NO";
        _context.Products!.Update(product);
        await _context.SaveChangesAsync();
    }

    // Get All Products
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        await LoadCategoriesAndTypes();
        IEnumerable<Product> products = await _context.Products!.ToListAsync();
        return products;
    }

    public IEnumerable<Product> GetAllProductsByFilter(string filter)
    {
        IEnumerable<Product> products = new List<Product>();
        if (int.TryParse(filter, out int id))
        {
            products = _context.Products!.Where(p => p.Id == id).ToList();
        }
        else
        {
            products = _context.Products!.Where(p => p.Nombre.Contains(filter)).ToList();
        }

        return products;
    }

    public Product GetProductById(int id)
    {
        return _context.Products!.First(p => p.Id == id);
    }

    public IEnumerable<Product> GetProductsByCategory(int categoryId)
    {
        return _context.Products!.Where(p => p.CategoriaId == categoryId).ToList();
    }

    public IEnumerable<Product> GetProductsByType(int typeId)
    {
        return _context.Products!.Where(p => p.TipoId == typeId).ToList();
    }

    public async void UpdateProduct(Product product)
    {
        _context.Products!.Update(product);
        await _context.SaveChangesAsync();
    }
}

