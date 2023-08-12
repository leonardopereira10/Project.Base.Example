using Microsoft.AspNetCore.Mvc;
using Project.Base.Example.Contracts.Models;
using Project.Base.Example.Contracts.ServiceContracts;
using Project.Base.WebApi.Controllers;

namespace Project.Base.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : AbstractController<DtoCity>
    {
        public CitiesController(ICityService service) : base(service)
        {
        }
    }
}
