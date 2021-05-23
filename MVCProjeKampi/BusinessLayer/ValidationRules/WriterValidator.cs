using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adınını Boş Geçemezsiniz");
            RuleFor(x => x.Writersurname).NotEmpty().WithMessage("Yazar soyadını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).Must(WriterAbout => WriterAbout == "a");
            RuleFor(x => x.Writersurname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.Writersurname).MaximumLength(50).WithMessage("Lütfen 5 karakterden fazla değer girişi yapmayın");
        }

    }
}
