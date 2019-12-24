using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class KategoriValidator : AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            RuleFor(p => p.Kod).NotEmpty().WithMessage("Kategori Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.Kod).IsUnique();
            RuleFor(p => p.KategoriAdi).NotEmpty().WithMessage("Kategori Adı Alanı Boş Geçilemez");
       
        }
    }
}
