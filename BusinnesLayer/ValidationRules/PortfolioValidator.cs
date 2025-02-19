using FluentValidation;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Portföy adı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Portföy Görsel 1 boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Portföy Görsel 2 boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Portföy Fiyat boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Portföy Değer boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Portföy adı en az 5 karaterden oluşmalıdır");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Portföy adı en fala 100 karaterden oluşmalıdır");
        }
    }
}
