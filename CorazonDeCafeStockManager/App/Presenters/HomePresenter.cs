﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Repositories._Repository;
using CorazonDeCafeStockManager.App.Views.Home_Form;
using CorazonDeCafeStockManager.App.Views.Product_Form;
using CorazonDeCafeStockManager.App.Views.Products_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class HomePresenter
    {
        private readonly CorazonDeCafeContext dbContext;
        private readonly IHomeView view;
        private IProductsView? productsView;
        private IProductView? productView;

        public HomePresenter(IHomeView view, CorazonDeCafeContext dbContext)
        {
            this.view = view;
            this.dbContext = dbContext;
            this.view.ShowProductsView += ShowProductsView;
            this.view.CloseView += CloseView;

        }

        public void ShowHomeView()
        {
            ShowProductsView(this, EventArgs.Empty);
            view.Show();
        }

        private async void ShowProductsView(object? sender, EventArgs e)
        {
            view.RemoveBackgroundBtns();
            view.ProductButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.coffee1;
            view.TitleHeader.Text = "PRODUCTOS";

            IProductRepository productRepository = new ProductRepository(dbContext);
            productsView = Products.GetInstance(view.ControlPanel);


            await ProductsPresenter.CreatePresenter(productsView, productRepository, this);
        }

        public void ShowProductView()
        {
            IProductRepository productRepository = new ProductRepository(dbContext);
            productView = Product_Form.GetInstance(view.ControlPanel);

            ProductPresenter.CreatePresenter(productView, productRepository);
        }

        private void CloseView(object? sender, EventArgs e)
        {
            productsView?.Close();
            productView?.Close(); 
        }
    }
}
