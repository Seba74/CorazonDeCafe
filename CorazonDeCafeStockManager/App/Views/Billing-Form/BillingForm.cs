using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Views.BillingForm;
using CorazonDeCafeStockManager.Properties;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager
{
    public partial class BillingForm : Form, IBillingView
    {
        private readonly LoadFonts loadFonts;
        public string? SearchCustomer { get => ipSearch.Texts; set => ipSearch.Texts = value!; }
        public string? CustomerName { get => ipName.Texts; set => ipName.Texts = value!; }
        public string? CustomerAddress { get => ipAddress.Texts; set => ipAddress.Texts = value!; }
        public string? CustomerContact { get => ipPhone.Texts; set => ipPhone.Texts = value!; }
        public string? OrderSubtotal { get => orderSubtotal.Text; set => orderSubtotal.Text = value!; }
        public string? OrderIva { get => orderIVA.Text; set => orderIVA.Text = value!; }
        public string? OrderTotal { get => orderTotal.Text; set => orderTotal.Text = value!; }
        public ComboBoxCustom? BillingType { get => ipOrderType; set => ipOrderType = value!; }
        public ComboBoxCustom? PaymentMethod { get => ipPaymentMethod; set => ipPaymentMethod = value!; }
        public TextBoxCustom? CustomerCUIT { get => ipCUIT; set => ipCUIT = value!; }
        public Panel PanelProducts { get => productsView; set => productsView = value!; }
        public ButtonCustom BtnCustomer { get => btnCustomer; set => btnCustomer = value!; }
        public ButtonCustom BtnSaveOrder { get => btnSave; set => btnSave = value!; }
        public ButtonCustom BtnCancelOrder { get => btnCancel; set => btnCancel = value!; }
        public DataGridView Cart { get => cartGrid; set => cartGrid = value!; }
        public IEnumerable<OrderProductData>? CartList { get; set; }

        public BillingForm()
        {
            InitializeComponent();
            InitializeEvents();

            loadFonts = new LoadFonts();
            ChangeDataGridViewFont(cartGrid);
        }
        private void InitializeEvents()
        {
            btnCustomer.Click += (s, e) => BtnCustomerEvent?.Invoke(s, e);
            btnSave.Click += (s, e) => SaveOrderEvent?.Invoke(s, e);
            btnCancel.Click += (s, e) => CancelOrderEvent?.Invoke(s, e);
            ipSearch._TextChanged += (s, e) => LookForCustomer?.Invoke(s, e);
            ipOrderType.OnSelectedIndexChanged += (s, e) => OrderTypeEvent?.Invoke(s, e);
            cartGrid.CellEndEdit += (s, e) => AmountChangedEvent?.Invoke(s, e);
            cartGrid.CellContentClick += (s, e) => RemoveProductEvent?.Invoke(s, e);
            cartGrid.EditingControlShowing += (s, e) => ValidateAmountEvent?.Invoke(s, e);
            ipSearch.KeyPress += (s, e) => ValidateEvent?.Invoke(s, e);
            ipCUIT.KeyPress += (s, e) => ValidateEvent?.Invoke(s, e);
        }

        public void LoadProducts()
        {
            if (cartGrid.InvokeRequired)
            {
                cartGrid.Invoke(new MethodInvoker(() => LoadProductsInternal()));
            }
            else LoadProductsInternal();
        }

        private void LoadProductsInternal()
        {
            cartGrid.Rows.Clear();
            cartGrid.Refresh();

            foreach (OrderProductData order in CartList!)
            {
                cartGrid.Rows.Add(order.ProductId, order.Product!.Name, order.Price, order.Amount);
            }
        }
        public event EventHandler? BtnCustomerEvent;
        public event EventHandler? LookForCustomer;
        public event EventHandler? OrderTypeEvent;
        public event EventHandler? SaveOrderEvent;
        public event EventHandler? CancelOrderEvent;
        public event KeyPressEventHandler? ValidateEvent;
        public event DataGridViewCellEventHandler? AmountChangedEvent;
        public event DataGridViewCellEventHandler? RemoveProductEvent;
        public event EventHandler<DataGridViewEditingControlShowingEventArgs>? ValidateAmountEvent;

        private void ChangeDataGridViewFont(DataGridView dataGridView)
        {
            Color colorFondoEncabezado = Color.FromArgb(146, 90, 57);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = colorFondoEncabezado;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.DefaultCellStyle.Font = loadFonts.poppinsFont;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = loadFonts.poppinsFont;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static BillingForm? instance;
        public static BillingForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BillingForm
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
