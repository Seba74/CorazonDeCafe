using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProducts();
    IEnumerable<Product> GetProductsByCategory(int categoryId);
    IEnumerable<Product> GetProductsByType(int typeId);
    Product GetProductById(int id);
    Task AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);

}
