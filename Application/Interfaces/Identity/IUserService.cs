using Application.CQRS.Identity.Password;
using Application.CQRS.Identity.Users;
using Application.Responses.Identity.Users;
using Application.Responses.Users;
using Shared.Wrappers;

namespace Application.Interfaces.Identity
{
    public interface IUserService
    {
        Task<Result<IEnumerable<UserResponse>>> GetAllAsync();
        Task<int> HowMany();

        Task<IResult<UserResponse>> GetByIdAsync(string id);
        Task<IResult> RegisterAsync(UserCreateRequest model);

        Task<IResult> ChangeUserStatus(ChangeUserRequest request);

        Task<IResult<UserRolesResponse>> GetRolesAsync(string id);

        /// <summary>
        /// Este método recibe una lista de roles habiendo especificado si estan seleccionados o no. De aquellos seleccionado en true esos pasarán a ser los nuevos roles del usuario, reemplazando los anteriores si no fueron seleccionados. Esto solo funciona si somos adminitradores
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<IResult> UpdateRolesAsync(UpdateUserRolesRequest request);

        Task<IResult<string>> ConfirmEmailAsync(string userId, string code);

        Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);
        Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);

        Task<string> ExportToExcelAsync(string searchString = "");
    }
}
