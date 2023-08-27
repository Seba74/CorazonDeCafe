using System;
using System.Collections.Generic;
using System.Data;
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
            this.view.SearchEvent += SearchEvent!;

            LoadAllProducts();

            this.view.Show();
        }

        private void LoadAllProducts()
        {
            products = repository.GetAllProducts();
            this.view.LoadProducts(products);
        }

        private async void SearchEvent(object sender, EventArgs e)
        {
            if (view.Search != null)
            {
                products = await repository.GetAllProductsByFilter(view.Search);
                this.view.LoadProducts(products);
            }
            else
            {
                products = repository.GetAllProducts();
                this.view.LoadProducts(products);
            }
        }
    }
}
