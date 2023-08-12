using FluentValidation;
using Project.Base.Domain.Validators;
using Project.Base.Example.Domain.Objects;

namespace Project.Base.Example.Domain.Validators
{
    internal class CityValidator : BaseAbstractValidator<City>
    {
        public override void AssignCommonValidations()
        {
            _ = RuleFor(x => x.PostalCode)
                .NotEmpty()
                .WithMessage("");

            _ = RuleFor(x => x.PostalCode)
                .Matches(y => City.POSTAL_CODE_PATTERN[y.Country])
                .WithMessage("");
        }
    }
}
