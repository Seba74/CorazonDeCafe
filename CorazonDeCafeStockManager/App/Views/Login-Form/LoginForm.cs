using CorazonDeCafeStockManager.App.Views.LoginForm;
using CorazonDeCafeStockManager.Properties;

namespace CorazonDeCafeStockManager
{
    public partial class LoginForm : Form, IAuthView
    {
        public string Username { get { return ipUser.Texts; } set { ipUser.Texts = value; } }
        public string Password { get { return ipPassword.Texts; } set { ipPassword.Texts = value; } }
        public Control Loading { get { return loading; } }

        public LoginForm()
        {
            InitializeComponent();
            LoadLoading();
            AssociateEvents();
            UpdateButtonStyle();
            SetFonts();
        }
        public event EventHandler<Tuple<string, string>>? LoginEvent;
        private void AssociateEvents()
        {
            ipUser._TextChanged += OnInputChanged!;
            ipPassword._TextChanged += OnInputChanged!;
            closeBtn.Click += delegate { Application.Exit(); };
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
        private void SetFonts()
        {
            LoadFonts loadFonts = new();
            lblTitle.Font = new Font(loadFonts.poppinsFont!.FontFamily, 16);
            ipUser.Font = new Font(loadFonts.poppinsFont!.FontFamily, 12);
            ipPassword.Font = new Font(loadFonts.poppinsFont!.FontFamily, 12);
            lblSubtitle.Font = new Font(loadFonts.poppinsFont!.FontFamily, 12);
            lblError.Font = new Font(loadFonts.poppinsFont!.FontFamily, 10);
            closeBtn.BackColor = Color.Transparent;
        }
        private void UpdateButtonStyle()
        {
            if (btnLogin.Enabled)
            {
                btnLogin.BorderColor = Color.FromArgb(146, 90, 57);
                btnLogin.ForeColor = Color.FromArgb(146, 90, 57);
            }
            else
            {
                btnLogin.BorderColor = Color.Gray;
                btnLogin.TextColor = Color.FromArgb(255, 219, 197);
                btnLogin.ForeColor = Color.Black;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ActiveControl = lblTitle;
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
            loading.Image = Resources.loader;
            loading.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}