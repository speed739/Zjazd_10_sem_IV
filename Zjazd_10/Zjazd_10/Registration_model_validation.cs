﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_10
{
    public class Registration_model_validation : AbstractValidator<Registration_model>
    {
        public Registration_model_validation()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.login)
            .NotNull()
            .NotEmpty()
            .MinimumLength(6);

            RuleFor(x => x.password)
            .NotNull()
            .NotEmpty()
            .MinimumLength(6)
            .Must(x => x != x.ToUpper())
            .Must(x => x != x.ToLower())
            .Matches(@"(.[!@#$%^&().+].*)+");
        }
    }
}
