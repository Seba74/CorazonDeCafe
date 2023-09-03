using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorazonDeCafeStockManager.App.Views.Home_Form
{
    public interface IHomeView
    {

        Control ControlPanel { get; }
        event EventHandler? ShowProductsView;
        event EventHandler? ShowProducView;
        void Show();
    }
}
