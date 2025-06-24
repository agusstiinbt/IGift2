namespace IGift.Application.MongoDb.Interfaces.Models
{
    public interface ITitlesService
    {
        Task<List<Titles>> GetAsync(FilterDefinition<MongoDb.Models.Titles> filter);
        Task CreateAsync(Titles onlineTitle);
    }
}
