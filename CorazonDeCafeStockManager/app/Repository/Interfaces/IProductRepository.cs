using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repository;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProducts();
    IEnumerable<Product> GetAllProductsByFilter(string filter);
    IEnumerable<Product> GetProductsByCategory(int categoryId);
    IEnumerable<Product> GetProductsByType(int typeId);
    Product GetProductById(int id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
}
