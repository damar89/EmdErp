using FluentValidation.Validators;
using NetSatis.Entities.Context;
using NetSatis.Entities.Interface;
using System.Linq;
using System.Linq.Dynamic;

namespace NetSatis.Entities.Extensions.FluentValidation
{
    public class UniqueValidator<TEntity> : PropertyValidator
    where TEntity : class, IEntity, new()
    {
        public UniqueValidator() : base("Girdiğiniz {PropertyName} kayıtlarda var.")
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var dataId = context.Instance.GetType().GetProperty("Id").GetValue(context.Instance);
            using (var netSatisContext = new NetSatisContext())
            {
                var result = netSatisContext.Set<TEntity>().Where($"{context.PropertyName}==@0 And Id!=@1", context.PropertyValue, dataId).Any();
                return !result;
            }
        }
    }
}
