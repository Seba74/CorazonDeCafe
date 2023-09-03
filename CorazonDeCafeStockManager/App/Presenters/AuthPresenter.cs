﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Views.Home_Form;
using CorazonDeCafeStockManager.App.Views.Login_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class AuthPresenter
    {
        private readonly IAuthView view;
        private readonly IAuthRepository repository;
        private readonly HomePresenter homePresenter;

        public AuthPresenter(IAuthView view, IAuthRepository repository, HomePresenter homePresenter)
        {
            this.view = view;
            this.repository = repository;
            this.homePresenter = homePresenter;
            this.view.LoginEvent += LoginEvent;
            this.view.Show();
        }

        private async void LoginEvent(object? sender, Tuple<string, string> e)
        {
            this.view.Loading.Visible = true;
            await Task.Delay(600);
            bool logged = await repository!.Login(e.Item1, e.Item2);
            if (logged)
            {
                view.Close();
                homePresenter.ShowHomeView();

            }
            else
            {
                this.view?.ShowError("Usuario o contraseña incorrectos");
            }
        }
    }
}