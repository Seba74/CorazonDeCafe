using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Views.Products_Form;

namespace CorazonDeCafeStockManager
{
    public partial class Products : Form, IProductsView
    {
        private readonly LoadFonts loadFonts;
        public string? Search
        {
            get { return ipSearch.Texts; }
            set { ipSearch.Texts = value!; }
        }
        public string? SelectType
        {
            get { return selectType.Texts; }
            set { selectType.Texts = value!; }
        }

        public string? SelectCategory
        {
            get { return selectCategory.Texts; }
            set { selectCategory.Texts = value!; }
        }

        public IEnumerable<Product>? ProductsList { get; set; }

        public Products()
        {
            InitializeComponent();
            InitializeEvents();

            loadFonts = new LoadFonts();
            ChangeDataGridViewFont(productList);

            ipSearch.Font = loadFonts.poppinsFont;
            selectCategory.Font = loadFonts.poppinsFont;
            selectCategory.Font = new Font(loadFonts.poppinsFont!.FontFamily, 12);
        }
        private void InitializeEvents()
        {
            ipSearch._TextChanged += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            selectCategory.OnSelectedIndexChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            selectType.OnSelectedIndexChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            reload.Click += delegate { ResetProductsEvent?.Invoke(this, EventArgs.Empty); };
            btnAdd.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? FilterEvent;
        public event EventHandler? ResetProductsEvent;
        public event EventHandler? AddEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;

        public void LoadProducts()
        {
            if (productList.InvokeRequired)
            {
                productList.Invoke(new MethodInvoker(delegate
                {
                    productList.Rows.Clear();
                    productList.Refresh();

                    foreach (Product product in ProductsList!)
                    {
                        string active = product.Active == 1 ? "Activo" : "Inactivo";

                        productList.Rows.Add(product.Id, product.Name, product.Price, product.Stock, product.Type.Name, product.Category.Name, active);
                    }
                }));
            }
            else
            {
                productList.Rows.Clear();
                productList.Refresh();

                foreach (Product product in ProductsList!)
                {
                    string active = product.Active == 1 ? "Activo" : "Inactivo";

                    productList.Rows.Add(product.Id, product.Name, product.Price, product.Stock, product.Type.Name, product.Category.Name, active);
                }
            }
        }

        public void ChangeDataGridViewFont(DataGridView dataGridView)
        {
            Color colorFondoEncabezado = Color.FromArgb(146, 90, 57);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = colorFondoEncabezado;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.DefaultCellStyle.Font = loadFonts.poppinsFont;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = loadFonts.poppinsFont;
        }
        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }

        private static Products? instance;
        public static Products GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Products
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                };
                controlParent.Controls.Clear();
                controlParent.Controls.Add(instance);
                instance.Show();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
