using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IBillingRepository
{
    Task LoadBillingInfo();
    Task<IEnumerable<Order>> GetAllBillings();
    Task<Order> GetBillingById(int id);
    Task AddBilling(OrderData order);
    Task<bool> DeleteBilling(int id);
}
