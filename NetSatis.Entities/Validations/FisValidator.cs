using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class FisValidator:AbstractValidator<Fis>
    {
        public FisValidator()
        {
            RuleFor(p => p.FisKodu).IsUnique();
        }
    }
}