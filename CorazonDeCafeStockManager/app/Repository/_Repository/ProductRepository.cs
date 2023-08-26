using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repository._Repository;

public class ProductRepository : IProductRepository{
    
    private readonly CorazonDeCafeContext _context;

    public ProductRepository(CorazonDeCafeContext context){
        _context = context;
    }

    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(Product product)
    {
        throw new NotImplementedException();
    }

    // Get All Products
    public async Task<IEnumerable<Product>> GetAllProducts(){
        return await _context.Products!.ToListAsync();
    }

    public IEnumerable<Product> GetAllProductsByFilter(string filter)
    {
        throw new NotImplementedException();
    }

    public Product GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductsByCategory(int categoryId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductsByType(int typeId)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}

   