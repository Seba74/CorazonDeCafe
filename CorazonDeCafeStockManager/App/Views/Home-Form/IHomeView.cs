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
        Control HomeButton { get; }
        Control ProductButton { get; }
        Control UserButton { get; }
        Control SaleButton { get; }
        Control ReportButton { get; }
        Control IconHeader { get; }
        Control TitleHeader { get; }


        event EventHandler? ShowProductsView;
        event EventHandler? CloseView;

        void RemoveBackgroundBtns();
        void Show();
    }
}
