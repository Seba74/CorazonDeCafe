using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Repositories._Repository;
using CorazonDeCafeStockManager.App.Views.Login_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductPresenter
    {
        private readonly IProductsView view;
        private readonly IProductRepository productRepository;
        private IEnumerable<Product>? products;
        public ProductPresenter(IProductsView view, IProductRepository productRepository)
        {
            this.view = view;
            this.productRepository = productRepository;
            this.view.SearchEvent += SearchEvent!;
        }

        public static async Task CreateAsync(IProductsView view, IProductRepository productRepository)
        {
            ProductPresenter presenter = new(view, productRepository);
            await presenter.LoadAllProducts();
            presenter.view.LoadProducts();
            presenter.view.Show();
        }

        private async Task LoadAllProducts()
        {
            products = await productRepository.GetAllProducts();
            this.view.ProductsList = products;
        }

        private void SearchEvent(object sender, EventArgs e)
        {
            // SearchTimer.Stop();
            if (view.Search != null)
            {
                products = productRepository.GetAllProductsByFilter(view.Search);
                // this.view.LoadProducts(products);
            }
            else
            {
                // products = productRepository.GetAllProducts();
                // this.view.LoadProducts(products);
            }
        }
    }
}
