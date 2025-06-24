namespace IGift.Infrastructure.MongoDb.Services.cs.Models
{
    public class MyNotificationService : IMyNotificationService
    {
        private readonly INonAuditableMongoDbUnitOfWork<string, MyNotification> _unitOfWork;

        public MyNotificationService(INonAuditableMongoDbUnitOfWork<string, MyNotification> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //TODO Fijarse si se puede hacer uso de la clase estatica "Objects" creada en el application de mongoDb

        public Task CreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<MyNotification>> GetAsync(FilterDefinition<MyNotification> filter)
        {
            throw new NotImplementedException();
        }
    }
}
