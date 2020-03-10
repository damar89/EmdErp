using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Alanı Boş Bırakılamaz");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa Adı Alanı Boş Bırakılamaz");
        }
    }
}
