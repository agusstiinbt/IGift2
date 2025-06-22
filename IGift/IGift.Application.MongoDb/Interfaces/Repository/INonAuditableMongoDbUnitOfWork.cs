namespace IGift.Application.MongoDb.Interfaces.Repository
{
    public interface INonAuditableMongoDbUnitOfWork<TId, T> : IDisposable
    where T : MongoDbEntity<TId>
    {
        INonAuditableMongoDbRepository<T, TId> Repository();

        Task<IResult> Commit(string mensajeExito, CancellationToken cancellationToken);

        Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

        Task Rollback();
    }
}
