using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IAuthRepository
{
    Task<bool> Login(string username, string password);
}
