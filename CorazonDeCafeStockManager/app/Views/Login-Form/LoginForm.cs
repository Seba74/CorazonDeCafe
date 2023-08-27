using System.Drawing.Text;
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
            LoadFonts loadFonts = new();

            lblTitle.Font = new Font(loadFonts.poppinsFont!.FontFamily, 16, FontStyle.Bold);

            ipUser.Font = loadFonts.poppinsLightFont!;
            ipPassword.Font = loadFonts.poppinsLightFont!;
            lblSubtitle.Font = loadFonts.poppinsLightFont;
            btnLogin.Font = loadFonts.poppinsLightFont;
            btnError.Font = loadFonts.poppinsLightFont;

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
            btnError.Visible = true;
        }
    }
}