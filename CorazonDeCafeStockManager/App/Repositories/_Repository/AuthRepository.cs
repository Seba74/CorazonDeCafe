using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Common;
using Microsoft.EntityFrameworkCore;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class AuthRepository : IAuthRepository
{
    private readonly CorazonDeCafeContext? _context;

    public AuthRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public async Task<bool> Login(string username, string password)
    {
        try
        {
            Employee? employee = await _context!.Employees!.Include(e => e.User).FirstOrDefaultAsync(e => e.Username == username);

            if (employee == null) return false;
            if (employee.User.Status == 0) return false;

            if(employee.Pass == employee.User.Dni) employee.Pass = HashPass.HashPassword(employee.User.Dni); await _context.SaveChangesAsync();

            if (employee.Pass == "admin") employee.Pass = HashPass.HashPassword("admin"); await _context.SaveChangesAsync();

            if (HashPass.ValidatePassword(password, employee.Pass))
            {
                SessionManager.Id = employee.Id;
                SessionManager.Name = employee.User.Name;
                SessionManager.RoleId = employee.RoleId;
                SessionManager.Username = employee.Username;
                SessionManager.IsLoggedIn = true;

                return true;
            }
            return false;
        }
        catch (Exception)
        {
            throw new LocalException("Error al iniciar sesión");
        }
    }
}

