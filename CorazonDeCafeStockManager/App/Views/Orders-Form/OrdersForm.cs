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

namespace CorazonDeCafeStockManager.App.Views.OrdersForm
{
    public partial class OrdersForm : Form, IOrdersView
    {
        private readonly LoadFonts loadFonts;
        public string? Search { get { return ipSearch.Texts; } set { ipSearch.Texts = value!; } }
        public CalendarCustom StartDateCalendar { get { return startDate; } set { startDate = value!; } }
        public CalendarCustom EndDateCalendar { get { return endDate; } set { endDate = value!; } }
        public ComboBoxCustom SelectedPaymentMethod { get { return selectedPaymentMethod; } set { selectedPaymentMethod = value!; } }
        public ComboBoxCustom SelectedBillingType { get { return selectedBillingType; } set { selectedBillingType = value!; } }
        public IEnumerable<Order>? OrdersList { get; set; }
        public OrdersForm()
        {
            InitializeComponent();
            InitializeEvents();

            if (SessionManager.RoleId == 4)
            {
                btnEdit.Visible = false;
                SelectedBillingType.Visible = false;
                SelectedPaymentMethod.Visible = false;

                ordersDataGrid.Columns[4].Visible = false;
                ordersDataGrid.Columns[5].Visible = false;
            }

            loadFonts = new LoadFonts();
            SetForm();
        }

        private void SetForm()
        {
            ChangeDataGridViewFont(ordersDataGrid);

            ipSearch.Font = loadFonts.poppinsFont;
            startDate.Font = new Font(loadFonts.poppinsFont!.FontFamily, 9);
            endDate.Font = new Font(loadFonts.poppinsFont!.FontFamily, 9);

            StartDateCalendar.MaxDate = DateTime.Now.Date;
            EndDateCalendar.MaxDate = DateTime.Now.Date;

            StartDateCalendar.Value = DateTime.Now.Date;
            EndDateCalendar.Value = DateTime.Now.Date;
        }
        private void InitializeEvents()
        {
            ipSearch._TextChanged += (sender, e) => SearchEvent?.Invoke(this, EventArgs.Empty);
            startDate.ValueChanged += (sender, e) => FilterEvent?.Invoke(this, EventArgs.Empty);
            endDate.ValueChanged += (sender, e) => FilterEvent?.Invoke(this, EventArgs.Empty);
            selectedPaymentMethod.OnSelectedIndexChanged += (sender, e) => FilterEvent?.Invoke(this, EventArgs.Empty);
            selectedBillingType.OnSelectedIndexChanged += (sender, e) => FilterEvent?.Invoke(this, EventArgs.Empty);
            ordersDataGrid.CellContentClick += (sender, e) => ShowOrderDetailsEvent?.Invoke(this, e);
            reload.Click += (sender, e) => ResetOrdersEvent?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (sender, e) => HandleEditClick();
            if (SessionManager.RoleId != 4)
            {
                ordersDataGrid.DoubleClick += (sender, e) => HandleEditClick();
            }
        }
        private void HandleEditClick()
        {
            if (ordersDataGrid.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(ordersDataGrid.SelectedRows[0].Cells[0].Value);
                Order Order = OrdersList?.FirstOrDefault(p => p.Id == id)!;
                EditEvent?.Invoke(Order, EventArgs.Empty);
            }
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? FilterEvent;
        public event EventHandler? ResetOrdersEvent;
        public event DataGridViewCellEventHandler? ShowOrderDetailsEvent;
        public event EventHandler? EditEvent;

        public void LoadOrders()
        {
            if (ordersDataGrid.InvokeRequired)
            {
                ordersDataGrid.Invoke(new MethodInvoker(() => LoadOrdersInternal()));
            }
            else LoadOrdersInternal();
        }

        private void LoadOrdersInternal()
        {
            ordersDataGrid.Rows.Clear();
            ordersDataGrid.Refresh();

            OrdersList ??= LocalStorage.Orders;

            foreach (Order order in OrdersList!)
            {
                string active = order.Status == 1 ? "Activo" : "Inactivo";
                string fullName = order.Customer!.User.Name + " " + order.Customer!.User.Surname;
                string Date = order.CreatedAt.ToString()!.Split(' ')[0];

                ordersDataGrid.Rows.Add(order.Id, fullName, Date, order.TotalPrice, order.PaymentMethod.Description, order.BillingType.Description, active);
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

        private static OrdersForm? instance;
        public static OrdersForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new OrdersForm
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
