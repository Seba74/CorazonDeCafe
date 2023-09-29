using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> GetProductById(int id);
    Task AddProduct(ProductData productData);
    Task<bool> UpdateProduct(ProductData productData);
    Task<bool> DeleteProduct(int id);
}
