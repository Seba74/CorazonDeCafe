using CorazonDeCafeStockManager.App.Views.ProductForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager
{
    public partial class ProductForm : Form, IProductView
    {
        public int? ProductId { get; set; }
        public new string? ProductName
        {
            get => ipName.Texts;
            set
            {
                SetControlText(ipName, value);
                title.Text = value!;
            }
        }
        public string? Title
        {
            get => title.Text;
            set => title.Text = value;
        }
        public string? ProductImagen { get; set; }
        public double ProductPrice
        {
            get => ParseDouble(ipPrice.Texts);
            set => SetControlText(ipPrice, value.ToString());
        }
        public string? ProductActive
        {
            get => ipState.Texts;
            set => SetControlText(ipState, value);
        }
        public string? ProductCategory
        {
            get => ipCategory.Texts;
            set => SetControlText(ipCategory, value);
        }
        public string? ProductType
        {
            get => ipType.Texts;
            set => SetControlText(ipType, value);
        }
        public int ProductStock
        {
            get => ParseInt(ipStock.Texts);
            set => SetControlText(ipStock, value.ToString());
        }
        public PictureBox? ShowImage { get => showImage; set => showImage = value!; }
        public PictureBox? BgImagen { get => bgImagen; set => bgImagen = value!; }
        public ButtonCustom? BtnAddImage { get => btnAddImage; set => btnAddImage = value!; }
        public ButtonCustom? BtnDelete { get => btnDelete; set => btnDelete = value!; }

        private double ParseDouble(string? text)
        {
            if (double.TryParse(text, out double value))
            {
                return value;
            }
            return 0;
        }

        private int ParseInt(string? text)
        {
            if (int.TryParse(text, out int value))
            {
                return value;
            }
            return -1;
        }

        public ProductForm()
        {
            InitializeComponent();
            AssociateEvents();

            bgImagen.Controls.Add(showImage);
            showImage.Location = new Point(0, -28);
            showImage.BackColor = Color.Transparent;
        }

        private void AssociateEvents()
        {
            btnSave.Click += (_, __) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (_, __) => CancelEvent?.Invoke(this, EventArgs.Empty);
            btnGoBack.Click += (_, __) => CancelEvent?.Invoke(this, EventArgs.Empty);
            btnAddImage.Click += (_, __) => AddImageEvent?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (_, __) => DeleteEvent?.Invoke(this, EventArgs.Empty);
            ipCategory.OnSelectedIndexChanged += (_, __) => ipCategory.ForeColor = Color.Black;
            ipType.OnSelectedIndexChanged += (_, __) => ipType.ForeColor = Color.Black;
            ipName.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipStock.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPrice.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
        }

        public event KeyPressEventHandler? ValidateEvent;
        public event EventHandler? CancelEvent;
        public event EventHandler? AddImageEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;

        private void SetControlText(Control? control, string? value)
        {
            if (control != null)
            {
                control.ForeColor = Color.Black;
                if (control is TextBoxCustom txt)
                {
                    txt.Texts = value!;
                }
                else if (control is ComboBoxCustom cmb)
                {
                    cmb.Texts = value!;
                }
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static ProductForm? instance;
        public static ProductForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductForm
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
