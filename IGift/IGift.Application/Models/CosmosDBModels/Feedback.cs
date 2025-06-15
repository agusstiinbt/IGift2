namespace IGift.Application.Models.MongoDBModels
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string IdUser { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
    }
}
