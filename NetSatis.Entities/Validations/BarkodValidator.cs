using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class BarkodValidator : AbstractValidator<Barkod>
    {
        public BarkodValidator()
        {
            RuleFor(p => p.Barkodu).IsUnique();
        }
    }
}
