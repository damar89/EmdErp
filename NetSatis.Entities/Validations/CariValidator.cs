using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class CariValidator:AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Bırakılamaz");
            RuleFor(p => p.CariKodu).IsUnique();
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Bırakılamaz");
            //RuleFor(p => p.VergiDairesi).NotEmpty().WithMessage("Vergi Dairesi Alanı Boş Bırakılamaz");
            //RuleFor(p => p.VergiNo).NotEmpty().WithMessage("Vergi No Alanı Boş Bırakılamaz");
            //RuleFor(p => p.VergiNo).IsUnique();
            
        }
    }
}
