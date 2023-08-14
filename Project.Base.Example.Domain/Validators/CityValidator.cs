using System.Text.RegularExpressions;
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
                .WithMessage("Sem nome");

            _ = RuleFor(x => x)
                .Must(x =>
                {
                    Match match = Regex.Match(x.PostalCode, City.POSTAL_CODE_PATTERN[x.Country]);
                    return match.Success && match.Value.Replace("-", string.Empty) == x.PostalCode.Replace("-", string.Empty);
                })
                .OverridePropertyName(x => x.PostalCode)
                .WithMessage("postal code invalido");
        }
    }
}
