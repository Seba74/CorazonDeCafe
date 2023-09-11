using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.Product_Form;
using CorazonDeCafeStockManager.utils.Custom.TextBox;
using FluentValidation;
using Type = CorazonDeCafeStockManager.App.Models.Type;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class ProductPresenter
    {
        private readonly HomePresenter homePresenter;
        private readonly IProductView view;
        private readonly IProductRepository productRepository;
        private readonly IEnumerable<Category>? categories;
        private readonly IEnumerable<Type>? types;
        private string? imageName;
        private string? filePath;
        private string? fileSavePath;

        public ProductPresenter(IProductView view, IProductRepository productRepository, Product product, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.productRepository = productRepository;
            this.view.ValidateEvent += ValidateEvent!;
            this.view.AddImageEvent += AddImageEvent!;
            this.view.SaveEvent += SaveEvent!;
            this.view.CancelEvent += CancelEvent!;

            types = LocalStorage.Types;
            categories = LocalStorage.Categories;

            if (product != null) {
                SetProductToView(product);
            }
        }

        private void SetProductToView(Product product)
        {
            view.ProductName = product.Name;
            view.ProductCategory = product.Category.Name;
            view.ProductType = product.Type.Name;
            view.ProductPrice = product.Price;
            view.ProductStock = product.Stock;
            view.ProductImagen = product.Imagen;
            view.ProductActive = product.Active == 1 ? "Activo" : "Inactivo";
            view.ProductId = product.Id;
            imageName = product.Imagen;

            view.Title = product.Name;
            
            string path = Path.Combine("..", "..", "..", "products", view.ProductImagen);
            view.ShowImage!.Image = Image.FromFile(path);
            view.BgImagen!.Visible = true;
            view.BtnAddImage!.Text = $"Image: {view.ProductId}";

        }

        public void ShowView()
        {
            view.Show();
        }

        public void CloseView()
        {
            view.Close();
        }
        private async void SaveEvent(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            int categoryId = categories!.First(c => c.Name == view.ProductCategory).Id;
            int typeId = types!.First(t => t.Name == view.ProductType).Id;
            int active = view.ProductActive == "Activo" ? 1 : 0;

            Product productToUpdate = new()
            {
                Name = view.ProductName!,
                Price = view.ProductPrice,
                Stock = view.ProductStock,
                CategoryId = categoryId,
                TypeId = typeId,
                Active = active,
                Status = 1,
                Imagen = imageName!
            };

            if(view.ProductId != null)
            {
                productToUpdate.Id = (int)view.ProductId;
                bool isUpdated = await productRepository.UpdateProduct(productToUpdate);
                if(filePath != null && fileSavePath != null)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Copy(filePath!, fileSavePath!, true);
                }
            }
            else
            {
                await productRepository.AddProduct(productToUpdate);
                File.Copy(filePath!, fileSavePath!, true);
            }

            homePresenter.ShowProductsView(this, EventArgs.Empty);
            view.Close();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            if(view.ProductId != null)
            {
                int id = (int)view.ProductId;
                Product product = productRepository.GetProductById(id);
                
                if(product.Name != view.ProductName ||
                   product.Price != view.ProductPrice ||
                   product.Stock != view.ProductStock ||
                   product.Category.Name != view.ProductCategory ||
                   product.Type.Name != view.ProductType ||
                   product.Active != (view.ProductActive == "Activo" ? 1 : 0) ||
                   product.Imagen != view.ProductImagen)
                {
                    DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar, ¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                homePresenter.ShowProductsView(this, EventArgs.Empty);
                view.Close();
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.ProductName) ||
                view.ProductPrice != 0 ||
                view.ProductCategory != "Categoría" ||
                view.ProductType != "Tipo" ||
                view.ProductStock != -1 ||
                view.BtnAddImage!.Text != "Seleccione una imagen")
            {
                DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar, ¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            homePresenter.ShowProductsView(this, EventArgs.Empty);
            view.Close();
        }

        private bool ValidateData()
        {
            bool isValid = true;

            if ((string.IsNullOrWhiteSpace(view.BtnAddImage?.Text) || view.BtnAddImage.Text == "Seleccione una imagen") &&
                string.IsNullOrWhiteSpace(view.ProductName) &&
                view.ProductPrice == 0 &&
                view.ProductStock < 0 &&
                view.ProductCategory == "Categoría" &&
                view.ProductType == "Tipo")
            {
                view.ShowError("Debe completar todos los campos");
                return isValid = false;
            }

            if (string.IsNullOrWhiteSpace(view.ProductName))
            {
                view.ShowError("Debe ingresar un nombre");
                return isValid = false;
            }

            if (view.ProductPrice == 0)
            {
                view.ShowError("Debe ingresar un precio");
                return isValid = false;
            }

            if (view.ProductCategory == "Categoría")
            {
                view.ShowError("Debe ingresar una categoría");
                return isValid = false;
            }

            if (view.ProductType == "Tipo")
            {
                view.ShowError("Debe ingresar un tipo");
                return isValid = false;
            }

            if (view.ProductStock < 0)
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
                    return char.IsLetterOrDigit(inputChar) || char.IsWhiteSpace(inputChar);

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
                imageName = Guid.NewGuid().ToString() + ".png";
                if(view.ProductId != null)
                {
                    imageName = view.ProductImagen;
                }

                string fileSavePath = Path.Combine("..", "..", "..", "products", imageName!);
                string fileName = openFileDialog.SafeFileName;
                this.fileSavePath = fileSavePath;
                this.filePath = openFileDialog.FileName;


                view.BgImagen!.Visible = true;
                view.ShowImage!.Image = Image.FromFile(filePath);
                view.BtnAddImage!.Text = $"Image: {fileName}";
            }
        }
    }
}
