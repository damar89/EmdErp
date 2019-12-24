using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class AltGrupValidator: AbstractValidator<AltGrup>
    {
        public AltGrupValidator()
        {
             RuleFor(p => p.Kod).NotEmpty().WithMessage("AltGrup Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.Kod).IsUnique();
             RuleFor(p => p.AltGrupAdi).NotEmpty().WithMessage("AltGrup Adı Alanı Boş Geçilemez");
          
        }
    }
}
