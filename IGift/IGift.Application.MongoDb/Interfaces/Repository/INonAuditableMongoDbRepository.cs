namespace IGift.Application.MongoDb.Interfaces.Repository
{
    public interface INonAuditableMongoDbRepository<T, in TId> where T : class, IEntity<TId>
    {
        Task AddAsync(T entity);
        Task<List<T>> FindAsync(FilterDefinition<T> filter);
        Task<IEnumerable<T>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task<Task> DeleteAsync(T entity);
    }
}
