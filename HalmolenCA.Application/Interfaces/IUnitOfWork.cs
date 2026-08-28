using System;
using System.Collections.Generic;
using System.Text;

namespace HalmolenCA.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
        void Add<TEntity>(TEntity entity) where TEntity : class;
        void Remove<TEntity>(TEntity entity) where TEntity : class;

    }
}
