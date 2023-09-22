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
        User? employeeToUpdate = await _context.Users!.Include(p => p.Address).FirstOrDefaultAsync(p => p.Id == employee.UserId);
        if(employeeToUpdate == null) return false;

        employeeToUpdate.Name = user.Name;
        employeeToUpdate.Surname = user.Surname;
        employeeToUpdate.Email = user.Email;
        employeeToUpdate.Phone = user.Phone;
        employeeToUpdate.Dni = user.Dni;
        employeeToUpdate.Address!.Street = address.Street;
        employeeToUpdate.Address.Number = address.Number;
        employeeToUpdate.Address.City = address.City;
        employeeToUpdate.Address.Province = address.Province;
        employeeToUpdate.Address.PostalCode = address.PostalCode;
        employeeToUpdate.UpdatedAt = DateTime.Now;

    
        int fieldAct = await _context.SaveChangesAsync();
        return fieldAct > 0;
    }
}

