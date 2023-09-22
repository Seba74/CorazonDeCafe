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
        Control ReportButton { get; }
        Control IconHeader { get; }
        Control TitleHeader { get; }

        event EventHandler? ShowProductsView;
        event EventHandler? ShowCustomersView;
        event EventHandler? ShowEmployeesView;
        event EventHandler? CloseView;

        void RemoveBackgroundBtns();
        void Show();

        void Close();
    }
}
