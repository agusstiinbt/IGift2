using IGift.Application.MongoDb.Models;

namespace IGift.Infrastructure.MongoDb.Services.cs.Repository
{
    public class NonAuditableMongoDbUnitOfWork<TId, T> : INonAuditableMongoDbUnitOfWork<TId, T>
     where T : MongoDbEntity<TId>
    {
        private readonly IMongoCollection<T> _collection;
        private Hashtable _repositories;

        public NonAuditableMongoDbUnitOfWork(IOptions<IGiftDataBaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);

            var collectionName = typeof(T)
                .GetCustomAttributes(typeof(CollectionNameAttribute), false)
                .Cast<CollectionNameAttribute>()
                .FirstOrDefault()?.Name;

            if (string.IsNullOrWhiteSpace(collectionName))
                throw new InvalidOperationException($"La colección no está especificada para {typeof(T).Name}");

            _collection = mongoDatabase.GetCollection<T>(collectionName);
        }

        public INonAuditableMongoDbRepository<T, TId> Repository()
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(NonAuditableRepository<,>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T), typeof(TId)), _collection);

                _repositories.Add(type, repositoryInstance);
            }

            return (INonAuditableMongoDbRepository<T, TId>)_repositories[type];
        }

        public Task<IResult> Commit(string mensajeExito, CancellationToken cancellationToken) => throw new NotImplementedException();
        public Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys) => throw new NotImplementedException();
        public Task Rollback() => throw new NotImplementedException();
        public void Dispose() => throw new NotImplementedException();
    }
}
