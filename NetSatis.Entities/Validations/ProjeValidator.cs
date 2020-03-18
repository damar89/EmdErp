using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class ProjeValidator:AbstractValidator<Proje>
    {
        public ProjeValidator()
        {
            RuleFor(p => p.Kod).NotEmpty().WithMessage("Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.Kod).IsUnique();
            RuleFor(p => p.ProjeAdi).NotEmpty().WithMessage("Proje Adı Alanı Boş Geçilemez");
        }
    }
}
