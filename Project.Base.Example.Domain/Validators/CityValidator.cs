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
                    string value = Regex.Match(x.PostalCode, City.POSTAL_CODE_PATTERN[x.Country]).Value.Replace("-", string.Empty);
                    return value == x.PostalCode.Replace("-", string.Empty);
                })
                .WithMessage("postal code invalido");
        }
    }
}
