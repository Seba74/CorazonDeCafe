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
        private System.Windows.Forms.Timer searchTimer = new System.Windows.Forms.Timer();
        private readonly PrivateFontCollection privateFontCollection = new();
        private readonly Font poppinsFont;
        public Products()
        {
            InitializeComponent();
            poppinsFont = LoadFont();
            Products_Load();

            textBox1.Font = poppinsFont;
            productList.Font = poppinsFont;

            searchTimer.Interval = 1500;
            searchTimer.Tick += SearchTimer_Tick!;

        }

        private Font LoadFont()
        {
            string path = Path.Combine(Application.StartupPath, "fonts", "poppins.ttf");
            path = path.Replace("bin\\Debug\\net7.0-windows\\", "");

            privateFontCollection.AddFontFile(path);
            FontFamily fontFamily = privateFontCollection.Families[0];
            return new Font(fontFamily, 12, FontStyle.Regular);
        }

        private void Products_Load(string filter = "")
        {

            List<Product> products = new();
            List<Category> categories = new();
            List<Tipo> types = new();

            RequestProducts requestProducts = new();
            RequestCategoryAndType requestCategoryAndType = new();

            categories = requestCategoryAndType.GetCategories();
            types = requestCategoryAndType.GetTypes();
            products = requestProducts.GetProducts(filter);

            Color headerBackColor = Color.BurlyWood;
            ChangeDataGridViewFont(productList, poppinsFont);
            productList.EnableHeadersVisualStyles = false;
            productList.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;

            productList.Rows.Clear();
            productList.Refresh();

            foreach (Product product in products)
            {
                string category = categories.Where(c => c.Id == product.Categoria_Id).FirstOrDefault()?.Nombre ?? "";
                string type = types.Where(t => t.Id == product.Tipo_Id).FirstOrDefault()?.Nombre ?? "";
                product.Estado = product.Estado == "SI" ? "Activo" : "Inactivo";
                string price = "$" + product.Precio.ToString();
                productList.Rows.Add(product.Id, product.Nombre, price, product.Stock, type, category, product.Estado);
            }
        }

        private void ChangeDataGridViewFont(DataGridView dataGridView, Font font)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.DefaultCellStyle.Font = font;
                column.HeaderCell.Style.Font = font;
            }
        }

        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
    }
}
