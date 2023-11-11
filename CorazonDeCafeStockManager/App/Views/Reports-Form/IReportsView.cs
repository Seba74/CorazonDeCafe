using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.ReportsForm
{
    public interface IReportsView
    {
        // Properties
        string LastOrders { get; set; }
        string PaymentPop { get; set; }
        string ProductPop { get; set; }
        string CustomerPop { get; set; }
        ComboBoxCustom SelectedEmployee { get; set; }
        ComboBoxCustom SelectedEmployee2 { get; set; }
        CalendarCustom StartDateBillings { get; set; }
        CalendarCustom StartDateAmount { get; set; }
        CalendarCustom EndDateBillings { get; set; }
        CalendarCustom EndDateAmount { get; set; }
        Chart ChartAmount { get; set; }
        Chart ChartBillings { get; set; }
        Panel PanelBillings { get; set; }
        Panel PanelOrders { get; set; }

        // Events
        event EventHandler Load;
        event EventHandler SearchBillingsEvent;
        event EventHandler SearchAmountEvent;

        // Methods
        void ShowError(string message);
        void Show();
        void Close();
    }
}
