using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class TypeRepository : ITypeRepository
{

    private readonly CorazonDeCafeContext _context;

    public TypeRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public void AddType(Tipo type)
    {
        _context.Tipos!.Add(type);
    }

    public void AddTypey(Tipo type)
    {
        throw new NotImplementedException();
    }

    public async void DeleteType(Tipo type)
    {
        type.Activo = "NO";
        _context.Tipos!.Update(type);
        await _context.SaveChangesAsync();
    }

    public void DeleteTypey(Tipo type)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Tipo>> GetAllTypes()
    {
        IEnumerable<Tipo> categories = await _context.Tipos!.ToListAsync();
        return categories;
    }

    public Tipo GetTypeById(int id)
    {
        return _context.Tipos!.First(c => c.Id == id);
    }

    public Tipo GetTypeyById(int id)
    {
        throw new NotImplementedException();
    }

    public async void UpdateType(Tipo type)
    {
        _context.Tipos!.Update(type);
        await _context.SaveChangesAsync();
    }

    public void UpdateTypey(Tipo type)
    {
        throw new NotImplementedException();
    }
}

