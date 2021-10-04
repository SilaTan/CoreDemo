using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazarın adı soyadı boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazarın adı en az 2 harf olmalı.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazarın adı en fazla 50 harf olmalı.");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazarın maili boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazarın şifresi boş geçilemez.");
        }
    }
}
