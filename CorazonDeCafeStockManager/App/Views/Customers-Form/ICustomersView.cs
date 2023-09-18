using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.Products_Form
{
    public interface ICustomersView
    {

        // Properties 
        string? Search { get; set; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
        Size Size { get; set; }
        IEnumerable<Client>? CustomersList { get; set; }
        // Events
        event EventHandler? SearchEvent;
        event EventHandler? FilterEvent;
        event EventHandler? ResetCustomersEvent;
        event EventHandler? AddEvent;
        event EventHandler? EditEvent;
        event EventHandler? DeleteEvent;

        // Methods
        void ShowError(string message);
        void LoadCustomers();
        void Show();
        void Hide();
        void Close();
    }
}
