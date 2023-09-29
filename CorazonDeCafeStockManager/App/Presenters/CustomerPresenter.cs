using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Validators;
using CorazonDeCafeStockManager.App.Views.CustomerForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;
using FluentValidation.Results;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class CustomerPresenter
    {
        private readonly HomePresenter homePresenter;
        private readonly ICustomerView view;
        private readonly ICustomerRepository CustomerRepository;

        public CustomerPresenter(ICustomerView view, ICustomerRepository CustomerRepository, Customer Customer, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.CustomerRepository = CustomerRepository;
            this.view.ValidateEvent += ValidateEvent!;
            this.view.DeleteEvent += DeleteEvent!;
            this.view.SaveEvent += SaveEvent!;
            this.view.CancelEvent += CancelEvent!;

            if (Customer != null)
            {
                SetCustomerToView(Customer);
                view.BtnDelete!.Visible = true;
            }
        }

        private void SetCustomerToView(Customer Customer)
        {
            view.CustomerId = Customer.Id;
            view.CustomerName = Customer.User.Name;
            view.CustomerSurname = Customer.User.Surname;
            view.CustomerEmail = Customer.User.Email;
            view.CustomerDni = Customer.User.Dni;
            view.CustomerPhone = Customer.User.Phone;
            view.CustomerStatus = Customer.User.Status == 1 ? "activo" : "inactivo";
            view.Title = (Customer.User.Name + " " + Customer.User.Surname).ToUpper();

            if (Customer.User.Address != null)
            {
                view.CustomerStreet = Customer.User.Address.Street;
                view.CustomerNumber = Customer.User.Address.Number;
                view.CustomerCity = Customer.User.Address.City;
                view.CustomerProvince = Customer.User.Address.Province;
                view.CustomerPostalCode = Customer.User.Address.PostalCode;
            }
        }
        public void CloseView()
        {
            view.Close();
        }
        private async void SaveEvent(object sender, EventArgs e)
        {

            CustomerData customerData = new()
            {
                Name = view.CustomerName!,
                Surname = view.CustomerSurname!,
                Email = view.CustomerEmail!,
                Dni = view.CustomerDni,
                Phone = view.CustomerPhone!,
                Street = view.CustomerStreet!,
                Number = view.CustomerNumber,
                Status = view.CustomerStatus == "activo" ? 1 : 0,
                City = view.CustomerCity!,
                Province = view.CustomerProvince!,
                PostalCode = view.CustomerPostalCode,
            };

            CustomerValidator validator = new();
            ValidationResult result = validator.Validate(customerData);

            if (!result.IsValid)
            {
                view.ShowError(result.Errors[0].ErrorMessage);
                return;
            }

            try
            {
                if (view.CustomerId != null)
                {
                    customerData.Id = (int)view.CustomerId;
                    await CustomerRepository.UpdateCustomer(customerData);
                }
                else
                {
                    await CustomerRepository.AddCustomer(customerData);
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
                return;
            }

            homePresenter.ShowCustomersView(this, EventArgs.Empty);
            view.Close();
        }

        private async void CancelEvent(object sender, EventArgs e)
        {
            if (view.CustomerId != null)
            {
                Customer Customer = await CustomerRepository.GetCustomerById((int)view.CustomerId!);

                if (Customer != null && (Customer.User.Name != view.CustomerName ||
                    Customer.User.Surname != view.CustomerSurname ||
                    Customer.User.Email != view.CustomerEmail ||
                    Customer.User.Dni != view.CustomerDni ||
                    (!string.IsNullOrEmpty(view.CustomerPhone) && Customer.User.Phone != view.CustomerPhone) ||
                    (Customer.User.Status == 1 ? "activo" : "inactivo") != view.CustomerStatus ||
                    Customer.User.Address!.Street != view.CustomerStreet ||
                    Customer.User.Address.Number != view.CustomerNumber ||
                    Customer.User.Address.City != view.CustomerCity ||
                    Customer.User.Address.Province != view.CustomerProvince ||
                    Customer.User.Address.PostalCode != view.CustomerPostalCode
                    ))
                {
                    DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar, ¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                homePresenter.ShowCustomersView(this, EventArgs.Empty);
                view.Close();
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.CustomerName) ||
                !string.IsNullOrWhiteSpace(view.CustomerSurname) ||
                !string.IsNullOrWhiteSpace(view.CustomerEmail) ||
                !string.IsNullOrWhiteSpace(view.CustomerPhone) ||
                !string.IsNullOrWhiteSpace(view.CustomerStreet) ||
                !string.IsNullOrWhiteSpace(view.CustomerCity) ||
                !string.IsNullOrWhiteSpace(view.CustomerProvince) ||
                !string.IsNullOrWhiteSpace(view.CustomerPostalCode) ||
                !string.IsNullOrWhiteSpace(view.CustomerDni) ||
                view.CustomerNumber != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar, ¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            homePresenter.ShowCustomersView(this, EventArgs.Empty);
            view.Close();
        }

        private async void DeleteEvent(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                bool isDeleted = await CustomerRepository.DeleteCustomer((int)view.CustomerId!);
                homePresenter.ShowCustomersView(this, EventArgs.Empty);
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
                return;
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
                "ipName" => char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar),
                "ipSurname" => char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar),
                "ipStreet" => char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar),
                "ipNumber" => char.IsDigit(inputChar) && IsIntValid(textBox.Texts + inputChar),
                "ipCity" => char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar),
                "ipProvince" => char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar),
                "ipPhone" => char.IsDigit(inputChar) && IsIntValid(textBox.Texts + inputChar),
                "ipPostalCode" => char.IsDigit(inputChar) && IsIntValid(textBox.Texts + inputChar),
                "ipDni" => char.IsDigit(inputChar) && IsIntValid(textBox.Texts + inputChar),
                _ => true,
            };
        }

        private bool IsIntValid(string inputText)
        {
            if (!string.IsNullOrWhiteSpace(inputText) && long.TryParse(inputText, out long number))
            {
                return number >= 0;
            }
            return false;
        }
    }
}