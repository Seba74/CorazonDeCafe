using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager.App.Views.BillingForm
{
    public interface IBillingView
    {

        // Properties 
        string? SearchCustomer { get; set; }
        string? CustomerName { get; set; }
        string? CustomerAddress { get; set; }
        string? CustomerContact { get; set; }
        string? OrderSubtotal { get; set; }
        string? OrderIva { get; set; }
        string? OrderTotal { get; set; }
        ComboBoxCustom? BillingType { get; set; }
        ComboBoxCustom? PaymentMethod { get; set; }
        TextBoxCustom? CustomerCUIT { get; set; }
        ButtonCustom BtnSaveOrder { get; set; }
        ButtonCustom BtnCancelOrder { get; set; }
        ButtonCustom BtnCustomer { get; set; }
        IEnumerable<OrderProductData>? CartList { get; set; }
        Panel PanelProducts { get; set; }
        DataGridView Cart { get; set; }
        // Events
        event EventHandler BtnCustomerEvent;
        event EventHandler LookForCustomer;
        event EventHandler OrderTypeEvent;
        event EventHandler SaveOrderEvent;
        event EventHandler CancelOrderEvent;
        event KeyPressEventHandler? ValidateEvent;
        event DataGridViewCellEventHandler AmountChangedEvent;
        event DataGridViewCellEventHandler RemoveProductEvent;
        event EventHandler<DataGridViewEditingControlShowingEventArgs> ValidateAmountEvent;
        // Methods
        void ShowError(string message);
        void LoadProducts();
        void Show();
        void Hide();
        void Close();
    }
}
