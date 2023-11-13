using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
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
        _ = LoadRoles();
    }
        
    private async Task LoadRoles()
    {
        if (!LocalStorage.Roles.IsNullOrEmpty()) return;

        try
        {
            LocalStorage.Roles = await _context.Roles!.ToListAsync();
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al obtener los roles");
        }
    }


    public async Task AddEmployee(EmployeeData employee)
    {
        try
        {
            if (await _context.Users!.AnyAsync(p => p.Dni == employee.Dni)) throw new LocalException("Ya existe una persona con ese DNI");
            if (await _context.Users!.AnyAsync(p => p.Email == employee.Email)) throw new LocalException("Ya existe una persona con ese Email");

            User user = new()
            {
                Name = employee.Name!,
                Surname = employee.Surname!,
                Email = employee.Email!,
                Dni = employee.Dni!,
                Phone = employee.Phone,
                Status = employee.Status,
            };

            await _context.Users!.AddAsync(user);
            await _context.SaveChangesAsync();

            Employee employeeToAdd = new()
            {
                UserId = user.Id,
                Username = employee.Username!,
                Pass = HashPass.HashPassword(employee.Dni!),
                RoleId = employee.RoleId,
            };

            await _context.Employees!.AddAsync(employeeToAdd);
            await _context.SaveChangesAsync();

            LocalStorage.Employees!.Add(employeeToAdd);
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al agregar el empleado");
        }
    }

    public async Task<bool> DeleteEmployee(int id)
    {
        try
        {
            Employee? employee = await _context.Employees!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id) ?? throw new LocalException("Empleado no encontrado");
            employee.User.Status = 0;
            int isDeleted = await _context.SaveChangesAsync();
            if (isDeleted > 0) LocalStorage.Employees!.Remove(employee);

            return isDeleted > 0;
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al eliminar el empleado");
        }
    }

    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        if (!LocalStorage.Employees.IsNullOrEmpty()) return LocalStorage.Employees!;

        try
        {
            if (SessionManager.Id == 1) LocalStorage.Employees = await _context.Employees!.Include(p => p.User).Include(p => p.Role).Where(p => p.Role.Id != 1).ToListAsync();
            else LocalStorage.Employees = await _context.Employees!.Include(p => p.User).Include(p => p.Role).Where(p => p.Role.Id != 1 && p.Role.Id != 2).ToListAsync();
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al obtener los empleados");
        }

        return LocalStorage.Employees ?? new();
    }
    public async Task<Employee> GetEmployeeById(int id)
    {
        return await _context.Employees!.Include(p => p.User).Include(p => p.Role).FirstOrDefaultAsync(p => p.Id == id) ?? throw new LocalException("Empleado no encontrado");
    }

    public async Task<bool> UpdateEmployee(EmployeeData employee)
    {
        try
        {
            Employee? employeeToUpdate = await _context.Employees!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == employee.Id) ?? throw new LocalException("Empleado no encontrado");

            employeeToUpdate.Username = employee.Username!;
            employeeToUpdate.RoleId = employee.RoleId;

            employeeToUpdate.User.Name = employee.Name!;
            employeeToUpdate.User.Surname = employee.Surname!;
            employeeToUpdate.User.Email = employee.Email!;
            employeeToUpdate.User.Phone = employee.Phone;
            employeeToUpdate.User.Dni = employee.Dni!;
            employeeToUpdate.User.UpdatedAt = DateTime.Now;

            int fieldAct = await _context.SaveChangesAsync();
            if (fieldAct <= 0) throw new LocalException("No se pudo actualizar el empleado");
            return true;
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al actualizar el empleado");
        }
    }

    public async Task<Role> GetRoleByName(string name)
    {
        return await _context.Roles!.FirstOrDefaultAsync(p => p.Name == name) ?? throw new LocalException("Rol no encontrado");
    }

    public async Task<User> GetUserByDni(string dni)
    {
        return await _context.Users!.FirstOrDefaultAsync(p => p.Dni.Equals(dni)) ?? throw new LocalException("Usuario no encontrado");
    }
}

