namespace CorazonDeCafeStockManager
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string filter);
        Product GetProduct(int id);
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
    }
}
