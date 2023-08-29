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
        public Home()
        {
            InitializeComponent();
            AssociateEvents();
        }

        private void AssociateEvents()
        {
            this.btnProducts.Click += delegate { this.ShowProductsView?.Invoke(this, EventArgs.Empty); };
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        { }

        public event EventHandler? ShowProductsView;
        public event EventHandler? ShowProducView;
    }
}
