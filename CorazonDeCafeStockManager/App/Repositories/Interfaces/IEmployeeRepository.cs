using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllEmployees();
    Task<Employee> GetEmployeeById(int id);
    Task AddEmployee(Employee employee);
    Task<bool> UpdateEmployee(Employee employee, User user, Address address);
    Task<bool> DeleteEmployee(int id);
    Task<Role> GetRoleByName(string name);
}
