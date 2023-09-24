using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.EmployeeForm
{
    public interface IEmployeeView
    {

        // Properties 
        int? EmployeeId { get; set; }
        string? EmployeeName { get; set; }
        string? EmployeeSurname { get; set; }
        string? EmployeeEmail { get; set; }
        string? EmployeeUsername { get; set; }
        string? EmployeeRole { get; set; }
        string? EmployeePassword { get; set; }
        string? EmployeePassword2 { get; set; }
        int EmployeeDni { get; set; }
        string? EmployeePhone { get; set; }
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
