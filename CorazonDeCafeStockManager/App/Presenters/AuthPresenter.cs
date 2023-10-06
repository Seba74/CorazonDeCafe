using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Repositories._Repository;
using CorazonDeCafeStockManager.App.Views.HomeForm;
using CorazonDeCafeStockManager.App.Views.LoginForm;
using Microsoft.EntityFrameworkCore;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class AuthPresenter
    {
        private readonly IAuthView view;
        private readonly IAuthRepository repository;
        private readonly CorazonDeCafeContext dbContext;
        public AuthPresenter(CorazonDeCafeContext dbContext)
        {
            this.view = new LoginForm();
            this.repository = new AuthRepository(dbContext);
            this.dbContext = dbContext;
            this.view.LoginEvent += LoginEvent;
            this.view.Show();
        }

        private async void LoginEvent(object? sender, Tuple<string, string> e)
        {
            view.Loading.Visible = true;
            await Task.Delay(600);
            bool logged;
            try
            {
                logged = await repository!.Login(e.Item1, e.Item2);
                if (logged)
                {
                    view?.Close();
                    IHomeView homeView = new Home();
                    HomePresenter presenter = new(homeView, dbContext);
                    presenter.ShowHomeView();
                }
                else
                {
                    view?.ShowError("Usuario o contraseña incorrectos");
                }
            }
            catch
            {
                view?.ShowError("Error al iniciar sesión");
            }
        }
    }
}
