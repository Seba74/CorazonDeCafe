using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Repository;
using CorazonDeCafeStockManager.App.Views.Login_Form;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductPresenter
    {
        private readonly IProductsView view;
        private readonly IProductRepository repository;

        public ProductPresenter(IProductsView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
    }
}
