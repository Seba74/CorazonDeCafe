using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.CustomerForm
{
    public interface ICustomerView
    {

        // Properties 
        int? CustomerId { get; set; }
        int CustomerDni { get; set; }
        string? CustomerName { get; set; }
        string? CustomerSurname { get; set; }
        string? CustomerEmail { get; set; }
        string? CustomerPhone { get; set; }
        string? CustomerStreet { get; set; }
        int CustomerNumber { get; set; }
        string? CustomerCity { get; set; }
        string? CustomerProvince { get; set; }
        int CustomerPostalCode { get; set; }
        string? CustomerStatus { get; set; }
        string? Title { get; set; }
        ButtonCustom? BtnDelete { get; set; }
        // Events
        event EventHandler? CancelEvent;
        event KeyPressEventHandler? ValidateEvent;
        event EventHandler? DeleteEvent;
        event EventHandler? SaveEvent;
        // Methods
        void ShowError(string message);
        void Show();
        void Close();
    }
}
