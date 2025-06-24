namespace IGift.Infrastructure.MongoDb.Services.cs.Models
{
    public class TitlesService : ITitlesService
    {
        public Task CreateAsync(Titles onlineTitle)
        {
            throw new NotImplementedException();
        }

        public Task<List<Titles>> GetAsync(FilterDefinition<Application.MongoDb.Models.Titles> filter)
        {
            throw new NotImplementedException();
        }
    }
}
