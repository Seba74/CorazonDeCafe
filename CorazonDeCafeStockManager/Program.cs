namespace CorazonDeCafeStockManager
{
    internal static class Program
    {

        // Connection string to the database
        // => optionsBuilder.UseSqlServer("Server=SEBA;Database=CorazonDeCafe;Integrated Security=True;TrustServerCertificate=True;");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}