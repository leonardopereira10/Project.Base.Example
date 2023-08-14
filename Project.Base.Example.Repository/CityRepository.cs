using Project.Base.Domain.Repositories;
using Project.Base.Example.Domain.Objects;
using Project.Base.Example.Domain.Repositories.Interfaces;
using Project.Base.Repository.Implementations;

namespace Project.Base.Example.Repository
{
    public class CityRepository : BaseObjectWithIdRepository<City>, ICityRepository
    {
        public CityRepository(MyDbContext context) : base(context)
        {
        }

        protected override PagedSearchReturn<City> ListWithSearchTerm(PagedSearchParam searchParams)
        {
            throw new NotImplementedException();
        }
    }
}
