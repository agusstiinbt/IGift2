namespace IGift.Infrastructure.MongoDb.Services.cs.Repository
{
    public class NonAuditableRepository<T, TId> : INonAuditableMongoDbRepository<T, TId> where T : MongoDbEntity<TId>
    {
        private readonly IMongoCollection<T> _context;

        public NonAuditableRepository(IMongoCollection<T> context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.InsertOneAsync(entity);
        }

        public Task<Task> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> FindAsync(FilterDefinition<T> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var result = await _context.Find<T>(_ => true).ToListAsync();
                return result;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
