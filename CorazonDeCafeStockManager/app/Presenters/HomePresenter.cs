using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repository;
using CorazonDeCafeStockManager.App.Repository._Repository;
using CorazonDeCafeStockManager.App.Views.Home_Form;
using CorazonDeCafeStockManager.App.Views.Login_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class HomePresenter
    {
        private readonly IHomeView view;
        private readonly CorazonDeCafeContext dbContext;

        public HomePresenter(IHomeView view, CorazonDeCafeContext dbContext)
        {
            this.view = view;
            this.dbContext = dbContext;
            this.view.ShowProductsView += ShowProductsView;
        }

        private void ShowProductsView(object? sender, EventArgs e)
        {
            IProductRepository productRepository = new ProductRepository(this.dbContext);
            IProductsView productView = new Products();
            new ProductPresenter(productView, productRepository);
            productView.Show();
        }
    }
}
