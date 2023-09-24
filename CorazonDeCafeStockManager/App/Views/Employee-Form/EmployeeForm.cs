using CorazonDeCafeStockManager.App.Views.EmployeeForm;

namespace CorazonDeCafeStockManager
{
    public partial class EmployeeForm : Form, IEmployeeView
    {
        public int? EmployeeId { get; set; }

        public string? EmployeeName
        {
            get => ipName.Texts;
            set
            {
                ipName.ForeColor = Color.Black;
                ipName.Texts = value!;
                title.Text = value!;
            }
        }
        public string? EmployeeSurname
        {
            get => ipSurname.Texts;
            set
            {
                ipSurname.ForeColor = Color.Black;
                ipSurname.Texts = value!;
            }
        }

        public string? EmployeeEmail
        {
            get => ipEmail.Texts;
            set
            {
                ipEmail.ForeColor = Color.Black;
                ipEmail.Texts = value!;
            }
        }
        public string? EmployeeUsername
        {
            get => ipUser.Texts;
            set
            {
                ipUser.ForeColor = Color.Black;
                ipUser.Texts = value!;
            }
        }
        public string? EmployeeRole
        {
            get => ipRole.Texts;
            set
            {
                ipRole.ForeColor = Color.Black;
                ipRole.Texts = value!;
            }
        }
        public string? EmployeePassword
        {
            get => ipPass.Texts;
            set
            {
                ipPass.ForeColor = Color.Black;
                ipPass.Texts = value!;
            }
        }
        public string? EmployeePassword2
        {
            get => ipPass2.Texts;
            set
            {
                ipPass2.ForeColor = Color.Black;
                ipPass2.Texts = value!;
            }
        }
        public int EmployeeDni
        {
            get
            {
                if (int.TryParse(ipDni.Texts, out int dni))
                    return dni;
                return 0;
            }
            set
            {
                ipDni.ForeColor = Color.Black;
                ipDni.Texts = value.ToString();
            }
        }
        public string? EmployeePhone
        {
            get => ipPhone.Texts;
            set
            {
                ipPhone.ForeColor = Color.Black;
                ipPhone.Texts = value!;
            }
        }
        public string? Title { get => title.Text; set => title.Text = value; }
        public ButtonCustom? BtnDelete { get => btnDelete; set => btnDelete = value!; }

        public EmployeeForm()
        {
            InitializeComponent();
            AssociateEvents();

        }

        private void AssociateEvents()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            btnGoBack.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            ipRole.OnSelectedIndexChanged += delegate { ipRole.ForeColor = Color.Black; };
            ipName.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipSurname.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipUser.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipEmail.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPhone.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipDni.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPass.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
            ipPass2.KeyPress += (sender, e) => ValidateEvent?.Invoke(sender, e);
        }
        public event KeyPressEventHandler? ValidateEvent;
        public event EventHandler? CancelEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
