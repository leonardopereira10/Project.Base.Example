using Project.Base.Domain.Converters;
using Project.Base.Example.Contracts.Models;
using Project.Base.Example.Domain.Objects;

namespace Project.Base.Example.Domain.Converter
{
    internal class CityConverter : DefaultConverter<City, DtoCity>
    {
    }
}
