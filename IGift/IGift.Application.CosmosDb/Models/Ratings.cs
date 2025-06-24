namespace IGift.Application.CosmosDb.Models
{
    public class Ratings
    {
        public int IdUser { get; set; }
        public decimal Stars { get; set; }
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
