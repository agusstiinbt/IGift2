using Application.CQRS.Identity.Token;
using Application.CQRS.Identity.Users;
using Application.Interfaces.Identity;
using Application.Responses.Identity.Users;
using Microsoft.AspNetCore.Mvc;
using Shared.Wrappers;

namespace IGift2.Controllers.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<Result<TokenResponse>>> Login(UserLoginRequest m)
        {
            return Ok(await _tokenService.LoginAsync(m));
        }
        [HttpPost("RefreshToken")]
        public async Task<ActionResult<Result>> RefreshToken(TokenRequest t)
        {
            return Ok(await _tokenService.RefreshUserToken(t));
        }
    }
}
