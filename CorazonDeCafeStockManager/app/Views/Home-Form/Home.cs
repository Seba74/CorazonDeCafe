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

namespace CorazonDeCafeStockManager
{
    public partial class Home : Form, IHomeView
    {
        public Control ControlPanel { get { return this.viewPanel; } }
        public Home()
        {
            InitializeComponent();
            AssociateEvents();
        }

        private void AssociateEvents()
        {
            this.btnProducts.Click += delegate { this.ShowProductsView?.Invoke(this, EventArgs.Empty); };
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnNormal.Visible = false;
            this.btnMax.Visible = true;
        }
        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnNormal.Visible = true;
            this.btnMax.Visible = false;
        }

        private void viewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler? ShowProductsView;
        public event EventHandler? ShowProducView;
    }
}
