using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.OrdersForm
{
    public interface IOrdersView
    {

        // Properties 
        string? Search { get; set; }
        Size Size { get; set; }
        IEnumerable<Order>? OrdersList { get; set; }
        CalendarCustom StartDateCalendar { get; set; }
        CalendarCustom EndDateCalendar { get; set; }
        ComboBoxCustom SelectedPaymentMethod { get; set; }
        ComboBoxCustom SelectedBillingType { get; set; }
        // Events
        event EventHandler? SearchEvent;
        event EventHandler? FilterEvent;
        event EventHandler? ResetOrdersEvent;
        event DataGridViewCellEventHandler ShowOrderDetailsEvent;
        event EventHandler? EditEvent;

        // Methods
        void ShowError(string message);
        void LoadOrders();
        void Show();
        void Hide();
        void Close();
    }
}
