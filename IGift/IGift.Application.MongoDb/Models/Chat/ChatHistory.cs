namespace IGift.Application.MongoDb.Models.Chat
{
    [CollectionName("ChatHistories")]
    public class ChatHistory : MongoDbEntity<string>
    {
        [BsonElement("fromUserId")]
        public string? FromUserId { get; set; } = null;

        [BsonElement("toUserId")]
        public string? ToUserId { get; set; } = null;

        [BsonElement("message")]
        public string? Message { get; set; } = null;

        [BsonElement("createdDate")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? CreatedDate { get; set; } = null;

        [BsonElement("send")]
        public bool? Send { get; set; } = null;

        [BsonElement("received")]
        public bool? Received { get; set; } = null;

        [BsonElement("seen")]
        public bool? Seen { get; set; } = null;
    }
}
