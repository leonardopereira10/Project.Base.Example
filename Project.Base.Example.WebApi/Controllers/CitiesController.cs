using Microsoft.AspNetCore.Mvc;
using Project.Base.Contracts.Models;
using Project.Base.Enumerators;
using Project.Base.Example.Contracts.Models;
using Project.Base.Example.Contracts.ServiceContracts;
using Project.Base.WebApi.Controllers;

namespace Project.Base.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = false)]
    public class CitiesController : AbstractController<DtoCity>
    {
        public CitiesController(ICityService service) : base(service)
        {
        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public new Task<ActionResult<DtoOutput<DtoCity>>> Insert([FromBody] DtoCity newObj)
        {
            return base.Insert(newObj);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public new Task<ActionResult<DtoOutput<DtoCity>>> FindById(Guid id)
        {
            return base.FindById(id);
        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public new Task<ActionResult<DtoOutput<DtoCity>>> Find([FromQuery] int page, [FromQuery] int limit, [FromQuery] EnumOrder order, [FromQuery] string? searchTarget, [FromQuery] string searchTerm)
        {
            return base.Find(page, limit, order, searchTarget, searchTerm);
        }

        [HttpPut()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public new Task<ActionResult<DtoOutput<DtoCity>>> Update([FromBody] DtoCity newObj)
        {
            return base.Update(newObj);
        }

        [HttpDelete()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public new ActionResult Delete(Guid id)
        {
            return base.Delete(id);
        }
    }
}
