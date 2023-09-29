using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllCustomers();
    Task<Customer> GetCustomerById(int id);
    Task AddCustomer(CustomerData customerData);
    Task<bool> UpdateCustomer(CustomerData customerData);
    Task<bool> DeleteCustomer(int id);
}
