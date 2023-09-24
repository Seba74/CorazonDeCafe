using CorazonDeCafeStockManager.App.Views.EmployeeForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager
{
    public partial class EmployeeForm : Form, IEmployeeView
    {
        public int? EmployeeId { get; set; }
        public string? EmployeeName { get => ipName.Texts; set => SetControlText(ipName, value); }
        public string? EmployeeSurname { get => ipSurname.Texts; set => SetControlText(ipSurname, value); }
        public string? EmployeeEmail { get => ipEmail.Texts; set => SetControlText(ipEmail, value); }
        public string? EmployeeUsername { get => ipUser.Texts; set => SetControlText(ipUser, value); }
        public string? EmployeeRole { get => ipRole.Texts; set => SetControlText(ipRole, value); }
        public string? EmployeeStatus { get => ipStatus.Texts; set => SetControlText(ipStatus, value); }
        public int EmployeeDni { get { if (int.TryParse(ipDni.Texts, out int dni)) return dni; return 0; } set => SetControlText(ipDni, value.ToString()); }
        public string? EmployeePhone { get => ipPhone.Texts; set => SetControlText(ipPhone, value); }
        public string? Title { get => title.Text; set => title.Text = value; }
        public ButtonCustom? BtnDelete { get => btnDelete; set => btnDelete = value!; }

        public EmployeeForm()
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
            ipUser.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipEmail.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPhone.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipDni.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            
            ipRole.OnSelectedIndexChanged += (_, __) => ipRole.ForeColor = Color.Black;
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
        private static EmployeeForm? instance;
        public static EmployeeForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EmployeeForm
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
