using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<IEnumerable<Product>> GetAllProductsByFilter(string filter);
    Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
    Task<IEnumerable<Product>> GetProductsByType(int typeId);
    Task<Product> GetProductById(int id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);

}
