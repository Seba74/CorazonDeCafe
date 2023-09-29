using CorazonDeCafeStockManager.App.EntityData;
using FluentValidation;
using System.Linq;

namespace CorazonDeCafeStockManager.App.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerData>
    {
        public CustomerValidator()
        {
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
                .Must(dni => string.IsNullOrWhiteSpace(dni) || dni.All(char.IsDigit) && dni.Length >= 7 && dni.Length <= 8);

            RuleFor(x => x.Phone)
                .Must(phone => string.IsNullOrWhiteSpace(phone) || phone.All(char.IsDigit) && phone.Length >= 9 && phone.Length <= 11)
                .WithMessage("El teléfono no es válido");

            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("La calle es requerida");

            RuleFor(x => x.Number)
                .NotEmpty().WithMessage("El número es requerido")
                .Must(number => number >= 0).WithMessage("El número debe ser mayor o igual a cero");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("La ciudad es requerida");

            RuleFor(x => x.Province)
                .NotEmpty().WithMessage("La provincia es requerida");

            RuleFor(x => x.PostalCode)
                .NotEmpty().WithMessage("El código postal es requerido")
                .Must(postalCode => postalCode!.All(char.IsDigit) && (postalCode!.Length >= 4 || postalCode!.Length <= 7)).WithMessage("El código postal no es válido");
        }
    }
}