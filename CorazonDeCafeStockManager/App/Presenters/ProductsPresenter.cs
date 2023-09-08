using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.Product_Form;
using CorazonDeCafeStockManager.App.Views.Products_Form;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductsPresenter
    {
        public static async Task CreatePresenter(IProductsView view, IProductRepository productRepository)
        {
            ProductsPresenter presenter = new(view, productRepository);
            await presenter.LoadAllProducts();
            presenter.view.LoadProducts();
            presenter.view.Show();
        }

        private readonly Timer SearchTimer = new(1500);
        private readonly IProductsView view;
        private readonly IProductRepository productRepository;
        private IEnumerable<Product>? products;
        private IEnumerable<Product>? productsBackUp;
        private string previousSearchText = string.Empty;
        public ProductsPresenter(IProductsView view, IProductRepository productRepository)
        {
            this.view = view;
            this.productRepository = productRepository;
            this.view.SearchEvent += SearchEvent!;
            this.view.FilterEvent += FilterEvent!;
            this.view.ResetProductsEvent += ResetProductsEvent!;
            this.view.AddEvent += AddEvent!;

            SearchTimer.Elapsed += SearchProducts!;
        }
        public async Task LoadAllProducts()
        {
            products = await productRepository.GetAllProducts();
            productsBackUp = products;
            view.ProductsList = products;
            view.LoadProducts();
        }

        public void ShowView()
        {
            view!.Show();
        }

        private void SearchProducts(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            if (!string.IsNullOrEmpty(view.Search))
            {
                products = products?.Where(p => p.Name.ToLowerInvariant().Contains(view.Search!.ToLowerInvariant()));
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
                productsToFilter = productsToFilter?.Where(p => p.Category.Name == view.SelectCategory);
            }

            if (view.SelectType != "Tipo")
            {
                productsToFilter = productsToFilter?.Where(p => p.Type.Name == view.SelectType);
            }

            view.ProductsList = productsToFilter;
            view.LoadProducts();
        }
        private void AddEvent(object sender, EventArgs e)
        {
            IProductView productView = new Product_Form();
            ProductPresenter.CreatePresenter(productView, this, productRepository);
        }
    }
}
