namespace IGift.Server.MongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private readonly ITitlesService _titlesService;

        public TitlesController(ITitlesService titlesService)
        {
            _titlesService = titlesService;
        }

        [HttpPost]
        public async Task<ActionResult> GetAsync()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync()
        {
            return Ok();
        }
    }
}
