using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Client>> GetAllCustomers();
    Task<Client> GetCustomerById(int id);
    Task AddCustomer(Client customer);
    Task<bool> UpdateCustomer(Client customer);
    Task<bool> DeleteCustomer(int id);
}
