using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.Product_Form;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductPresenter
    {
        public static void CreatePresenter(IProductView view, IProductRepository productRepository)
        {
            ProductPresenter presenter = new(view, productRepository);
            presenter.view.Show();
        }

        private readonly IProductView view;
        private readonly IProductRepository productRepository;
        private readonly IEnumerable<Categoria>? categorias;

        public ProductPresenter(IProductView view, IProductRepository productRepository)
        {
            this.view = view;
            this.productRepository = productRepository;
            this.view.ValidateEvent += ValidateEvent!;
            this.view.AddImageEvent += AddImageEvent!;
            this.view.SaveEvent += SaveEvent!;
        }
        private void SaveEvent(object sender, EventArgs e)
        {
            if (!ValidateData()) {
                return;
            }

        }

        private bool ValidateData()
        {
            bool isValid = true;

            if ((string.IsNullOrWhiteSpace(view.BtnAddImage?.Text) || view.BtnAddImage.Text == "Seleccione una imagen") &&
                string.IsNullOrWhiteSpace(view.Nombre) &&
                view.Precio == 0 &&
                view.Stock < 0 &&
                view.Categoria == "Categoría" &&
                view.Tipo == "Tipo")
            {
                view.ShowError("Debe completar todos los campos");
                return isValid = false;
            }

            if (string.IsNullOrWhiteSpace(view.Nombre))
            {
                view.ShowError("Debe ingresar un nombre");
                return isValid = false;
            }

            if (view.Precio == 0)
            {
                view.ShowError("Debe ingresar un precio");
                return isValid = false;
            }

            if (view.Categoria == "Categoría")
            {
                view.ShowError("Debe ingresar una categoría");
                return isValid = false;
            }

            if (view.Tipo == "Tipo")
            {
                view.ShowError("Debe ingresar un tipo");
                return isValid = false;
            }

            if (view.Stock < 0)
            {
                view.ShowError("Debe ingresar un stock válido");
                return isValid = false;
            }

            if (string.IsNullOrWhiteSpace(view.BtnAddImage?.Text) || view.BtnAddImage.Text == "Seleccione una imagen")
            {
                view.ShowError("Debe seleccionar una imagen");
                return isValid = false;
            }

            return isValid;
        }

        private void ValidateEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxCustom textBox = (TextBoxCustom)sender;

            if (!char.IsControl(e.KeyChar) && !IsValidInput(e.KeyChar, textBox))
            {
                e.Handled = true;
            }
        }

        private bool IsValidInput(char inputChar, TextBoxCustom textBox)
        {
            switch (textBox.Name)
            {
                case "ipName":
                    return char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar);

                case "ipPrice":
                    return char.IsDigit(inputChar) || IsDecimalSeparator(inputChar);

                case "ipStock":
                    return char.IsDigit(inputChar) && IsStockValid(textBox.Text + inputChar);

                default:
                    return true;
            }
        }

        private bool IsDecimalSeparator(char keyChar)
        {
            char decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            return keyChar == decimalSeparator || keyChar == '.';
        }

        private bool IsStockValid(string inputText)
        {
            if (int.TryParse(inputText, out int stock))
            {
                return stock >= 0;
            }
            return false;
        }

        private void AddImageEvent(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Image files (*.png) | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Multiselect = false,
                RestoreDirectory = true,
                Title = "Seleccione una imagen"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get the path of the selected file
                string filePath = openFileDialog.FileName;
                // get the file name
                string fileName = openFileDialog.SafeFileName;
                // get the file extension
                string fileExtension = openFileDialog.SafeFileName.Split('.').Last();
                // get the file size
                long fileSize = new System.IO.FileInfo(filePath).Length;
                // get the file bytes
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                // get the file base64 string
                string fileBase64 = Convert.ToBase64String(fileBytes);
                // get the file base64 string with the data url format
                string fileBase64DataUrl = $"data:image/{fileExtension};base64,{fileBase64}";
                // set the image
                view.BgImagen!.Visible = true;
                view.ShowImage!.Image = Image.FromFile(filePath);
                view.BtnAddImage!.Text = $"Image: {fileName}";
            }

        }
    }
}
