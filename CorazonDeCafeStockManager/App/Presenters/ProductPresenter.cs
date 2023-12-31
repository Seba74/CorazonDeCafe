﻿using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Validators;
using CorazonDeCafeStockManager.App.Views.ProductForm;
using CorazonDeCafeStockManager.Properties;
using CorazonDeCafeStockManager.utils.Custom.TextBox;
using FluentValidation.Results;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
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
            this.view.DeleteEvent += DeleteEvent!;
            this.view.SaveEvent += SaveEvent!;
            this.view.CancelEvent += CancelEvent!;

            types = LocalStorage.Types;
            categories = LocalStorage.Categories;

            if (product != null)
            {
                SetProductToView(product);
                view.BtnDelete!.Visible = true;
                view.BgImagen!.Image = Resources.bg;
            }
        }

        private void SetProductToView(Product product)
        {

            view.ProductName = product.Name;
            view.ProductActive = product.Active == 1 ? "Activo" : "Inactivo";
            view.ProductPrice = product.Price;
            view.ProductCategory = product.Category.Name;
            view.ProductType = product.Type.Name;
            view.ProductStock = product.Stock;
            view.ProductId = product.Id;
            view.Title = product.Name.ToUpper();
            imageName = product.Imagen;

            if (product.Imagen.IsNullOrEmpty())
            {
                product.Imagen = "default.png";
                view.ShowImage!.Image = Resources.imageNotFound;
            }
            else
            {
                string imagePath = Path.Combine("..", "..", "..", "products", product.Imagen);
                view.ShowImage!.Image = Image.FromFile(imagePath);
            }

            view.ProductImagen = product.Imagen;
            view.BgImagen!.Visible = true;
            view.BtnAddImage!.Text = $"Image: {view.ProductId}";

        }
        public void CloseView() => view.Close();
        private async void SaveEvent(object sender, EventArgs e)
        {
            ProductData productData = new()
            {
                Name = view.ProductName,
                Price = view.ProductPrice,
                Stock = view.ProductStock,
                Category = view.ProductCategory,
                Type = view.ProductType,
                Status = 1,
                Imagen = imageName
            };

            ProductValidator validator = new();
            ValidationResult result = validator.Validate(productData);

            if (!result.IsValid)
            {
                view.ShowError(result.Errors[0].ErrorMessage);
                return;
            }

            int categoryId = categories!.First(c => c.Name == view.ProductCategory).Id;
            int typeId = types!.First(t => t.Name == view.ProductType).Id;
            int active = view.ProductActive == "Activo" ? 1 : 0;

            productData.CategoryId = categoryId;
            productData.TypeId = typeId;
            productData.Active = active;

            try
            {
                if (view.ProductId != null)
                {
                    productData.Id = (int)view.ProductId;
                    bool isUpdated = await productRepository.UpdateProduct(productData);
                    if (filePath != null && fileSavePath != null && isUpdated)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Copy(filePath!, fileSavePath!, true);
                        GC.WaitForPendingFinalizers();
                    }
                }
                else
                {
                    await productRepository.AddProduct(productData);
                    File.Copy(filePath!, fileSavePath!, true);
                }
            }
            catch (LocalException ex)
            {
                view.ShowError(ex.Message);
                return;
            }
            catch (Exception)
            {
                view.ShowError("Error al guardar el producto, por favor intentelo nuevamente");
                return;
            }

            homePresenter.ShowProductsView(this, EventArgs.Empty);
            view.Close();
        }

        private async void CancelEvent(object sender, EventArgs e)
        {
            if (view.ProductId != null)
            {
                Product product = await productRepository.GetProductById((int)view.ProductId!);

                if (product != null &&
                   product.Name != view.ProductName ||
                   product?.Price != view.ProductPrice ||
                   product.Stock != view.ProductStock ||
                   product.Category.Name != view.ProductCategory ||
                   product.Type.Name != view.ProductType ||
                   product.Active != (view.ProductActive == "Activo" ? 1 : 0) ||
                   product.Imagen != view.ProductImagen ||
                   view.BtnAddImage!.Text != $"Image: {view.ProductId}")

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

        private async void DeleteEvent(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }
            try
            {
                bool isDeleted = await productRepository.DeleteProduct((int)view.ProductId!);
                homePresenter.ShowProductsView(this, EventArgs.Empty);
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void ValidateEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxCustom textBox = (TextBoxCustom)sender;

            if (e.KeyChar == '\b')
            {
                return;
            }

            if (!IsValidInput(e.KeyChar, textBox))
            {
                e.Handled = true;
            }
        }

        private bool IsValidInput(char inputChar, TextBoxCustom textBox)
        {
            return textBox.Name switch
            {
                "ipName" => char.IsLetterOrDigit(inputChar) || char.IsWhiteSpace(inputChar),
                "ipPrice" => char.IsDigit(inputChar) || IsDecimalSeparator(inputChar),
                "ipStock" => char.IsDigit(inputChar) && IsStockValid(textBox.Texts + inputChar),
                _ => true,
            };
        }

        private bool IsDecimalSeparator(char keyChar)
        {
            char decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            return keyChar == decimalSeparator || keyChar == '.';
        }

        private bool IsStockValid(string inputText)
        {
            if (!string.IsNullOrWhiteSpace(inputText) && int.TryParse(inputText, out int stock))
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
                if (view.ProductId != null)
                {
                    imageName = view.ProductImagen;
                }

                string fileSavePath = Path.Combine("..", "..", "..", "products", imageName!);
                string fileName = openFileDialog.SafeFileName;
                this.fileSavePath = fileSavePath;
                filePath = openFileDialog.FileName;

                view.BgImagen!.Image = Resources.bg;
                view.ShowImage!.Image = Image.FromFile(filePath);
                view.BtnAddImage!.Text = $"Image: {fileName}";
            }
        }
    }
}