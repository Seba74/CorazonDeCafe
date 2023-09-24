using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Views.HomeForm;

namespace CorazonDeCafeStockManager
{
    public partial class Home : Form, IHomeView
    {
        public Control ControlPanel { get { return viewPanel; } }
        public Control HomeButton { get { return btnHome; } }
        public Control ProductButton { get { return btnProducts; } }
        public Control CustomerButton { get { return btnCustomers; } }
        public Control EmployeeButton { get { return btnEmployees; } }
        public Control BillingButton { get { return btnBilling; } }
        public Control SaleButton { get { return btnSales; } }
        public Control ReportButton { get { return btnReports; } }
        public Control BackupButton { get { return btnBackup; } }
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
            btnClose.Click += (_, __) => Application.Exit();
            btnMin.Click += (_, __) => WindowState = FormWindowState.Minimized;
            btnHome.Click += (_, __) =>
            {
                CloseView?.Invoke(this, EventArgs.Empty);
                RemoveBackgroundBtns();
                btnHome.BackColor = Color.FromArgb(255, 219, 197);
                IconHeader.BackgroundImage = Properties.Resources.home;
                TitleHeader.Text = "INICIO";
            };
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
            btnHome.BackColor = Color.Transparent;
            btnProducts.BackColor = Color.Transparent;
            btnEmployees.BackColor = Color.Transparent;
            btnSales.BackColor = Color.Transparent;
            btnCustomers.BackColor = Color.Transparent;
        }

        public event EventHandler? ShowProductsView;
        public event EventHandler? ShowCustomersView;
        public event EventHandler? ShowEmployeesView;
        public event EventHandler? CloseView;
    }
}
