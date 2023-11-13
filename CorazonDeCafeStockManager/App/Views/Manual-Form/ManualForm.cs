using CorazonDeCafeStockManager.Properties;

namespace CorazonDeCafeStockManager.App.Views.ManualForm
{
    public partial class ManualForm : Form
    {
        private readonly LoadFonts loadFonts;
        public ManualForm()
        {
            InitializeComponent();
            loadFonts = new LoadFonts();

            string pdfPath = Path.Combine(Application.StartupPath, "..", "..", "..", "Resources", "manual_usuario.pdf");

            WebBrowser webBrowser = new WebBrowser
            {
                Dock = DockStyle.Fill,
                Url = new Uri(pdfPath)
            };

            pdfPanel.Controls.Add(webBrowser);
        }


        private static ManualForm? instance;
        public static ManualForm GetInstance(Control controlParent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ManualForm
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