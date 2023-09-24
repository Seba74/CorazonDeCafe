using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.EmployeeForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class EmployeePresenter
    {
        private readonly HomePresenter homePresenter;
        private readonly IEmployeeView view;
        private readonly IEmployeeRepository EmployeeRepository;

        public EmployeePresenter(IEmployeeView view, IEmployeeRepository EmployeeRepository, Employee Employee, HomePresenter homePresenter)
        {
            this.view = view;
            this.homePresenter = homePresenter;
            this.EmployeeRepository = EmployeeRepository;
            this.view.ValidateEvent += ValidateEvent!;
            this.view.DeleteEvent += DeleteEvent!;
            this.view.SaveEvent += SaveEvent!;
            this.view.CancelEvent += CancelEvent!;

            if (Employee != null)
            {
                SetEmployeeToView(Employee);
                view.BtnDelete!.Visible = true;
            }
        }

        private void SetEmployeeToView(Employee Employee)
        {
            view.EmployeeId = Employee.Id;
            view.EmployeeName = Employee.User.Name;
            view.EmployeeSurname = Employee.User.Surname;
            view.EmployeeEmail = Employee.User.Email;
            view.EmployeeUsername = Employee.Username;
            view.EmployeeRole = Employee.Role.Name;
            view.EmployeeDni = Employee.User.Dni;
            view.EmployeePhone = Employee.User.Phone;
            view.Title = Employee.User.Name + " " + Employee.User.Surname;
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

            // create a new user
            User user = new()
            {
                Name = view.EmployeeName!,
                Surname = view.EmployeeSurname!,
                Email = view.EmployeeEmail!,
                Dni = view.EmployeeDni,
                Phone = view.EmployeePhone!,
                Status = 1,
            };

            Role role = await EmployeeRepository.GetRoleByName(view.EmployeeRole!);
            // create a new Employee
            Employee employee = new()
            {
                Username = view.EmployeeUsername!,
                RoleId = role.Id,
            };

            if (view.EmployeeId != null)
            {
                employee.Id = (int)view.EmployeeId;
                await EmployeeRepository.UpdateEmployee(employee, user, null!);
            }
            else
            {
                await EmployeeRepository.UpdateEmployee(employee, user, null!);
            }

            homePresenter.ShowEmployeesView(this, EventArgs.Empty);
            view.Close();
        }

        private async void CancelEvent(object sender, EventArgs e)
        {
            if (view.EmployeeId != null)
            {
                Employee Employee = await EmployeeRepository.GetEmployeeById((int)view.EmployeeId!);

                if (Employee != null && (Employee.User.Name != view.EmployeeName ||
                    Employee.User.Surname != view.EmployeeSurname ||
                    Employee.User.Email != view.EmployeeEmail ||
                    Employee.User.Dni != view.EmployeeDni ||
                    (!string.IsNullOrEmpty(view.EmployeePhone) && Employee.User.Phone != view.EmployeePhone) ||
                    Employee.Username != view.EmployeeUsername ||
                    Employee.Role.Name != view.EmployeeRole
                    ))
                {
                    DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar, ¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                homePresenter.ShowEmployeesView(this, EventArgs.Empty);
                view.Close();
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.EmployeeName) ||
                !string.IsNullOrWhiteSpace(view.EmployeeSurname) ||
                !string.IsNullOrWhiteSpace(view.EmployeeEmail) ||
                !string.IsNullOrWhiteSpace(view.EmployeePhone) ||
                view.EmployeeDni != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar, ¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            homePresenter.ShowEmployeesView(this, EventArgs.Empty);
            view.Close();
        }

        private async void DeleteEvent(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            bool isDeleted = await EmployeeRepository.DeleteEmployee((int)view.EmployeeId!);
            if (isDeleted)
            {
                homePresenter.ShowEmployeesView(this, EventArgs.Empty);
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
            string EmployeeName = view.EmployeeName!;
            string EmployeeSurname = view.EmployeeSurname!;
            string EmployeeEmail = view.EmployeeEmail!;
            int EmployeeDni = view.EmployeeDni;

            if (string.IsNullOrWhiteSpace(EmployeeName))
            {
                errorMessage = "Debe ingresar un nombre";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmployeeSurname))
            {
                errorMessage = "Debe ingresar un apellido";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmployeeEmail))
            {
                errorMessage = "Debe ingresar un email";
                isValid = false;
            }

            if (EmployeeDni == 0 || EmployeeDni.ToString().Length < 7 || EmployeeDni.ToString().Length > 10)
            {
                errorMessage = "Debe ingresar un dni valido";
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(view.EmployeePhone) && (view.EmployeePhone.Length < 9 || view.EmployeePhone.Length > 11 || view.EmployeePhone.Contains(" ") || !long.TryParse(view.EmployeePhone, out long phone)))
            {
                errorMessage = "Debe ingresar un telefono valido";
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
                "ipUser" => char.IsLetterOrDigit(inputChar) || char.IsWhiteSpace(inputChar),
                "ipEmail" => char.IsLetterOrDigit(inputChar) || char.IsWhiteSpace(inputChar),
                "ipPhone" => char.IsDigit(inputChar) && IsIntValid(textBox.Texts + inputChar),
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