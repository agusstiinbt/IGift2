namespace Shared.Constants
{
    //Atencion!!Leer linea siguiente:
    //Hacer CTRL+a,Ctrl+M+M
    public static class AppConstants
    {
        internal static class Local
        {
            public static readonly string BackgroundColor = "#181A20";

            public static string ShopCart = "shopCart";
            public static string AuthToken = "authToken";
            public static string Access_Token = "access_token";
            public static string RefreshToken = "refreshToken";
            public static string UserImageURL = "userImageURL";
            public static string ExpiryTime = "expiryTime";
            public static string IdUser = "idUser";

            //TODO esto va a estar en una bbdd
            #region A reemplazar con BBDD

            public static List<string> listaDesconectado = new List<string>() { "Ofertas", "Peticiones", "Categorias", "Electrodomesticos", "Historial", "Ayuda" };

            public static List<string> listaConectado = new List<string>() { "Ofertas", "Categorias", "Chat", "Peticiones", "Electrodomesticos", "Historial", "Ayuda", "Ofertas Grandes" };

            #endregion
        }

        internal static class Role
        {
            public static string AdministratorRole = "Administrator";
            public static string BasicRole = "Basic";
        }

        internal static class Routes
        {
            public static string Home = "/";
            public static string Register = "/Register";
            public static string Logout = "/Logout";
            public static string Login = "/Login";
            public static string Chat = "/Chat";
            public static string Peticiones = "/Peticiones";
            public static string UserProfile = "/UserProfile";
        }

        internal static class Server
        {
            /// <summary>
            /// ESTO SOLO DEBE USARSE EN EL SEEDER
            /// </summary>
            public static string ProfilePicture = "Files\\Images\\ProfilePictures\\";

            public static string AdminEmail = "agusstiinbt@gmail.com";
            public static string BasicEmail = "joseespositoing@gmail.com";
            public static string DefaultPassword = "Zx2555@@";

            /// <summary>
            /// Este servidor se conecta a SqlServer
            /// </summary>
            public const string AuthService = "AuthService";
            /// <summary>
            /// Este servidor se conecta a MongoDB
            /// </summary>
            public const string CommunicationService = "CommunicationService";


            public const string ApiGateway = "ApiGateway";
        }

        internal static class SignalR
        {
            public const string HubUrl = "/signalRHub";

            public const string UpdateDashboardAsync = "UpdateDashboardAsync";
            public const string ReceiveUpdateDashboardAsync = "ReceiveUpdateDashboardAsync";

            public const string RegenerateTokensAsync = "RegenerateTokensAsync";
            public const string ReceiveRegenerateTokensAsync = "ReceiveRegenerateTokensAsync";

            public const string ReceiveChatNotificationAsync = "ReceiveChatNotificationAsync";
            public const string SendChatNotificationAsync = "SendChatNotificationAsync";

            public const string ReceiveShopCartNotificationAsync = "ReceiveShopCartNotificationAsync";
            public const string SendShopCartNotificationAsync = "SendShopCartNotificationAsync";

            public const string ReceiveMessageAsync = "ReceiveMessageAsync";
            public const string SendMessageAsync = "SendMessageAsync";


            public const string OnConnect = "OnConnectAsync";
            public const string ConnectUserAsync = "ConnectUserAsync";

            public const string OnDisconnectAsync = "OnDisconnectAsync";
            public const string DisconnectUserAsync = "DisconnectUserAsync";

            public const string OnChangeRolePermissions = "OnChangeRolePermissions";
            public const string LogoutUsersByRoleAsync = "LogoutUsersByRoleAsync";

            /// <summary>
            /// Envía la petición para dejar a un usuario online/offline
            /// </summary>
            public const string PingRequest = "PingRequestAsync";
            /// <summary>
            /// Recibe la petición para dejar a un usuario online/offline
            /// </summary>
            public const string PingResponse = "PingResponseAsync";
        }
    }
}
