using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager.App.Views.OrderForm
{
    public interface IOrderView
    {

        // Properties 
        int? OrderId { get; set; }
        string? OrderCustomerName { get; set; }
        string? OrderCustomerSurname { get; set; }
        string? OrderCustomerDNI { get; set; }
        string? OrderBillingType { get; set; }
        string? OrderPaymentMethod { get; set; }
        string? OrderEmployeeName { get; set; }
        string? OrderTotal { get; set; }
        ComboBoxCustom? OrderStatus { get; set; }
        string? Title { get; set; }
        // Events
        event EventHandler? CancelEvent;
        event EventHandler? SaveEvent;
        // Methods
        void ShowError(string message);
        void Show();
        void Close();
    }
}
