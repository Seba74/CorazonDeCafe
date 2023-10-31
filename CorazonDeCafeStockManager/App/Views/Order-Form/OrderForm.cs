using CorazonDeCafeStockManager.App.Views.OrderForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager
{
    public partial class OrderForm : Form, IOrderView
    {
        public int? OrderId { get; set; }
        public string? OrderCustomerName { get => ipCustomerName.Texts; set => SetControlText(ipCustomerName, value); }
        public string? OrderCustomerSurname { get => ipCustomerSurname.Texts; set => SetControlText(ipCustomerSurname, value); }
        public string? OrderEmployeeName { get => ipEmployeeName.Texts; set => SetControlText(ipEmployeeName, value); }
        public string? OrderCustomerDNI { get => ipCustomerDni.Texts; set => SetControlText(ipCustomerDni, value); }
        public string? OrderBillingType { get => ipBillingType.Texts; set => SetControlText(ipBillingType, value); }
        public string? OrderPaymentMethod { get => ipPaymentMethod.Texts; set => SetControlText(ipPaymentMethod, value); }
        public string? OrderTotal { get => ipTotalPrice.Texts; set => SetControlText(ipTotalPrice, value); }
        public ComboBoxCustom? OrderStatus { get => ipStatus; set => SetControlText(ipStatus, value!.Texts); }
        public string? Title { get => title.Text; set => title.Text = value; }

        public OrderForm()
        {
            InitializeComponent();
            AssociateEvents();

        }
        private void AssociateEvents()
        {
            btnSave.Click += (_, __) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (_, __) => CancelEvent?.Invoke(this, EventArgs.Empty);
            btnGoBack.Click += (_, __) => CancelEvent?.Invoke(this, EventArgs.Empty);

            ipStatus.OnSelectedIndexChanged += (_, __) => ipStatus.ForeColor = Color.Black;
        }
        public event EventHandler? CancelEvent;
        public event EventHandler? SaveEvent;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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
        private static OrderForm? instance;
        public static OrderForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new OrderForm
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
