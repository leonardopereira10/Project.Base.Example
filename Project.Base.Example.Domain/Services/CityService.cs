using Project.Base.Domain.Services;
using Project.Base.Example.Contracts.Models;
using Project.Base.Example.Contracts.ServiceContracts;
using Project.Base.Example.Domain.Converter;
using Project.Base.Example.Domain.Objects;
using Project.Base.Example.Domain.Repositories.Interfaces;
using Project.Base.Example.Domain.Validators;

namespace Project.Base.Example.Domain.Services
{
    public class CityService : BaseService<City, DtoCity>, ICityService
    {
        private CityValidator validator;
        private CityConverter converter;

        public CityService(ICityRepository repository) : base(repository)
        {
        }

        protected override Base.Domain.Object.Shared.IDefaultConverter<City, DtoCity> Converter()
        {
            return converter ??= new CityConverter();
        }

        protected override Base.Domain.Validators.IBaseAbstractValidator<City> Validator()
        {
            return validator ??= new CityValidator();
        }
    }
}
