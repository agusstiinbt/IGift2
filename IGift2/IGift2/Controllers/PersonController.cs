using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace IGift2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var lista = await _personService.GetPeopleAsync();
            return Ok(lista);
        }
    }
}
