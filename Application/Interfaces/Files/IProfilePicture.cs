using Application.CQRS.Files.ProfilePicture;
using Application.Responses.Files;
using Shared.Wrappers;

namespace Application.Interfaces.Files
{
    public interface IProfilePicture
    {
        Task<IResult<ProfilePictureResponse>> GetByUserIdAsync(string IdUser);
        Task<IResult> SaveProfilePictureAsync(ProfilePictureUpload request);
    }
}
