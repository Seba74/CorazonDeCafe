using System.Configuration;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repository;
using CorazonDeCafeStockManager.App.Repository._Repository;
using Microsoft.EntityFrameworkCore;

namespace CorazonDeCafeStockManager
{
    internal static class Program
    {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["CorazonDeCafeStockManager.App.SqlConnection"].ConnectionString;
            DbContextOptionsBuilder<CorazonDeCafeContext> optionsBuilder = new();
            CorazonDeCafeContext dbContext = new(optionsBuilder.UseSqlServer(connectionString).Options);

            IAuthRepository requestLogin = new AuthRepository(dbContext);

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(requestLogin));
        }
    }
}