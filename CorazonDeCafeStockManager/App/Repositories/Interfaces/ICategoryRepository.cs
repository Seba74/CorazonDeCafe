using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Categoria>> GetAllCategories();
    Categoria GetCategoryById(int id);
    void AddCategory(Categoria category);
    void UpdateCategory(Categoria category);
    void DeleteCategory(Categoria category);
}
