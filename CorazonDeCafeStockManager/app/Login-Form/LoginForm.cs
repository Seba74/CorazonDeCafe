using System.Drawing.Text;
namespace CorazonDeCafeStockManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
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

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
        }

        private void IpUser_TextChanged(object sender, EventArgs e)
        {

        }


        private void IpPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = ipUser.Texts;
            string password = ipPassword.Texts;
            RequestLogin requestLogin = new();
            if (requestLogin.Login(user, password))
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

        private void cdcTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnError_Click(object sender, EventArgs e)
        {

        }
    }
}