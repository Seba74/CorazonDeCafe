using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.Login_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductPresenter
    {
        private readonly IProductsView view;
        private readonly IProductRepository repository;

        private IEnumerable<Product>? products;

        public ProductPresenter(IProductsView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
            LoadAllProducts();
            this.view.SearchEvent += SearchEvent!;
            this.view.Show();
        }

        private async void LoadAllProducts()
        {
            products = await repository.GetAllProducts();
            if (products != null)
                view.LoadProducts(products);
        }

        private async void SearchEvent(object sender, EventArgs e)
        {
            if (view.Search != null)
            {
                products = await repository.GetAllProductsByFilter(view.Search);
                view.LoadProducts(products);
            }
            else
            {
                products = await repository.GetAllProducts();
                view.LoadProducts(products);
            }
        }
    }
}
