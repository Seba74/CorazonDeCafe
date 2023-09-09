using Type = CorazonDeCafeStockManager.App.Models.Type;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface ITypeRepository
{
    Task<IEnumerable<Type>> GetAllTypes();
    Type GetTypeyById(int id);
    void AddTypey(Type type);
    void UpdateTypey(Type type);
    void DeleteTypey(Type type);
}
