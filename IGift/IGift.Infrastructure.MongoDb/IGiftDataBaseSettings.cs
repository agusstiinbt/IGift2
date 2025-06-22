namespace IGift.Infrastructure.MongoDb
{
    public class IGiftDataBaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;
        public MongoCollections Collections { get; set; } = null!;
    }

    public class MongoCollections
    {
        public string ChatHistories { get; set; } = null!;
        public string Notifications { get; set; } = null!;
        public string Titles { get; set; } = null!;
    }
}
