using Application.CQRS.Identity.Token;
using Application.CQRS.Identity.Users;
using Application.Responses.Identity.Users;
using Shared.Wrappers;

namespace Application.Interfaces.Identity
{
    public interface ITokenService
    {
        Task<Result<TokenResponse>> LoginAsync(UserLoginRequest model);
        Task<Result<TokenResponse>> RefreshUserToken(TokenRequest tRequest);
    }
}
