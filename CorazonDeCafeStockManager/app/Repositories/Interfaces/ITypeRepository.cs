using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface ITypeRepository
{
    Task<IEnumerable<Tipo>> GetAllTypes();
    Tipo GetTypeyById(int id);
    void AddTypey(Tipo type);
    void UpdateTypey(Tipo type);
    void DeleteTypey(Tipo type);
}
