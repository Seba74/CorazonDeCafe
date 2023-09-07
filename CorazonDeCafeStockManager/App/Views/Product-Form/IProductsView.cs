namespace CorazonDeCafeStockManager.App.Views.Product_Form
{
    public interface IProductView
    {

        // Properties 
        string? Nombre { get; set; }
        string? Imagen { get; set; }
        float Precio { get; set; }
        string? Categoria { get; set; }
        string? Tipo { get; set; } 
        int? Stock { get; set; }
        string? Estado { get; set; }
        PictureBox? ShowImage { get; set; }
        PictureBox? BgImagen { get; set; }
        ButtonCustom? BtnAddImage { get; set; }
        
        // Events
        event EventHandler? CancelEvent;
        event EventHandler? AddImageEvent;
        event KeyPressEventHandler? ValidateEvent;
        event EventHandler? SaveEvent;
        
        // Methods
        void ShowError(string message);
        void Show();
        void Close();
    }
}
