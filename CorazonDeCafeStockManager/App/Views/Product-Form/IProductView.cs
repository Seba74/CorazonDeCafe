namespace CorazonDeCafeStockManager.App.Views.Product_Form
{
    public interface IProductView
    {

        // Properties 
        int? ProductId { get; set; }
        string? ProductName { get; set; }
        string? ProductImagen { get; set; }
        double ProductPrice { get; set; }
        string? ProductCategory { get; set; }
        string? ProductType { get; set; } 
        int ProductStock { get; set; }
        string? ProductActive { get; set; }

        string? Title { get; set; }
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
