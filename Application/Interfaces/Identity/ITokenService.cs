namespace Application..Interfaces.Identity
{
    public interface ITokenService
    {
        Task<Result<TokenResponse>> LoginAsync(UserLoginRequest model);
        Task<Result<TokenResponse>> RefreshUserToken(TokenRequest tRequest);
    }
}
