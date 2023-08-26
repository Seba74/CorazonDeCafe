using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repository._Repository;

public class AuthRepository : IAuthRepository
{

    private readonly CorazonDeCafeContext _context;

    public AuthRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public async Task<bool> Login(string user, string password)
    {
        // get user from database
        Usuario? userFromDb = await _context.Usuarios!.FirstOrDefaultAsync(u => u.Usuario1 == user);

        if (userFromDb == null)
        {
            return false;
        }
        else
        {
            // check password
            if (userFromDb.Pass == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

