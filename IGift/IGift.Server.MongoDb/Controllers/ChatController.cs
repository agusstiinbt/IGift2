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

        [HttpPost]
        public async Task<ActionResult> GetAsync()
        {
            var chat = new ChatHistory
            {
                Message = "Hola como estas",
            };
            var result = await _chatService.FindAllAsync(chat);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync()
        {
            await _chatService.CreateAsync();

            return Ok();
        }
    }
}
