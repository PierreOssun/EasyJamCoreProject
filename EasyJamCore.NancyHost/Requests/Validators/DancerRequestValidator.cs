namespace EasyJamCore.NancyHost.Requests.Validators
{
    using EasyJamCore.NancyHost.Request;
    using FluentValidation;

    public class DancerRequestValidator : AbstractValidator<DancerRequest>
    {
        public DancerRequestValidator()
        {
            RuleFor(dr => dr.Id).GreaterThan(0);
        }
    }
}
