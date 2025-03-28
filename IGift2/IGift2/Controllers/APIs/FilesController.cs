using Application.CQRS.Files.ProfilePicture;
using Application.Interfaces.Files;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IGift2.Controllers.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FilesController : ControllerBase
    {
        private readonly IProfilePicture _profileService;

        public FilesController(IProfilePicture profileService)
        {
            _profileService = profileService;
        }

        /// <summary>
        /// Devuelve la foto de perfil de usuario con el Id pasado como parametro
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost("GetProfilePictureById")]//TODO estudiar el resposnecache que tiene este metodo en el blazor hero
        public async Task<ActionResult> GetProfilePictureAsync(ProfilePictureById p)
        {
            return Ok(await _profileService.GetByUserIdAsync(p.Id));
        }

        [HttpPost("UploadProfilePicture")]
        public async Task<ActionResult> UploadProfileAsync(ProfilePictureUpload request)
        {
            return Ok(await _profileService.SaveProfilePictureAsync(request));
        }
    }
}
