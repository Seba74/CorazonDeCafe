using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class EmployeeRepository : IEmployeeRepository
{

    private readonly CorazonDeCafeContext _context;

    public EmployeeRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public async Task AddEmployee(Employee employee)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee));
        }

        await _context.Employees!.AddAsync(employee);

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        LocalStorage.Employees!.Add(employee);
    }

    public async Task<bool> DeleteEmployee(int id)
    {
        Employee? employee = await _context.Employees!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id);
        if (employee == null) return false;
        employee.User.Status = 0;
        try
        {
            int isDeleted = await _context.SaveChangesAsync();
            if (isDeleted > 0) LocalStorage.Employees!.Remove(employee);

            return isDeleted > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        try
        {
            LocalStorage.Employees = await _context.Employees!.Include(p => p.User).Include(p => p.Role).Where(p => p.User.Status == 1).ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return LocalStorage.Employees ?? new();
    }
    public async Task<Employee> GetEmployeeById(int id)
    {
        Employee? employee = await _context.Employees!.Include(p => p.User).Include(p => p.Role).FirstOrDefaultAsync(p => p.Id == id) ?? throw new ArgumentException("Empleado no encontrado");
        return employee;
    }

    public async Task<bool> UpdateEmployee(Employee employee, User user, Address address)
    {
        Employee? employeeToUpdate = await _context.Employees!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == employee.Id);
        if (employeeToUpdate == null) return false;

        employeeToUpdate.Username = employee.Username;
        employeeToUpdate.RoleId = employee.RoleId;
        
        employeeToUpdate.User.Name = user.Name;
        employeeToUpdate.User.Surname = user.Surname;
        employeeToUpdate.User.Email = user.Email;
        employeeToUpdate.User.Phone = user.Phone;
        employeeToUpdate.User.Dni = user.Dni;
        employeeToUpdate.User.UpdatedAt = DateTime.Now;

        if (address != null)
        {
            if (employeeToUpdate.User.Address == null)
            {
                Address NewAddress = new()
                {
                    Street = address.Street,
                    Number = address.Number,
                    City = address.City,
                    Province = address.Province,
                    PostalCode = address.PostalCode
                };
            }else{
                employeeToUpdate.User.Address.Street = address.Street;
                employeeToUpdate.User.Address.Number = address.Number;
                employeeToUpdate.User.Address.City = address.City;
                employeeToUpdate.User.Address.Province = address.Province;
                employeeToUpdate.User.Address.PostalCode = address.PostalCode;
            }
        }

        int fieldAct = await _context.SaveChangesAsync();
        return fieldAct > 0;
    }

    public async Task<Role> GetRoleByName(string name)
    {
        Role? role = await _context.Roles!.FirstOrDefaultAsync(p => p.Name == name) ?? throw new ArgumentException("Rol no encontrado");
        return role;
    }
}

