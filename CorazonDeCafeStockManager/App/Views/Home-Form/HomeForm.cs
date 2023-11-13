using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Views.HomeForm;

namespace CorazonDeCafeStockManager
{
    public partial class Home : Form, IHomeView
    {
        public Control ControlPanel { get { return viewPanel; } }
        public Control ProductButton { get { return btnProducts; } }
        public Control CustomerButton { get { return btnCustomers; } }
        public Control EmployeeButton { get { return btnEmployees; } }
        public Control BillingButton { get { return btnBilling; } }
        public Control OrderButton { get { return btnSales; } }
        public Control ReportButton { get { return btnReports; } }
        public Control BackupButton { get { return btnBackup; } }
        public Control ManualButton { get { return btnManual; } }
        public Control IconHeader { get { return iconHeader; } }
        public Control TitleHeader { get { return titleHeader; } }

        public Home()
        {
            InitializeComponent();
            AssociateEvents();
        }
        private void AssociateEvents()
        {
            btnProducts.Click += (_, __) => ShowProductsView?.Invoke(this, EventArgs.Empty);
            btnCustomers.Click += (_, __) => ShowCustomersView?.Invoke(this, EventArgs.Empty);
            btnEmployees.Click += (_, __) => ShowEmployeesView?.Invoke(this, EventArgs.Empty);
            btnBackup.Click += (_, __) => ShowBackupView?.Invoke(this, EventArgs.Empty);
            btnManual.Click += (_, __) => ShowManualView?.Invoke(this, EventArgs.Empty);
            btnBilling.Click += (_, __) => ShowBillingView?.Invoke(null, EventArgs.Empty);
            btnSales.Click += (_, __) => ShowOrdersView?.Invoke(null, EventArgs.Empty);
            btnReports.Click += (_, __) => ShowReportsView?.Invoke(null, EventArgs.Empty);
            btnClose.Click += (_, __) => Application.Exit();
            btnLogout.Click += (_, __) => LogoutEvent?.Invoke(this, EventArgs.Empty);
            btnMin.Click += (_, __) => WindowState = FormWindowState.Minimized;
            btnNormal.Click += (_, __) =>
            {
                WindowState = FormWindowState.Normal;
                btnNormal.Visible = false;
                btnMax.Visible = true;
            };
            btnMax.Click += (_, __) =>
            {
                WindowState = FormWindowState.Maximized;
                btnNormal.Visible = true;
                btnMax.Visible = false;
            };
        }

        public void RemoveBackgroundBtns()
        {
            btnProducts.BackColor = Color.Transparent;
            btnEmployees.BackColor = Color.Transparent;
            btnSales.BackColor = Color.Transparent;
            btnCustomers.BackColor = Color.Transparent;
            btnBilling.BackColor = Color.Transparent;
            btnReports.BackColor = Color.Transparent;
            btnBackup.BackColor = Color.Transparent;
            btnManual.BackColor = Color.Transparent;
        }

        public event EventHandler? ShowProductsView;
        public event EventHandler? ShowCustomersView;
        public event EventHandler? ShowEmployeesView;
        public event EventHandler? ShowReportsView;
        public event EventHandler? ShowBillingView;
        public event EventHandler? ShowOrdersView;
        public event EventHandler? ShowBackupView;
        public event EventHandler? ShowManualView;
        public event EventHandler? LogoutEvent;
    }
}
