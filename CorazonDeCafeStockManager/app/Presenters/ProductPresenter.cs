using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.Login_Form;
using System.Globalization;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductPresenter
    {
        public static async Task CreatePresenter(IProductsView view, IProductRepository productRepository)
        {
            ProductPresenter presenter = new(view, productRepository);
            await presenter.LoadAllProducts();
            presenter.view.LoadProducts();
            presenter.view.Show();
        }

        private readonly Timer SearchTimer = new(1500);
        private readonly IProductsView view;
        private readonly IProductRepository productRepository;
        private IEnumerable<Product>? products;
        public ProductPresenter(IProductsView view, IProductRepository productRepository)
        {
            this.view = view;
            this.productRepository = productRepository;
            this.view.SearchEvent += SearchEvent!;
            SearchTimer.Elapsed += SearchProducts!;
        }
        private async Task LoadAllProducts()
        {
            products = await productRepository.GetAllProducts();
            this.view.ProductsList = products;
        }

        private async void SearchProducts(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            if (!string.IsNullOrEmpty(view.Search))
            {
                products = productRepository.GetAllProductsByFilter(view.Search.ToLowerInvariant());
            }
            else
            {
                products = await productRepository.GetAllProducts();
            }
            this.view.ProductsList = products;
            this.view.LoadProducts();
        }

        private void SearchEvent(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            SearchTimer.Start();
        }
    }
}
