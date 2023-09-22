using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllCustomers();
    Task<Customer> GetCustomerById(int id);
    Task AddCustomer(Customer customer);
    Task<bool> UpdateCustomer(Customer customer, User user, Address address);
    Task<bool> DeleteCustomer(int id);
}
