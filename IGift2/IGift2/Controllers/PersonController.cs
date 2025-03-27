using Microsoft.AspNetCore.Mvc;
using Shared;

namespace IGift2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var lista = new List<Person>()
            {
                new Person(){Nombre="Agustin",Apellido="Esposito" },
                new Person(){Nombre="Lucia",Apellido="Esposito" },
                new Person(){Nombre="Jose",Apellido="Esposito" },
            };
            return Ok(lista);
        }
    }
}
