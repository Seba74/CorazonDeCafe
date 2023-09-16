using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Common;
using Microsoft.EntityFrameworkCore;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class AuthRepository : IAuthRepository
{
    private readonly CorazonDeCafeContext _context;

    public AuthRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public async Task<bool> Login(string username, string password)
    {
        // get employee from database by username and get user with it
        Employee? employee = await _context.Employees.Include(e => e.User).FirstOrDefaultAsync(e => e.Username == username);

        if (employee == null)
        {
            return false;
        }
        else
        {
            // check password
            if (employee.Pass == password)
            {
                SessionManager.Name = employee.User.Name;
                SessionManager.RoleId = employee.RoleId;
                SessionManager.Username = employee.Username;
                SessionManager.IsLoggedIn = true;

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

