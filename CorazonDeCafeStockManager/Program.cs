using System.Configuration;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Presenters;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Repositories._Repository;
using CorazonDeCafeStockManager.App.Views.Home_Form;
using CorazonDeCafeStockManager.App.Views.Login_Form;
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
            string connectionString = ConfigurationManager.ConnectionStrings["CorazonDeCafeStockManager.App.SqlConnection"].ConnectionString;
            DbContextOptionsBuilder<CorazonDeCafeContext> optionsBuilder = new();
            CorazonDeCafeContext dbContext = new(optionsBuilder.UseSqlServer(connectionString).Options);
            FontsManager.Init();
            // Init Home View
            IHomeView homeView = new Home(); 
            HomePresenter homePresenter = new(homeView, dbContext);

            // First View Presentation  
            IAuthRepository authRepository = new AuthRepository(dbContext);
            IAuthView authLogin = new LoginForm();
            _ = new AuthPresenter(authLogin, authRepository, homePresenter);

            Application.Run();
        }
    }
}