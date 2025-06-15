namespace IGift.Application.Models.MongoDBModels
{
    public class Ratings
    {
        public Guid Id { get; set; }
        public string IdUsers { get; set; } = string.Empty;
        public double RateValue { get; set; }
    }
}
