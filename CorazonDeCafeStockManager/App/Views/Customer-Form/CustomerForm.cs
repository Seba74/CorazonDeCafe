using CorazonDeCafeStockManager.App.Views.CustomerForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager
{
    public partial class CustomerForm : Form, ICustomerView
    {
        public int? CustomerId { get; set; }
        public string? CustomerName { get => ipName.Texts; set => SetControlText(ipName, value); }
        public string? CustomerSurname { get => ipSurname.Texts; set => SetControlText(ipSurname, value); }
        public string? CustomerEmail { get => ipEmail.Texts; set => SetControlText(ipEmail, value); }
        public string? CustomerStreet { get => ipStreet.Texts; set => SetControlText(ipStreet, value); }
        public int CustomerNumber { get { if (int.TryParse(ipNumber.Texts, out int number)) return number; return 0; } set => SetControlText(ipNumber, value.ToString()); }
        public string? CustomerPostalCode { get => ipPostalCode.Texts; set => SetControlText(ipPostalCode, value); }
        public string? CustomerCity { get => ipCity.Texts; set => SetControlText(ipCity, value); }
        public string? CustomerProvince { get => ipProvince.Texts; set => SetControlText(ipProvince, value); }
        public string? CustomerStatus { get => ipStatus.Texts; set => SetControlText(ipStatus, value); }
        public string? CustomerDni { get => ipDni.Texts; set => SetControlText(ipDni, value); } 
        public string? CustomerPhone { get => ipPhone.Texts; set => SetControlText(ipPhone, value); }
        public string? Title { get => title.Text; set => title.Text = value; }
        public ButtonCustom? BtnDelete { get => btnDelete; set => btnDelete = value!; }

        public CustomerForm()
        {
            InitializeComponent();
            AssociateEvents();

        }
        private void AssociateEvents()
        {
            btnSave.Click += (_, __) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (_, __) => CancelEvent?.Invoke(this, EventArgs.Empty);
            btnGoBack.Click += (_, __) => CancelEvent?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (_, __) => DeleteEvent?.Invoke(this, EventArgs.Empty);

            ipName.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipSurname.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipEmail.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPhone.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipDni.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipStreet.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipNumber.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPostalCode.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipCity.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipProvince.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);

            ipStatus.OnSelectedIndexChanged += (_, __) => ipStatus.ForeColor = Color.Black;
        }
        public event KeyPressEventHandler? ValidateEvent;
        public event EventHandler? CancelEvent;
        public event EventHandler? DeleteEvent;
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
        private static CustomerForm? instance;
        public static CustomerForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomerForm
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
