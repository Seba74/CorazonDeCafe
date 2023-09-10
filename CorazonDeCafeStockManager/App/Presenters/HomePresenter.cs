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
        private ProductsPresenter? productsPresenter;
        private ProductPresenter? productPresenter;

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

        private void ShowProductsView(object? sender, EventArgs e)
        {
            view.RemoveBackgroundBtns();
            view.ProductButton.BackColor = Color.FromArgb(255, 219, 197);

            view.IconHeader.BackgroundImage = Properties.Resources.coffee1;
            view.TitleHeader.Text = "PRODUCTOS";

            IProductRepository productRepository = new ProductRepository(dbContext);
            IProductsView productsView = Products.GetInstance(view.ControlPanel);
            productsPresenter = new(productsView, productRepository, this);
        }

        public void ShowProductView(Product? product)
        {
            IProductRepository productRepository = new ProductRepository(dbContext);
            IProductView productView = Product_Form.GetInstance(view.ControlPanel);

            if (product != null)
            {
                productView.ProductName = product.Name;
                productView.ProductCategory = product.Category.Name;
                productView.ProductType = product.Type.Name;
                productView.ProductPrice = product.Price;
                productView.ProductStock = product.Stock;
                productView.ProductActive = product.Active == 1 ? "Activo" : "Inactivo";
                productView.ProductId = product.Id;
            }
            productsPresenter!.CloseView();
            productPresenter = new(productView, productsPresenter!, productRepository);
        }

        private void CloseView(object? sender, EventArgs e)
        {
            productsPresenter?.CloseView();
            productPresenter?.CloseView();
        }
    }
}
