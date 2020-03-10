﻿using FluentValidation;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Extensions.FluentValidation
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilderOptions<TEntity, object> IsUnique<TEntity>(
            this IRuleBuilder<TEntity, object> ruleBuilder)
            where TEntity : class, IEntity, new()
        {
            return ruleBuilder.SetValidator(new UniqueValidator<TEntity>());
        }
    }
}
