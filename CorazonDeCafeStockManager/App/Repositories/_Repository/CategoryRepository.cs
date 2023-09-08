using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class CategoryRepository : ICategoryRepository
{

    private readonly CorazonDeCafeContext _context;

    public CategoryRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public void AddCategory(Category category)
    {
        _context.Categories!.Add(category);
    }

    public async void DeleteCategory(Category category)
    {
        category.Status = 0;
        _context.Categories!.Update(category);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Category>> GetAllCategories()
    {
        IEnumerable<Category> categories = await _context.Categories!.ToListAsync();
        return categories;
    }

    public Category GetCategoryById(int id)
    {
        return _context.Categories!.First(c => c.Id == id);
    }

    public async void UpdateCategory(Category category)
    {
        _context.Categories!.Update(category);
        await _context.SaveChangesAsync();
    }
}

