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
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.CustomersForm
{
    public partial class CustomersForm : Form, ICustomersView
    {
        private readonly LoadFonts loadFonts;
        public string? Search { get { return ipSearch.Texts; } set { ipSearch.Texts = value!; } }
        public CalendarCustom startDateCalendar { get { return startDate; } set { startDate = value!; } }
        public CalendarCustom endDateCalendar { get { return endDate; } set { endDate = value!; } }
        public IEnumerable<Customer>? CustomersList { get; set; }

        public CustomersForm()
        {
            InitializeComponent();
            InitializeEvents();

            loadFonts = new LoadFonts();
            SetForm();
        }

        private void SetForm()
        {
            ChangeDataGridViewFont(customersDataGrid);

            ipSearch.Font = loadFonts.poppinsFont;
            startDate.Font = new Font(loadFonts.poppinsFont!.FontFamily, 9);
            endDate.Font = new Font(loadFonts.poppinsFont!.FontFamily, 9);

            startDateCalendar.MaxDate = DateTime.Now.Date;
            endDateCalendar.MaxDate = DateTime.Now.Date;

            startDateCalendar.Value = DateTime.Now.Date;
            endDateCalendar.Value = DateTime.Now.Date;
        }
        private void InitializeEvents()
        {
            if (SessionManager.Id != 1 && SessionManager.Id != 2)
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                customersDataGrid.DoubleClick += (_, __) => HandleActionEvent(HandleSelectCustomer);
            }
            else customersDataGrid.DoubleClick += (_, __) => HandleActionEvent(HandleEditClick);

            ipSearch._TextChanged += (sender, e) => SearchEvent?.Invoke(this, EventArgs.Empty);
            startDate.ValueChanged += (sender, e) => FilterEvent?.Invoke(this, EventArgs.Empty);
            endDate.ValueChanged += (sender, e) => FilterEvent?.Invoke(this, EventArgs.Empty);
            reload.Click += (sender, e) => ResetCustomersEvent?.Invoke(this, EventArgs.Empty);
            btnAdd.Click += (sender, e) => AddEvent?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (sender, e) => HandleActionEvent(HandleEditClick);
        }

        private void HandleActionEvent(Action<Customer> action)
        {
            if (customersDataGrid.SelectedRows.Count > 0)
            {
                string dni = Convert.ToInt32(customersDataGrid.SelectedRows[0].Cells[0].Value).ToString();
                Customer customer = CustomersList?.FirstOrDefault(p => p.User.Dni == dni)!;
                action?.Invoke(customer);
            }
        }

        private void HandleEditClick(Customer customer)
        {
            EditEvent?.Invoke(customer, EventArgs.Empty);
        }

        private void HandleSelectCustomer(Customer customer)
        {
            SelectCustomerEvent?.Invoke(customer, EventArgs.Empty);
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? FilterEvent;
        public event EventHandler? ResetCustomersEvent;
        public event EventHandler? SelectCustomerEvent;
        public event EventHandler? AddEvent;
        public event EventHandler? EditEvent;

        public void LoadCustomers()
        {
            if (customersDataGrid.InvokeRequired)
            {
                customersDataGrid.Invoke(new MethodInvoker(() => LoadCustomersInternal()));
            }
            else LoadCustomersInternal();
        }

        private void LoadCustomersInternal()
        {
            customersDataGrid.Rows.Clear();
            customersDataGrid.Refresh();

            foreach (Customer customer in CustomersList!)
            {
                string active = customer.User.Status == 1 ? "Activo" : "Inactivo";
                string fullName = customer.User.Name + " " + customer.User.Surname;

                customersDataGrid.Rows.Add(customer.User.Dni, fullName, customer.User.Email, customer.User.Phone, customer.User.Address!.City, customer.User.Address!.Province, active);
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
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
