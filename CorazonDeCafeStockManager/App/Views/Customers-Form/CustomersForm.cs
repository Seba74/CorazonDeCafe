using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Views.Products_Form;

namespace CorazonDeCafeStockManager.App.Views.Customers_Form
{
    public partial class CustomersForm : Form, ICustomersView
    {
        private readonly LoadFonts loadFonts;
        public string? Search
        {
            get { return ipSearch.Texts; }
            set { ipSearch.Texts = value!; }
        }
        public DateTime? StartDate
        {
            get;
            set;
        }

        public DateTime? EndDate
        {
            get; 
            set; 
        }

        public IEnumerable<Client>? CustomersList { get; set; }

        public CustomersForm()
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
            reload.Click += delegate { ResetCustomersEvent?.Invoke(this, EventArgs.Empty); };
            btnAdd.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            btnEdit.Click += delegate
            {
                if (productList.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(productList.SelectedRows[0].Cells[0].Value);
                    Client customer = CustomersList!.Where(p => p.Id == id).FirstOrDefault()!;
                    EditEvent?.Invoke(customer, EventArgs.Empty);
                }
            };
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? FilterEvent;
        public event EventHandler? ResetCustomersEvent;
        public event EventHandler? AddEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;

        public void LoadCustomers()
        {
            if (productList.InvokeRequired)
            {
                productList.Invoke(new MethodInvoker(delegate
                {
                    productList.Rows.Clear();
                    productList.Refresh();

                    foreach (Client customer in CustomersList!)
                    {
                        // string active = product.Active == 1 ? "Activo" : "Inactivo";

                        // productList.Rows.Add(product.Id, product.Name, product.Price, product.Stock, product.Type.Name, product.Category.Name, active);
                    }
                }));
            }
            else
            {
                productList.Rows.Clear();
                productList.Refresh();

                foreach (Client customer in CustomersList!)
                {
                    // string active = product.Active == 1 ? "Activo" : "Inactivo";

                    // productList.Rows.Add(product.Id, product.Name, product.Price, product.Stock, product.Type.Name, product.Category.Name, active);
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

        private static CustomersForm? instance;
        public static CustomersForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersForm
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
