using System.Drawing.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CorazonDeCafeStockManager
{
    public partial class LoginForm : Form
    {

        // Global Variables
        private readonly PrivateFontCollection privateFontCollection = new();

        public LoginForm()
        {
            InitializeComponent();
            string path = Path.Combine(Application.StartupPath, "fonts", "poppins.ttf");
            string pathLight = Path.Combine(Application.StartupPath, "fonts", "poppins-Light.ttf");
            path = path.Replace("bin\\Debug\\net7.0-windows\\", "");
            pathLight = pathLight.Replace("bin\\Debug\\net7.0-windows\\", "");

            privateFontCollection.AddFontFile(path);
            privateFontCollection.AddFontFile(pathLight);

            ApplyFont(lblTitle, 16, FontStyle.Bold);
            ApplyFont(lblSubtitle, 12, FontStyle.Regular);
            ApplyFont(ipUser, 11, FontStyle.Regular);
            ApplyFont(ipPassword, 11, FontStyle.Regular);
            ApplyFont(btnLogin, 11, FontStyle.Regular);
            ApplyFontLight(btnError, 10, FontStyle.Regular);

            closeBtn.BackColor = Color.Transparent;

        }

        private void ApplyFont(Control control, float fontSize, FontStyle fontStyle)
        {
            FontFamily fontFamily = privateFontCollection.Families[0];
            Font font = new(fontFamily, fontSize, fontStyle);
            control.Font = font;
        }

        private void ApplyFontLight(Control control, float fontSize, FontStyle fontStyle)
        {
            FontFamily fontFamily = privateFontCollection.Families[1];
            Font font = new(fontFamily, fontSize, fontStyle);
            control.Font = font;
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
            string user = ipUser.Text;
            string password = ipPassword.Text;
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