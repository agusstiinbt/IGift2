using Application.CQRS.Notifications.Query;
using IGift2.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IGift2.Controllers.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationController : BaseApiController<NotificationController>
    {
        [HttpPost]
        public async Task<ActionResult> GetAll(GetAllNotificationQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
