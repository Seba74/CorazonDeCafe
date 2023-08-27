﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Vars;
using CorazonDeCafeStockManager.App.Views.Home_Form;
using CorazonDeCafeStockManager.App.Views.Login_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class AuthPresenter
    {
        private readonly IAuthView view;
        private readonly IAuthRepository repository;

        private readonly IHomeView homeView;

        public AuthPresenter(IAuthView view, IAuthRepository repository, IHomeView homeView)
        {
            this.view = view;
            this.repository = repository;
            this.homeView = homeView;
            this.view.LoginEvent += LoginEvent;
            this.view.Show();
        }

        private async void LoginEvent(object? sender, Tuple<string, string> e)
        {
            bool logged = await this.repository!.Login(e.Item1, e.Item2);
            if (logged)
            {
                this.homeView.Show();
                this.view.Close();
            }
            else
            {
                this.view?.ShowError("Usuario o contraseña incorrectos");
            }
        }
    }
}
