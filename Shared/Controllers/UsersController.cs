namespace Shared.Controllers
{
    public static class UsersController
    {
        private const string route = "api/Users/";

        public const string GetAll = route + "GetAll";
        public const string Register = route + "Register";
        public const string GetById = route + "GetById";
        public const string ChangeUserStatus = route + "ChangeUserStatus";
        public const string ForgotPassword = route + "ForgotPassword";
        public const string GetRolesFromUserId = route + "GetRolesFromUserId";
        public const string UpdateRolesFromUser = route + "UpdateRolesFromUser";
    }
}
