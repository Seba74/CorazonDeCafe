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
        private System.Windows.Forms.Timer SearchTimer = new System.Windows.Forms.Timer(); private readonly Font poppinsFont;


        private IEnumerable<Product>? ProductsGridView { get; set; }
        public string? Search
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Products()
        {
            InitializeComponent();
            LoadFonts loadFonts = new();
            poppinsFont = new Font(loadFonts.poppinsFont!.FontFamily, 12, FontStyle.Regular);

            textBox1.Font = poppinsFont;
            SearchTimer.Interval = 1500;
            SearchTimer.Tick += SearchTimer_Tick!;

            pictureBox4.Visible = false;

        }
        public event EventHandler? SearchEvent;
        public event EventHandler? AddEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;

        public void LoadProducts(IEnumerable<Product> productsList)
        {
            ProductsGridView = productsList;
            if (productsList == null)
            {
                productList.Rows.Clear();
                productList.Refresh();
                return;
            }

            Color headerBackColor = Color.FromArgb(146, 90, 57);
            ChangeDataGridViewFont(productList);
            productList.EnableHeadersVisualStyles = false;
            productList.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;

            productList.Rows.Clear();
            productList.Refresh();

            foreach (Product product in ProductsGridView)
            {
                // string category = categories.Where(c => c.Id == product.Categoria_Id).FirstOrDefault()?.Nombre ?? "";
                // string type = types.Where(t => t.Id == product.Tipo_Id).FirstOrDefault()?.Nombre ?? "";
                // product.Estado = product.Estado == "SI" ? "Activo" : "Inactivo";
                // string price = "$" + product.Precio.ToString();
                productList.Rows.Add(product.Id, product.Nombre, product.Stock, product.Estado);
            }
        }

        private void ChangeDataGridViewFont(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.DefaultCellStyle.Font = poppinsFont;
                column.HeaderCell.Style.Font = poppinsFont;
            }
        }

        // private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // {
        //     // select button
        //     int productId = Convert.ToInt32(productList.Rows[e.RowIndex].Cells[0].Value);
        //     Product product = productsList.FirstOrDefault(p => p.Id == productId)!;
        //     MessageBox.Show(product?.Nombre);
        // }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            SearchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            // Products_Load(textBox1.Text);
        }

        private void selectCategory_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            // maximize
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
