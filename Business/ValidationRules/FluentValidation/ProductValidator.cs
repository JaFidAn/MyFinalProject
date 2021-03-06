using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Bos olmaz");
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Bos olmaz"); ;
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("0 olmaz"); ;
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1).WithMessage("Bu kateqoriyada məhsulun qiyməti 10 dan kiçik ola bilməz");
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Məhsul A hərfi ilə başlamalıdır!"); //Özündən olmayan əlavə bir metod düzəldə bilərsən. Metod aşağıda
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
