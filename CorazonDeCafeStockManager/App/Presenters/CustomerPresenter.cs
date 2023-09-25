using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.CustomerForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

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
            if (!ValidateData())
            {
                return;
            }

            User user = new()
            {
                Name = view.CustomerName!,
                Surname = view.CustomerSurname!,
                Email = view.CustomerEmail!,
                Dni = view.CustomerDni,
                Phone = view.CustomerPhone!,
                Status = view.CustomerStatus!.ToLower() == "activo" ? 1 : 0,
            };

            Address address = new()
            {
                Street = view.CustomerStreet!,
                Number = view.CustomerNumber,
                City = view.CustomerCity!,
                Province = view.CustomerProvince!,
                PostalCode = view.CustomerPostalCode,
            };

            Customer customer = new() { };

            if (view.CustomerId != null)
            {
                customer.Id = (int)view.CustomerId;
                await CustomerRepository.UpdateCustomer(customer, user, address);
            }
            else
            {
                await CustomerRepository.AddCustomer(customer);
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
                view.CustomerNumber != 0 ||
                view.CustomerPostalCode != 0 ||
                view.CustomerDni != 0)
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

            bool isDeleted = await CustomerRepository.DeleteCustomer((int)view.CustomerId!);
            if (isDeleted)
            {
                homePresenter.ShowCustomersView(this, EventArgs.Empty);
                view.Close();
            }
            else
            {
                view.ShowError("Error al eliminar el empleado, por favor intentelo nuevamente");
            }
        }

        private bool ValidateData()
        {
            bool isValid = true;
            string errorMessage = string.Empty;
            string CustomerName = view.CustomerName!;
            string CustomerSurname = view.CustomerSurname!;
            string CustomerEmail = view.CustomerEmail!;
            int CustomerDni = view.CustomerDni;
            string CustomerPhone = view.CustomerPhone!;
            string CustomerStreet = view.CustomerStreet!;
            int CustomerNumber = view.CustomerNumber;
            string CustomerCity = view.CustomerCity!;
            string CustomerProvince = view.CustomerProvince!;
            int CustomerPostalCode = view.CustomerPostalCode;

            if (string.IsNullOrWhiteSpace(CustomerName))
            {
                errorMessage = "Debe ingresar un nombre";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(CustomerSurname))
            {
                errorMessage = "Debe ingresar un apellido";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(CustomerEmail))
            {
                errorMessage = "Debe ingresar un email";
                isValid = false;
            }

            if (CustomerDni == 0 || CustomerDni.ToString().Length < 7 || CustomerDni.ToString().Length > 10)
            {
                errorMessage = "Debe ingresar un dni valido";
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(CustomerPhone) && (CustomerPhone.Length < 9 || CustomerPhone.Length > 11 || CustomerPhone.Contains(" ") || !long.TryParse(CustomerPhone, out long phone)))
            {
                errorMessage = "Debe ingresar un telefono valido";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(CustomerStreet))
            {
                errorMessage = "Debe ingresar una calle";
                isValid = false;
            }

            if (CustomerNumber == 0)
            {
                errorMessage = "Debe ingresar un numero";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(CustomerCity))
            {
                errorMessage = "Debe ingresar una ciudad";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(CustomerProvince))
            {
                errorMessage = "Debe ingresar una provincia";
                isValid = false;
            }

            if (CustomerPostalCode == 0)
            {
                errorMessage = "Debe ingresar un codigo postal";
                isValid = false;
            }

            if (!isValid)
            {
                view.ShowError(errorMessage);
            }

            return isValid;
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