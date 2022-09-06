using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("En fazla 20 karakter");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("En az 8 karakter");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("En fazla 50 karakter");
            RuleFor(x => x.Description).MinimumLength(8).WithMessage("En az 8 karakter");
        }
    }
}
