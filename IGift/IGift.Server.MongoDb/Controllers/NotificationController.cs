namespace IGift.Server.MongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMyNotificationService _myNotificationService;

        public NotificationController(IMyNotificationService myNotificationService)
        {
            _myNotificationService = myNotificationService;
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
