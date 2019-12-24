using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
   public class KullaniciValidator:AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Bırakılamaz");
            RuleFor(p => p.Adi).NotEmpty().WithMessage("Adı Alanı Boş Bırakılamaz");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola Boş Bırakılamaz");
          
            
        }
    }
}
