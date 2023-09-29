using CorazonDeCafeStockManager.App.EntityData;
using FluentValidation;
using System.Linq;

namespace CorazonDeCafeStockManager.App.Validators
{
    public class ProductValidator : AbstractValidator<ProductData>
    {
        public ProductValidator()
        {
            RuleFor(x => x).Custom((product, context) =>
            {
                if (string.IsNullOrEmpty(product.Name) && product.Price == 0 && product.Stock == -1)
                {
                    context.AddFailure("Hay campos vacios o incompletos");
                }
            });
            RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre es requerido");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("El precio debe ser mayor que cero");
            RuleFor(x => x.Stock).GreaterThanOrEqualTo(0).WithMessage("El stock debe ser igual o mayor que cero");
            RuleFor(x => x.Category).NotEmpty().WithMessage("La categoría es requerida").NotEqual("Categoría").WithMessage("La categoría es requerida");
            RuleFor(x => x.Type).NotEmpty().WithMessage("El tipo es requerido").NotEqual("Tipo").WithMessage("El tipo es requerido");
        }
    }
}