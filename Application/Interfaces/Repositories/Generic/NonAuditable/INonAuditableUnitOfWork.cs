﻿using Domain.Contracts;
using Shared.Wrappers;

namespace Application.Interfaces.Repositories.Generic.NonAuditable
{
    public interface INonAuditableUnitOfWork<TId> : IDisposable
    {
        INonAuditableRepository<T, TId> Repository<T>() where T : Entity<TId>;

        Task<IResult> Commit(string mensajeExito, CancellationToken cancellationToken);

        Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

        Task Rollback();
    }
}
