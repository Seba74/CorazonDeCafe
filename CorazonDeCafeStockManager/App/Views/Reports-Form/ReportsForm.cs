using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.ReportsForm
{
    public partial class ReportsForm : Form, IReportsView
    {

        public string PaymentPop { get => paymentPop.Text; set => paymentPop.Text = value; }
        public string LastOrders { get => lastOrders.Text; set => lastOrders.Text = value; }
        public string ProductPop { get => productPop.Text; set => productPop.Text = value; }
        public string CustomerPop { get => customerPop.Text; set => customerPop.Text = value; }
        public ComboBoxCustom SelectedEmployee { get => selectedEmployee; set => selectedEmployee = value; }
        public ComboBoxCustom SelectedEmployee2 { get => selectedEmployee2; set => selectedEmployee2 = value; }
        public CalendarCustom StartDateBillings { get => startDate; set => startDate = value; }
        public CalendarCustom StartDateAmount { get => startDate2; set => startDate2 = value; }
        public CalendarCustom EndDateBillings { get => endDate; set => endDate = value; }
        public CalendarCustom EndDateAmount { get => endDate2; set => endDate2 = value; }
        public Chart ChartAmount { get => chartAmount; set => chartAmount = value; }
        public Chart ChartBillings { get => chartBillings; set => chartBillings = value; }
        public Panel PanelBillings { get => panelBillings; set => panelBillings = value; }
        public Panel PanelOrders { get => panelOrders; set => panelOrders = value; }

        public ReportsForm()
        {
            InitializeComponent();
            InitializeEvents();
            PanelOrders.Visible = false;

            if (SessionManager.RoleId == 4)
            {
                selectedEmployee.Visible = false;
                labelEmployee.Visible = false;
                PanelOrders.Visible = true;
                PanelBillings.Visible = false;
            }
        }

        private void InitializeEvents()
        {
            filterBillings.Click += (sender, e) => SearchBillingsEvent?.Invoke(sender, e);
            filterAmount.Click += (sender, e) => SearchAmountEvent?.Invoke(sender, e);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public event EventHandler? SearchBillingsEvent;
        public event EventHandler? SearchAmountEvent;

        private static ReportsForm? instance;
        public static ReportsForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ReportsForm
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
