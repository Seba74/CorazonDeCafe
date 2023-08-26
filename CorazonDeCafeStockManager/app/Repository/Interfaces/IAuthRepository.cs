using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repository;

public interface IAuthRepository
{
    Task<bool> Login(string user, string password);
}
