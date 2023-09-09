using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllCategories();
    Category GetCategoryById(int id);
    void AddCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(Category category);
}
