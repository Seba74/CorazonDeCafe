using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IBackupRepository
{
    Task<bool> Backup(string database, string path);
    Task<bool> Restore(string database, string path);
    string GetUbication(bool getfile);
}
