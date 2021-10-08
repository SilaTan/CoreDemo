using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            RuleFor(x => x.WriterPassword).Must(x => HasValidPassword(x)).WithMessage("Yazarın şifresi en az bir küçük harf, bir büyük harf ve bir sayı içermelidir.");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.WriterPassword).WithMessage("Parolalar eşleşmedi, Tekrar deneyin !");
        }
        private bool HasValidPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");

            return (lowercase.IsMatch(pw) && uppercase.IsMatch(pw) && digit.IsMatch(pw) );
        }
    }
}
