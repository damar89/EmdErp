using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class AnaGrupValidator : AbstractValidator<AnaGrup>
    {
        public AnaGrupValidator()
        {
             RuleFor(p => p.Kod).NotEmpty().WithMessage("AnaGrup Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.Kod).IsUnique();
             RuleFor(p => p.AnaGrupAdi).NotEmpty().WithMessage("AnaGrup Adı Alanı Boş Geçilemez");
           
        }
    }
}
