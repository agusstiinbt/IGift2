namespace IGift.Application.MongoDb.Models.Chat.DTOs
{
    /// <summary>
    /// Esta clase va a ser responsable de mostrar los mensajes en el chat
    /// </summary>
    public class ChatHistoryRequest
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        public string? FromUserId { get; set; } = default!;
        public string? ToUserId { get; set; } = default!;
        public string? Message { get; set; } = default!;
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;
        public bool? Send { get; set; }
        public bool? Received { get; set; }
        public bool? Seen { get; set; }
    }
}
