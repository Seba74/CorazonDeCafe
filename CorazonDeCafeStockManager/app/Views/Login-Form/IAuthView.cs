using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorazonDeCafeStockManager.App.Views.Login_Form
{
    public interface IAuthView
    {
        string Username { get; set; }
        string Password { get; set; }

        event EventHandler<Tuple<string, string>>? LoginEvent;

        void ShowError(string message);
        void Show();
        void Close();
    }
}
