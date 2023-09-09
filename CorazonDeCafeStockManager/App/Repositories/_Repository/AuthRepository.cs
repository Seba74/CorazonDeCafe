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
        // get user from database
        User? user = await _context.Users!.FirstOrDefaultAsync(u => u.Username == username);

        if (user == null)
        {
            return false;
        }
        else
        {
            // check password
            if (user.Pass == password)
            {
                SessionManager.Name = user.Name;
                SessionManager.RoleId = user.RoleId;
                SessionManager.Username = user.Username;
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

