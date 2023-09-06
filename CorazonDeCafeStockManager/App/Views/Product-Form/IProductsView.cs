using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.Product_Form
{
    public interface IProductView
    {

        // Properties 
        string? Nombre { get; set; }
        string? Imagen { get; set; }
        float Precio { get; set; }
        string? CategoriaId { get; set; }
        string? TipoId { get; set; } 
        int? Stock { get; set; }
        string? Estado { get; set; }
        Size Size { get; set; }

        // Events
        event EventHandler? CancelEvent;
        event EventHandler? SaveEvent;

        // Methods
        void ShowError(string message);
        void Show();
        void Close();
    }
}
