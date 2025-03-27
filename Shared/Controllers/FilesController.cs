namespace Shared.Controllers
{
    public static class FilesController
    {
        private static string route = "api/Files/";

        public static string GetProfilePictureById = route + "GetProfilePictureById";
        public static string UploadProfilePicture = route + "UploadProfilePicture";
    }
}
