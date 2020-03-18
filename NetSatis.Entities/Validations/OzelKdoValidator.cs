using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class OzelKdoValidator: AbstractValidator<OzelKod>
    {
        public OzelKdoValidator()
        {
            RuleFor(p => p.Kod).NotEmpty().WithMessage("ÖzelKod Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.Kod).IsUnique();
            RuleFor(p => p.OzelKodAdi).NotEmpty().WithMessage("ÖzelKod Adı Adı Alanı Boş Geçilemez");
        }  
    }
}
