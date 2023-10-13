using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.ProductsForm;
using Timer = System.Timers.Timer;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductsPresenter
    {
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
            this.view.EditEvent += EditEvent!;
            this.view.AddProductToCartEvent += (s, e) => AddProductToCartEvent?.Invoke(s, e);

            SearchTimer.Elapsed += SearchProducts!;

            _ = LoadAllProducts();
            this.view.Show();
        }
        public async Task LoadAllProducts()
        {
            products = await productRepository.GetAllProducts();
            productsBackUp = products;
            view.ProductsList = products;
            view.LoadProducts();
        }

        public void RemoveColumnFromDataGrid(int columnIndex)
        {
            view.ProductsGrid.Columns[columnIndex].Visible = false;
        }

        public void ShowView() => view!.Show();
        public void CloseView() => view!.Close();

        private void SearchProducts(object sender, EventArgs e)
        {
            SearchTimer.Stop();

            if (!string.IsNullOrEmpty(view.Search))
            {
                if (int.TryParse(view.Search, out int id))
                {
                    view.ProductsList = products?.Where(p => p.Id == id);
                }
                else
                {
                    view.ProductsList = products?.Where(p => p.Name.ToLowerInvariant().Contains(view.Search!.ToLowerInvariant()));
                }
            }
            else
            {
                view.ProductsList = products;
            }
            view.LoadProducts();
        }

        public event EventHandler? AddProductToCartEvent;

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
            products = productsToFilter;
            view.LoadProducts();
        }

        private void AddEvent(object sender, EventArgs e)
        {
            this.view.Close();
            this.homePresenter.ShowProductView(null, e);
        }

        private void EditEvent(object sender, EventArgs e)
        {
            Product product = (Product)sender;
            this.view.Close();
            this.homePresenter.ShowProductView(product, e);
        }
    }
}
