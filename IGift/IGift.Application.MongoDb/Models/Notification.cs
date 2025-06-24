namespace IGift.Application.MongoDb.Models
{
    public class MyNotification : MongoDbEntity<string>
    {
        public string IdUser { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public TypeNotification Type { get; set; }
    }

    public enum TypeNotification
    {
        /// <summary>
        /// Notificaciones de mensajes en algún chat
        /// </summary>
        Chat,
        /// <summary>
        /// Notificaciones de correos a nuestra cuenta
        /// </summary>
        Email,
        /// <summary>
        /// Notificaciones propias de la aplicación como vencimientos, últimos accesos, etc
        /// </summary>
        Cuenta,
    }
}
