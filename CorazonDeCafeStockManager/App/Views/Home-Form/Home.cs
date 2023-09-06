using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Views.Home_Form;
using MySqlX.XDevAPI;

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
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RemoveBackgroundBtns()
        {
            btnHome.BackColor = Color.Transparent;
            btnProducts.BackColor = Color.Transparent;
            btnUsers.BackColor = Color.Transparent;
            btnSales.BackColor = Color.Transparent;
            btnStats.BackColor = Color.Transparent;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMax.Visible = true;
        }
        private void BtnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnNormal.Visible = true;
            btnMax.Visible = false;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            RemoveBackgroundBtns();
            HomeButton.BackColor = Color.FromArgb(255, 219, 197);

            IconHeader.BackgroundImage = Properties.Resources.home;
            TitleHeader.Text = "INICIO";
        }

        public event EventHandler? ShowProductsView;
        public event EventHandler? ShowProductView;
        public event EventHandler? CloseView;
    }
}
