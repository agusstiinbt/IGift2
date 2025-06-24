namespace IGift.Application.MongoDb.Interfaces.Models
{
    public interface IMyNotificationService
    {
        Task<List<MyNotification>> GetAsync(FilterDefinition<MyNotification> filter);
        Task CreateAsync();
    }
}
