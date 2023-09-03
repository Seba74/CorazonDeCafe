using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class CategoryRepository : ICategoryRepository
{

    private readonly CorazonDeCafeContext _context;

    public CategoryRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public void AddCategory(Categoria category)
    {
        _context.Categorias!.Add(category);
    }

    public async void DeleteCategory(Categoria category)
    {
        category.Activo = "NO";
        _context.Categorias!.Update(category);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Categoria>> GetAllCategories()
    {
        IEnumerable<Categoria> categories = await _context.Categorias!.ToListAsync();
        return categories;
    }

    public Categoria GetCategoryById(int id)
    {
        return _context.Categorias!.First(c => c.Id == id);
    }

    public async void UpdateCategory(Categoria category)
    {
        _context.Categorias!.Update(category);
        await _context.SaveChangesAsync();
    }
}

