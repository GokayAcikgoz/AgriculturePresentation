using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsmi boş geçemessiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görevi boş geçemessiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resimi boş geçemessiniz");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("En fazla 50 karakter");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("En az 5 karakter");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("En fazla 50 karakter");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter");

        }
    }
}
