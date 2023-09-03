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

        public Control Loading { get { return this.loading; } }

        public LoginForm()
        {
            InitializeComponent();
            LoadLoading();
            AssociateEvents();
            UpdateButtonStyle();

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
            ipUser._TextChanged += OnInputChanged!;
            ipPassword._TextChanged += OnInputChanged!;
            btnLogin.Click += delegate (object? sender, EventArgs e)
            {
                HideInputs(false);
                LoginEvent?.Invoke(this, new Tuple<string, string>(Username, Password));
            };
        }

        private void OnInputChanged(object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrWhiteSpace(ipUser.Texts);
            bool isPasswordEmpty = string.IsNullOrWhiteSpace(ipPassword.Texts);
            bool isPasswordShort = ipPassword.Texts.Length < 4;

            btnLogin.Enabled = !isUsernameEmpty && !isPasswordEmpty && !isPasswordShort;
            UpdateButtonStyle();
        }

        private void UpdateButtonStyle()
        {
            if (btnLogin.Enabled)
            {
                // Botón habilitado: establecer un color de fondo diferente
                btnLogin.BorderColor = Color.FromArgb(146, 90, 57);
                btnLogin.ForeColor = Color.FromArgb(146, 90, 57);
            }
            else
            {
                // Botón deshabilitado: establecer otro color de fondo
                btnLogin.BorderColor = Color.Gray;
                btnLogin.TextColor = Color.FromArgb(255, 219, 197);
                btnLogin.ForeColor = Color.Black;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HideInputs(bool visible)
        {
            ipUser.Visible = visible;
            ipPassword.Visible = visible;
            btnLogin.Visible = visible;
        }

        public void ShowError(string message)
        {
            HideInputs(true);
            inError.Visible = true;
            lblError.Visible = true;
            ipPassword.Texts = "";
            ipUser.BorderColor = Color.FromArgb(255, 145, 145);
            ipUser.BackColor = Color.FromArgb(255, 200, 200);
            ipPassword.BorderColor = Color.FromArgb(255, 145, 145);
            ipPassword.BackColor = Color.FromArgb(255, 200, 200);

            loading.Visible = false;
        }

        private void LoadLoading()
        {
            loading.Visible = false;
            loading.BackColor = Color.Transparent;
            string loaderPath = Path.Combine(Application.StartupPath, "utils/Assets", "loader.gif");
            loaderPath = loaderPath.Replace("bin\\Debug\\net7.0-windows\\", "");
            loading.Image = Image.FromFile(loaderPath);
            loading.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}