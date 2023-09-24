using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllEmployees();
    Task<Employee> GetEmployeeById(int id);
    Task AddEmployee(Employee employee, User user);
    Task<bool> UpdateEmployee(Employee employee, User user);
    Task<bool> DeleteEmployee(int id);
    Task<Role> GetRoleByName(string name);
    Task<User> GetUserByDni(int dni);
}
