using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using Microsoft.IdentityModel.Tokens;

namespace CorazonDeCafeStockManager.App.Views.PrintedBillingForm
{
    public partial class PrintedBillingForm : Form
    {
        private readonly LoadFonts loadFonts;
        public PrintedBillingForm()
        {
            InitializeComponent();
            loadFonts = new LoadFonts();
            ChangeDataGridViewFont(cartGrid);
            closeBtn.Click += (sender, args) => Close();
        }

        private void ChangeDataGridViewFont(DataGridView dataGridView)
        {
            Color colorFondoEncabezado = Color.FromArgb(146, 90, 57);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = colorFondoEncabezado;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.DefaultCellStyle.Font = loadFonts.poppinsFont;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = loadFonts.poppinsFont;
        }

        public void SetDataToPrintedBillingForm(Order order)
        {
            SetStoreData();
            SetCustomerData(order);
            SetOrderData(order);
            SetCartData(order);
        }

        private void SetCustomerData(Order order)
        {
            lblCustomerName.Text = order.Customer!.User.Name + " " + order.Customer.User.Surname;
            lblCustomerPhone.Text = order.Customer.User.Phone;
            lblCustomerAddress.Text = order.Customer.User.Address!.Street + " " + order.Customer.User.Address.Number;
            lblCustomerLocation.Text = order.Customer.User.Address.City + ", " + order.Customer.User.Address.Province;
            if (!order.CustomerCuit.IsNullOrEmpty())
            {
                lblCustomerCUIT.Enabled = true;
                lblCustomerCUIT.Text = order.CustomerCuit;
            }
            else lblCustomerCUIT.Enabled = false;
        }

        private void SetStoreData()
        {
            lblCoffeeName.Text = "Corazón de Café";
            lblCoffeePhone.Text = "11-1234-5678";
            lblCoffeeAddress.Text = "Av. Siempre Viva 123";
            lblCoffeeLocation.Text = "Corrientes, Corrientes";
        }

        private void SetOrderData(Order order)
        {
            lblBillingCode.Text = order.Id.ToString();
            lblBillingDate.Text = order.CreatedAt.ToString();
            lblPaymentMethod.Text = order.PaymentMethod.Description;
            orderSubtotal.Text = GetOrderSubtotal(order).ToString("0.00");
            orderIVA.Text = (GetOrderSubtotal(order) * 0.19).ToString("0.00");
            orderTotal.Text = order.TotalPrice.ToString("0.00");
        }

        private void SetCartData(Order order)
        {
            foreach (OrderProduct orderProduct in order.OrderProducts!)
            {
                cartGrid.Rows.Add(orderProduct.Product!.Name, orderProduct.Product.Price, orderProduct.Amount);
            }
        }

        private double GetOrderSubtotal(Order order)
        {
            double subtotal = 0;
            foreach (OrderProduct orderProduct in order.OrderProducts)
            {
                subtotal += orderProduct.Price * orderProduct.Amount;
            }
            return subtotal;
        }
    }
}
