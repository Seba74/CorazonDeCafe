namespace CorazonDeCafeStockManager.App.Common
{
    public static class loadFonts
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
