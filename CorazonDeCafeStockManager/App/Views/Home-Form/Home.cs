using CorazonDeCafeStockManager.App.Views.Home_Form;

namespace CorazonDeCafeStockManager
{
    public partial class Home : Form, IHomeView
    {
        public Control ControlPanel { get { return viewPanel; } }
        public Control HomeButton { get { return btnHome; } }
        public Control ProductButton { get { return btnProducts; } }
        public Control UserButton { get { return btnUsers; } }
        public Control SaleButton { get { return btnSales; } }
        public Control ReportButton { get { return btnStats; } }
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
            btnHome.Click += delegate { CloseView?.Invoke(this, EventArgs.Empty); };

            btnClose.Click += delegate { Close(); };
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
            btnUsers.BackColor = Color.Transparent;
            btnSales.BackColor = Color.Transparent;
            btnStats.BackColor = Color.Transparent;
        }

        public event EventHandler? ShowProductsView;
        public event EventHandler? CloseView;
    }
}
