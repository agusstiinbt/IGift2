namespace IGift.Application.CosmosDb.Models
{
    public class LogsActividad
    {
        public DateTime TimeSpendInPage { get; set; }
        public List<string> ButtonsUsed { get; set; } = new List<string>();
        public List<string> PagesVisited { get; set; } = new List<string>();
        public DateTime Date { get; set; }
    }
}
