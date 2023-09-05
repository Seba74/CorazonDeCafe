using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.Product_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductPresenter
    {
        public static void CreatePresenter(IProductView view, IProductRepository productRepository)
        {
            ProductPresenter presenter = new(view, productRepository);
            presenter.view.Show();
        }

        private readonly IProductView view;
        private readonly IProductRepository productRepository;
      
        public ProductPresenter(IProductView view, IProductRepository productRepository)
        {
            this.view = view;
            this.productRepository = productRepository;

        }
        

    }
}
