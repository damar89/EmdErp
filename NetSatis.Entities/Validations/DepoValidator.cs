using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Context;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
   public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu Alanı Boş Bırakılamaz");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı Alanı Boş Bırakılamaz");
            RuleFor(p => p.DepoKodu).IsUnique();

        }

      
    }
}
