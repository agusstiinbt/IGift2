using Application.CQRS.Communication.Chat;
using Application.Interfaces.Communication.Chat;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IGift2.Controllers.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        /// <summary>
        /// Devuelve los chats de usuarios
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost("LoadChatUsers")]
        public async Task<ActionResult> LoadChatUsers(LoadChatUsers obj)
        {
            return Ok(await _chatService.LoadChatUsers(obj.IdCurrentUser));
        }

        [HttpPost("GetChatById")]
        public async Task<ActionResult> GetChatById(GetChatById obj)
        {
            return Ok(await _chatService.GetChatHistoryByIdAsync(obj.ToUserId));
        }

        /// <summary>
        /// asdf
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        [HttpPost("SaveMessage")]
        public async Task<ActionResult> SaveMessage(SaveChatMessage message)
        {
            return Ok(await _chatService.SaveMessage(message));
        }
    }
}
