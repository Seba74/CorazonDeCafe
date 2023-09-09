using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using Type = CorazonDeCafeStockManager.App.Models.Type;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class TypeRepository : ITypeRepository
{

    private readonly CorazonDeCafeContext _context;

    public TypeRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public void AddType(Type type)
    {
        _context.Types!.Add(type);
    }

    public void AddTypey(Type type)
    {
        throw new NotImplementedException();
    }

    public async void DeleteType(Type type)
    {
        type.Status = 0;
        _context.Types!.Update(type);
        await _context.SaveChangesAsync();
    }

    public void DeleteTypey(Type type)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Type>> GetAllTypes()
    {
        IEnumerable<Type> categories = await _context.Types!.ToListAsync();
        return categories;
    }

    public Type GetTypeById(int id)
    {
        return _context.Types!.First(c => c.Id == id);
    }

    public Type GetTypeyById(int id)
    {
        throw new NotImplementedException();
    }

    public async void UpdateType(Type type)
    {
        _context.Types!.Update(type);
        await _context.SaveChangesAsync();
    }

    public void UpdateTypey(Type type)
    {
        throw new NotImplementedException();
    }
}

