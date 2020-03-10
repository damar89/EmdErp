﻿using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım Türü Alanı Boş Bırakılamaz");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanımı Alanı Boş Bırakılamaz");
        }
    }
}
