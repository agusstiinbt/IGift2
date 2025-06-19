namespace IGift.Application.MongoDb.Models.Chat
{
    public class ChatHistory
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [BsonElement("fromUserId")]
        public string FromUserId { get; set; } = default!;

        [BsonElement("toUserId")]
        public string ToUserId { get; set; } = default!;

        [BsonElement("message")]
        public string Message { get; set; } = default!;

        [BsonElement("createdDate")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [BsonElement("send")]
        public bool Send { get; set; }

        [BsonElement("received")]
        public bool Received { get; set; }

        [BsonElement("seen")]
        public bool Seen { get; set; }
    }
}
