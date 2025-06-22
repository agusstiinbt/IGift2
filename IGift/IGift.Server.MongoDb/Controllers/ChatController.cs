using Microsoft.AspNetCore.Mvc;

namespace IGift.Server.MongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService2 _chatService;

        public ChatController(IChatService2 chatService)
        {
            _chatService = chatService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _chatService.GetAsync(null));
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync()
        {
            await _chatService.CreateAsync();

            return Ok();
        }
    }
}
