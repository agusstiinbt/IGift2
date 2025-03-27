namespace Application..Interfaces.Files
{
    public interface IProfilePicture
    {
        Task<IResult<ProfilePictureResponse>> GetByUserIdAsync(string IdUser);
        Task<IResult> SaveProfilePictureAsync(ProfilePictureUpload request);
    }
}
