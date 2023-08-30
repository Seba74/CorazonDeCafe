using System.Drawing.Text;
using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Views.Login_Form;

namespace CorazonDeCafeStockManager
{
    public partial class LoginForm : Form, IAuthView
    {
        public string Username
        {
            get { return ipUser.Texts; }
            set { ipUser.Texts = value; }
        }
        public string Password
        {
            get { return ipPassword.Texts; }
            set { ipPassword.Texts = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
            AssociateEvents();

            lblTitle.Font = new Font(FontsManager.PoppinsFont!.FontFamily, 16);
            ipUser.Font = new Font(FontsManager.PoppinsFont!.FontFamily, 12);
            ipPassword.Font = new Font(FontsManager.PoppinsFont!.FontFamily, 12);
            lblSubtitle.Font = new Font(FontsManager.PoppinsFont!.FontFamily, 12);
            lblError.Font = new Font(FontsManager.PoppinsFont!.FontFamily, 10);
            closeBtn.BackColor = Color.Transparent;

        }

        public event EventHandler<Tuple<string, string>>? LoginEvent;

        private void AssociateEvents()
        {
            btnLogin.Click += delegate (object? sender, EventArgs e)
            {
                LoginEvent?.Invoke(this, new Tuple<string, string>(Username, Password));
            };
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowError(string message)
        {
            inError.Visible = true;
            lblError.Visible = true;
            ipPassword.Texts = "";
            ipUser.BorderColor = Color.FromArgb(255, 145, 145);
            ipUser.BackColor = Color.FromArgb(255, 200, 200);
            ipPassword.BorderColor = Color.FromArgb(255, 145, 145);
            ipPassword.BackColor = Color.FromArgb(255, 200, 200);
        }
    }
}