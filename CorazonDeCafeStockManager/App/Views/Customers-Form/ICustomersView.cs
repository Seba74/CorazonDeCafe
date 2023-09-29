using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.CustomersForm
{
    public interface ICustomersView
    {
        // Properties 
        string? Search { get; set; }
        Size Size { get; set; }
        IEnumerable<Customer>? CustomersList { get; set; }
        CalendarCustom startDateCalendar { get; set; }
        CalendarCustom endDateCalendar { get; set; }
        // Events
        event EventHandler? SearchEvent;
        event EventHandler? FilterEvent;
        event EventHandler? ResetCustomersEvent;
        event EventHandler? AddEvent;
        event EventHandler? EditEvent;

        // Methods
        void ShowError(string message);
        void LoadCustomers();
        void Show();
        void Hide();
        void Close();
    }
}
