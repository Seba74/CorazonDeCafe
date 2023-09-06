using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.Products_Form;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductsPresenter
    {
        public static async Task CreatePresenter(IProductsView view, IProductRepository productRepository, HomePresenter homePresenter)
        {
            ProductsPresenter presenter = new(view, productRepository, homePresenter);
            await presenter.LoadAllProducts();
            presenter.view.LoadProducts();
            presenter.view.Show();
        }

        private readonly Timer SearchTimer = new(1500);
        private readonly IProductsView view;
        private readonly HomePresenter homePresenter;
        private readonly IProductRepository productRepository;
        private IEnumerable<Product>? products;
        private IEnumerable<Product>? productsBackUp;
        private string previousSearchText = string.Empty;
        public ProductsPresenter(IProductsView view, IProductRepository productRepository, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.productRepository = productRepository;
            this.view.SearchEvent += SearchEvent!;
            this.view.FilterEvent += FilterEvent!;
            this.view.ResetProductsEvent += ResetProductsEvent!;
            this.view.AddEvent += AddEvent!;

            SearchTimer.Elapsed += SearchProducts!;
        }
        private async Task LoadAllProducts()
        {
            products = await productRepository.GetAllProducts();
            productsBackUp = products;
            view.ProductsList = products;
        }

        private void SearchProducts(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            if (!string.IsNullOrEmpty(view.Search))
            {
                products = products?.Where(p => p.Nombre.ToLowerInvariant().Contains(view.Search!.ToLowerInvariant()));
            }
            else
            {
                products = view.ProductsList;
            }
            view.ProductsList = products;
            view.LoadProducts();
        }



        private void ResetProductsEvent(object sender, EventArgs e)
        {
            view.Search = string.Empty;
            view.SelectCategory = "Categoría";
            view.SelectType = "Tipo";

            products = productsBackUp;
            view.ProductsList = products;
            view.LoadProducts();
        }

        private void SearchEvent(object sender, EventArgs e)
        {
            SearchTimer.Stop();

            if (view.Search != previousSearchText)
            {
                previousSearchText = view.Search!;
                SearchTimer.Start();
            }
        }

        private void FilterEvent(object sender, EventArgs e)
        {
            IEnumerable<Product>? productsToFilter = productsBackUp;
            view.Search = string.Empty;
            if (view.SelectCategory != "Categoría")
            {
                productsToFilter = productsToFilter?.Where(p => p.Categoria.Nombre == view.SelectCategory);
            }

            if (view.SelectType != "Tipo")
            {
                productsToFilter = productsToFilter?.Where(p => p.Tipo.Nombre == view.SelectType);
            }

            view.ProductsList = productsToFilter;
            view.LoadProducts();
        }
        private void AddEvent(object sender, EventArgs e)
        {
            this.view.Close();
            this.homePresenter.ShowProductView();
        }





    }
}
