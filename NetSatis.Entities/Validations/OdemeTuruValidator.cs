using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Türü Kodu Alanı Boş Bırakılamaz");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme Türü Adı Alanı Boş Bırakılamaz");
        }
    }
}
