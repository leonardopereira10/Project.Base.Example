using Project.Base.Contracts.Models;
using Project.Base.Example.Enumerators;

namespace Project.Base.Example.Contracts.Models
{
    public class DtoCity : DtoBase
    {
        public string PostalCode { get; set; }

        public CountryEnum Country { get; set; }

        public string Name { get; set; }
    }
}
