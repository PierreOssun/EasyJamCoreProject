using EasyJamCore.NancyHost.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyJamCore.NancyHost.Requests.Validators
{
    public class DancerRequestValidator : AbstractValidator<DancerRequest>
    {
        public DancerRequestValidator()
        {
            RuleFor(dr => dr.Id).GreaterThan(0);
        }
    }
}
