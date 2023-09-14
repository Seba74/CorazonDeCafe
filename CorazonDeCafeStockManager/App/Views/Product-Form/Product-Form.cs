using CorazonDeCafeStockManager.App.Views.Product_Form;

namespace CorazonDeCafeStockManager
{
    public partial class Product_Form : Form, IProductView
    {
        public int? ProductId { get; set; }
        public new string? ProductName
        {
            get => ipName.Texts;
            set
            {
                ipName.ForeColor = Color.Black;
                ipName.Texts = value!;
                title.Text = value!;
            }
        }
        public string? Title { get => title.Text; set => title.Text = value; }
        public string? ProductImagen { get; set; }
        public double ProductPrice
        {
            get
            {
                if (double.TryParse(ipPrice.Texts, out double price))
                    return price;
                return 0;
            }
            set
            {
                ipPrice.ForeColor = Color.Black;
                ipPrice.Texts = value.ToString();
            }
        }
        public string? ProductActive
        {
            get => ipState.Texts;
            set
            {
                ipState.ForeColor = Color.Black;
                ipState.Texts = value!;
            }
        }
        public string? ProductCategory
        {
            get => ipCategory.Texts;
            set
            {
                ipCategory.ForeColor = Color.Black;
                ipCategory.Texts = value!;
            }
        }
        public string? ProductType
        {
            get => ipType.Texts;
            set
            {
                ipType.ForeColor = Color.Black;
                ipType.Texts = value!;
            }
        }
        public int ProductStock
        {
            get
            {
                if (int.TryParse(ipStock.Texts, out int stock))
                    return stock;
                return -1;
            }
            set
            {
                ipStock.ForeColor = Color.Black;
                ipStock.Texts = value.ToString();
            }
        }

        public PictureBox? ShowImage { get => showImage; set => showImage = value!; }
        public PictureBox? BgImagen { get => bgImagen; set => bgImagen = value!; }
        public ButtonCustom? BtnAddImage { get => btnAddImage; set => btnAddImage = value!; }
        public ButtonCustom? BtnDelete { get => btnDelete; set => btnDelete = value!; }

        public Product_Form()
        {
            InitializeComponent();
            AssociateEvents();

            bgImagen.Controls.Add(showImage);
            showImage.Location = new Point(0, -28);
            showImage.BackColor = Color.Transparent;
        }

        private void AssociateEvents()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            btnGoBack.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            btnAddImage.Click += delegate { AddImageEvent?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            ipCategory.OnSelectedIndexChanged += delegate { ipCategory.ForeColor = Color.Black; };
            ipType.OnSelectedIndexChanged += delegate { ipType.ForeColor = Color.Black; };
            ipName.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipStock.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPrice.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
        }
        public event KeyPressEventHandler? ValidateEvent;
        public event EventHandler? CancelEvent;
        public event EventHandler? AddImageEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static Product_Form? instance;
        public static Product_Form GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Product_Form
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
