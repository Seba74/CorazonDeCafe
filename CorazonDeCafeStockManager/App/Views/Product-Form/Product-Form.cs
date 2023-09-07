using CorazonDeCafeStockManager.App.Views.Product_Form;

namespace CorazonDeCafeStockManager
{
    public partial class Product_Form : Form, IProductView
    {
        public string? Nombre
        {
            get => ipName.Texts;
            set => ipName.Texts = value!;
        }
        public string? Imagen { get; set; }
        public float Precio
        {
            get
            {
                if (float.TryParse(ipPrice.Texts, out float precio))
                    return precio;
                return 0; // Valor predeterminado en caso de entrada no válida.
            }
            set => ipPrice.Texts = value.ToString();
        }
        public string? Estado
        {
            get => ipState.Texts;
            set => ipState.Texts = value!;
        }
        public string? Categoria
        {
            get => ipCategory.Texts;
            set => ipCategory.Texts = value!;
        }
        public string? Tipo
        {
            get => ipType.Texts;
            set => ipType.Texts = value!;
        }
        public int? Stock
        {
            get
            {
                if (int.TryParse(ipStock.Texts, out int stock))
                    return stock;
                return -1; // Valor predeterminado en caso de entrada no válida.
            }
            set => ipStock.Texts = value.ToString()!;
        }

        public PictureBox? ShowImage { get => showImage; set => showImage = value!; }
        public PictureBox? BgImagen { get => bgImagen; set => bgImagen = value!; }
        public ButtonCustom? BtnAddImage { get => btnAddImage; set => BtnAddImage = value!; }

        public Product_Form()
        {
            InitializeComponent();
            AssociateEvents();

            bgImagen.Controls.Add(showImage);
            showImage.Location = new Point(0, 0);
            showImage.BackColor = Color.Transparent;
        }

        private void AssociateEvents()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            btnAddImage.Click += delegate { AddImageEvent?.Invoke(this, EventArgs.Empty); };
            ipCategory.OnSelectedIndexChanged += delegate { ipCategory.ForeColor = Color.Black; };
            ipType.OnSelectedIndexChanged += delegate { ipType.ForeColor = Color.Black; };
            ipName.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPrice.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipStock.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
        }
        public event KeyPressEventHandler? ValidateEvent;
        public event EventHandler? CancelEvent;
        public event EventHandler? AddImageEvent;
        public event EventHandler? SaveEvent;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
