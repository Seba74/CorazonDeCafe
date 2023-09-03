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
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Views.Login_Form;

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
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? AddEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;

        public void LoadProducts()
        {
            if (productList.InvokeRequired)
            {
                productList.Invoke(new MethodInvoker(delegate
                {
                    LoadProducts();
                }));
                return;
            }

            productList.Rows.Clear();
            productList.Refresh();

            foreach (Product product in ProductsList!)
            {
                product.Estado = product.Estado == "SI" ? "Activo" : "Inactivo";

                productList.Rows.Add(product.Id, product.Nombre, product.Precio, product.Stock, product.Tipo.Nombre, product.Categoria.Nombre, product.Estado);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
