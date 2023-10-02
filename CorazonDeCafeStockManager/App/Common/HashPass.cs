namespace CorazonDeCafeStockManager.App.Common{
    public static class HashPass{
        public static string HashPassword(string password){
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool ValidatePassword(string password, string correctHash){
            return BCrypt.Net.BCrypt.Verify(password, correctHash);
        }
    }
}