using System.Drawing;
using System.Drawing.Text;

namespace CorazonDeCafeStockManager
{
    public class LoadFonts
    {
        private readonly PrivateFontCollection privateFontCollection = new();
        public Font? poppinsFont;
        public Font? poppinsLightFont;

        public LoadFonts()
        {
            LoadAllFonts();
        }

        private void LoadAllFonts()
        {
            string font1 = Path.Combine(Application.StartupPath, "fonts", "poppins.ttf");
            font1 = font1.Replace("bin\\Debug\\net7.0-windows\\", "");

            string font2 = Path.Combine(Application.StartupPath, "fonts", "poppins-Light.ttf");
            font2 = font2.Replace("bin\\Debug\\net7.0-windows\\", "");

            privateFontCollection.AddFontFile(font1);
            privateFontCollection.AddFontFile(font2);

            poppinsFont = new Font(privateFontCollection.Families[0], 12f);
            poppinsLightFont = new Font(privateFontCollection.Families[1], 12f);
        }
    }   
}
