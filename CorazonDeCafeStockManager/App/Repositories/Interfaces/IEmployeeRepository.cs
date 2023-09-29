using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllEmployees();
    Task<Employee> GetEmployeeById(int id);
    Task AddEmployee(EmployeeData employeeData);
    Task<bool> UpdateEmployee(EmployeeData employeeData);
    Task<bool> DeleteEmployee(int id);
    Task<Role> GetRoleByName(string name);
    Task<User> GetUserByDni(string dni);
}
