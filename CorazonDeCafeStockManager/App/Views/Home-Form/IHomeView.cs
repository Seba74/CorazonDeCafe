namespace CorazonDeCafeStockManager.App.Views.HomeForm
{
    public interface IHomeView
    {
        Control ControlPanel { get; }
        Control HomeButton { get; }
        Control ProductButton { get; }
        Control CustomerButton { get; }
        Control EmployeeButton { get; }
        Control SaleButton { get; }
        Control BillingButton { get; }
        Control BackupButton { get; }
        Control ReportButton { get; }
        Control IconHeader { get; }
        Control TitleHeader { get; }

        event EventHandler? ShowProductsView;
        event EventHandler? ShowCustomersView;
        event EventHandler? ShowEmployeesView;
        event EventHandler? ShowBackupView;
        event EventHandler? CloseView;
        event EventHandler? LogoutEvent;

        void RemoveBackgroundBtns();
        void Show();
        void Hide();
        void Close();
    }
}
