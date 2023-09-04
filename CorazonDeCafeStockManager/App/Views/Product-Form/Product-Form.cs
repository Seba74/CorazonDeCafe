using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorazonDeCafeStockManager.App.Views.Product_Form;

namespace CorazonDeCafeStockManager
{
    public partial class Product_Form : Form, IProductView
    {
        public Product_Form()
        {
            InitializeComponent();
            LoadFonts loadFonts = new();
        }

        public string? Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Imagen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? CategoriaId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? TipoId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? Stock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Estado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler? CancelEvent;
        public event EventHandler? SaveEvent;

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
