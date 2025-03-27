namespace Shared.Controllers
{
    public static class ChatController
    {
        private const string route = "api/Chat/";

        public const string LoadChatUsers = route + "LoadChatUsers";
        public const string GetChatById = route + "GetChatById";
        public const string SaveMessage = route + "SaveMessage";
    }
}
