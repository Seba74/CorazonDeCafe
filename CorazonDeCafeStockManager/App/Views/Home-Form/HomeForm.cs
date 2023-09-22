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
        public Control SaleButton { get { return btnSales; } }
        public Control ReportButton { get { return btnReports; } }
        public Control IconHeader { get { return iconHeader; } }
        public Control TitleHeader { get { return titleHeader; } }

        public Home()
        {
            InitializeComponent();  
            AssociateEvents();
        }

        private void AssociateEvents()
        {
            btnProducts.Click += delegate { ShowProductsView?.Invoke(this, EventArgs.Empty); };
            btnCustomers.Click += delegate { ShowCustomersView?.Invoke(this, EventArgs.Empty); };
            btnEmployees.Click += delegate { ShowEmployeesView?.Invoke(this, EventArgs.Empty); };
            btnHome.Click += delegate { CloseView?.Invoke(this, EventArgs.Empty); };

            btnClose.Click += delegate { Application.Exit(); };
            btnMin.Click += delegate { WindowState = FormWindowState.Minimized; };
            btnNormal.Click += delegate
            {
                WindowState = FormWindowState.Normal;
                btnNormal.Visible = false;
                btnMax.Visible = true;
            };
            btnMax.Click += delegate
            {
                WindowState = FormWindowState.Maximized;
                btnNormal.Visible = true;
                btnMax.Visible = false;
            };

            btnHome.Click += delegate
            {
                RemoveBackgroundBtns();
                btnHome.BackColor = Color.FromArgb(255, 219, 197);

                IconHeader.BackgroundImage = Properties.Resources.home;
                TitleHeader.Text = "INICIO";
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
