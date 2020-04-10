using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class RaporlamaValidator : AbstractValidator<RaporTasarimlari>
    {
        public RaporlamaValidator()
        {
            RuleFor(p => p.DizaynIsmi).NotEmpty().WithMessage("Dizayn İsmi Boş Geçilemez!");
        }
    }
}
