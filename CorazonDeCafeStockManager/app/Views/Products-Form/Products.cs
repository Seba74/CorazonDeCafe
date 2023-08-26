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

namespace CorazonDeCafeStockManager
{
    public partial class Products : Form
    {
        private System.Windows.Forms.Timer searchTimer = new System.Windows.Forms.Timer(); private readonly Font poppinsFont;

        // List<Product> productsList = new();
        // List<Category> categories = new();
        // List<Tipo> types = new();
        public Products()
        {
            InitializeComponent();
            LoadFonts loadFonts = new();
            poppinsFont = new Font(loadFonts.poppinsFont!.FontFamily, 12, FontStyle.Regular);
            Products_Load();

            textBox1.Font = poppinsFont;
            searchTimer.Interval = 1500;
            searchTimer.Tick += SearchTimer_Tick!;

            pictureBox4.Visible = false;

        }

        private void Products_Load(string filter = "")
        {
            // RequestProducts requestProducts = new();
            // RequestCategoryAndType requestCategoryAndType = new();
            // categories = requestCategoryAndType.GetCategories();
            // types = requestCategoryAndType.GetTypes();
            // productsList = requestProducts.GetProducts(filter);

            Color headerBackColor = Color.FromArgb(146, 90, 57);
            ChangeDataGridViewFont(productList);
            productList.EnableHeadersVisualStyles = false;
            productList.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;

            productList.Rows.Clear();
            productList.Refresh();

            // foreach (Product product in productsList)
            // {
            //     string category = categories.Where(c => c.Id == product.Categoria_Id).FirstOrDefault()?.Nombre ?? "";
            //     string type = types.Where(t => t.Id == product.Tipo_Id).FirstOrDefault()?.Nombre ?? "";
            //     product.Estado = product.Estado == "SI" ? "Activo" : "Inactivo";
            //     string price = "$" + product.Precio.ToString();
            //     productList.Rows.Add(product.Id, product.Nombre, price, product.Stock, type, category, product.Estado);
            // }
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
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            Products_Load(textBox1.Text);
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
    }
}
