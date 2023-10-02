using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Presenters;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Repositories._Repository;
using CorazonDeCafeStockManager.App.Views.HomeForm;
using CorazonDeCafeStockManager.App.Views.LoginForm;
using CorazonDeCafeStockManager.Properties;
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
            ApplicationConfiguration.Initialize();
            DbContextOptionsBuilder<CorazonDeCafeContext> optionsBuilder = new();
            CorazonDeCafeContext dbContext = new(optionsBuilder.UseSqlServer(Resources.connectionString).Options);
            loadFonts.Init();

            _ = new AuthPresenter(dbContext);
            Application.Run();
        }
    }
}