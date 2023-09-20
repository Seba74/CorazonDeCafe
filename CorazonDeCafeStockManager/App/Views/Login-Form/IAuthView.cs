namespace CorazonDeCafeStockManager.App.Views.LoginForm
{
    public interface IAuthView
    {
        string Username { get; set; }
        string Password { get; set; }
        Control Loading { get; }

        event EventHandler<Tuple<string, string>>? LoginEvent;
        void ShowError(string message);
        void Show();
        void Close();
    }
}
