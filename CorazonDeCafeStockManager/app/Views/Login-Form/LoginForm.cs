using System.Drawing.Text;
using CorazonDeCafeStockManager.App.Repository;
using CorazonDeCafeStockManager.App.Repository._Repository;

namespace CorazonDeCafeStockManager
{
    public partial class LoginForm : Form
    {

        private readonly IAuthRepository requestLogin;
        public LoginForm(IAuthRepository requestLogin)
        {
            this.requestLogin = requestLogin;
            InitializeComponent();
            LoadFonts loadFonts = new();

            lblTitle.Font = new Font(loadFonts.poppinsFont!.FontFamily, 16, FontStyle.Bold);

            ipUser.Font = loadFonts.poppinsLightFont!;
            ipPassword.Font = loadFonts.poppinsLightFont!;
            lblSubtitle.Font = loadFonts.poppinsLightFont;
            btnLogin.Font = loadFonts.poppinsLightFont;
            btnError.Font = loadFonts.poppinsLightFont;

            closeBtn.BackColor = Color.Transparent;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
        }
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = ipUser.Texts;
            string password = ipPassword.Texts;
            bool logged = await this.requestLogin.Login(user, password);
            if (logged)
            {
                // Home home = new();
                // home.Show();
                Products products = new();
                products.Show();
                this.Hide();
            }
            else
            {
                btnError.Visible = true;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}