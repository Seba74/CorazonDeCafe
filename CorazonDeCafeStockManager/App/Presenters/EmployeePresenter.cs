using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Validators;
using CorazonDeCafeStockManager.App.Views.EmployeeForm;
using CorazonDeCafeStockManager.utils.Custom.TextBox;
using FluentValidation.Results;

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
            view.EmployeeStatus = Employee.User.Status == 1 ? "activo" : "inactivo";
            view.Title = (Employee.User.Name + " " + Employee.User.Surname).ToUpper();
        }
        public void CloseView() => view.Close();
        private async void SaveEvent(object sender, EventArgs e)
        {

            Role role = await EmployeeRepository.GetRoleByName(view.EmployeeRole!);
            EmployeeData employeeData = new()
            {
                Name = view.EmployeeName,
                Surname = view.EmployeeSurname,
                Email = view.EmployeeEmail,
                Username = view.EmployeeUsername,
                RoleId = role.Id,
                Dni = view.EmployeeDni,
                Phone = view.EmployeePhone,
                Status = view.EmployeeStatus!.ToLower() == "activo" ? 1 : 0,
            };

            EmployeeValidator validator = new();
            ValidationResult result = validator.Validate(employeeData);

            if (!result.IsValid)
            {
                view.ShowError(result.Errors[0].ErrorMessage);
                return;
            }

            try
            {
                if (view.EmployeeId != null)
                {
                    employeeData.Id = (int)view.EmployeeId;
                    await EmployeeRepository.UpdateEmployee(employeeData);
                }
                else
                {
                    await EmployeeRepository.AddEmployee(employeeData);
                }
                
                homePresenter.ShowEmployeesView(this, EventArgs.Empty);
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
                return;
            }

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
                    Employee.Role.Name != view.EmployeeRole ||
                    (Employee.User.Status == 1 ? "activo" : "inactivo") != view.EmployeeStatus
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
                !string.IsNullOrWhiteSpace(view.EmployeeDni) ||
                !string.IsNullOrWhiteSpace(view.EmployeeUsername))
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

            try
            {
                bool isDeleted = await EmployeeRepository.DeleteEmployee((int)view.EmployeeId!);
                homePresenter.ShowEmployeesView(this, EventArgs.Empty);
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
                "ipName" => char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar),
                "ipSurname" => char.IsLetter(inputChar) || char.IsWhiteSpace(inputChar),
                "ipUser" => char.IsLetterOrDigit(inputChar) || char.IsWhiteSpace(inputChar),
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