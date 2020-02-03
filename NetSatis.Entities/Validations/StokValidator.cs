using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.StokKodu).IsUnique();
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı Alanı Boş Geçilemez").Length(3, 75)
                .WithMessage("Stok Adı Alanı 3 ile 75 Karakter Aralığı Arası Olmalıdır");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 1 Alanı 0'dan Büyük Olmalıdır.");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 2 Alanı 0'dan Büyük Olmalıdır.");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 3 Alanı 0'dan Büyük Olmalıdır.");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 1 Alanı 0'dan Büyük Olmalıdır.");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 2 Alanı 0'dan Büyük Olmalıdır.");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 3 Alanı 0'dan Büyük Olmalıdır.");




        }
    }
}
