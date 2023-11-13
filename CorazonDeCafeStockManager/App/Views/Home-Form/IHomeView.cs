namespace CorazonDeCafeStockManager.App.Views.HomeForm
{
    public interface IHomeView
    {
        Control ControlPanel { get; }
        Control ProductButton { get; }
        Control CustomerButton { get; }
        Control EmployeeButton { get; }
        Control OrderButton { get; }
        Control BillingButton { get; }
        Control BackupButton { get; }
        Control ReportButton { get; }
        Control ManualButton { get; }
        Control IconHeader { get; }
        Control TitleHeader { get; }

        event EventHandler? ShowProductsView;
        event EventHandler? ShowCustomersView;
        event EventHandler? ShowEmployeesView;
        event EventHandler? ShowBillingView;
        event EventHandler? ShowOrdersView;
        event EventHandler? ShowBackupView;
        event EventHandler? ShowManualView;
        event EventHandler? ShowReportsView;
        event EventHandler? LogoutEvent;

        void RemoveBackgroundBtns();
        void Show();
        void Hide();
        void Close();
    }
}
