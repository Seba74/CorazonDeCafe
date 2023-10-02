using CorazonDeCafeStockManager.App.EntityData;
using FluentValidation;
using System.Linq;

namespace CorazonDeCafeStockManager.App.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeData>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x).Custom((employee, context) =>
            {
                if (string.IsNullOrEmpty(employee.Name) && string.IsNullOrEmpty(employee.Surname) && string.IsNullOrEmpty(employee.Email) && string.IsNullOrEmpty(employee.Dni) && string.IsNullOrEmpty(employee.Phone) && string.IsNullOrEmpty(employee.Username))
                {
                    context.AddFailure("Hay campos vacios o incompletos");
                }
            });

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("El nombre es requerido")
                .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("El apellido es requerido")
                .MinimumLength(3).WithMessage("El apellido debe tener al menos 3 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("El email es requerido")
                .EmailAddress().WithMessage("El email no es válido");

            RuleFor(x => x.Dni)
                .NotEmpty().WithMessage("El DNI es requerido")
                .Must(dni => string.IsNullOrWhiteSpace(dni) || dni.All(char.IsDigit) && dni.Length >= 7 && dni.Length <= 8).WithMessage("El DNI no es válido");

            RuleFor(x => x.Phone)
                .Must(phone => string.IsNullOrWhiteSpace(phone) || phone.All(char.IsDigit) && phone.Length >= 9 && phone.Length <= 11)
                .WithMessage("El teléfono no es válido");

            RuleFor(x => x.RoleId)
                .NotEmpty().WithMessage("El rol es requerido");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("El estado es requerido");

            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("El usuario es requerido")
                .MinimumLength(6).WithMessage("El usuario debe tener al menos 6 caracteres");
        }
    }
}