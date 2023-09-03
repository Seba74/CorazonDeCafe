using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorazonDeCafeStockManager.App.Common
{
    public static class FontsManager
    {
        public static Font? PoppinsFont { get; set; }
        public static Font? PoppinsLightFont { get; set; }
        public static void Init()
        {
            LoadFonts loadFonts = new();
            PoppinsFont = loadFonts.poppinsFont;
            PoppinsLightFont = loadFonts.poppinsLightFont;
        }
    }
}
