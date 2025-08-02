using Diyetiva.WebApi.Entities;
using FluentValidation;

namespace Diyetiva.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin!");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapın!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapın!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");
        }
    }
}
