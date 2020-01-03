using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ZWA.Domain.Core;

namespace ZWA.Application.Core.DbInteractors
{
    public interface IQueryRepository<TEntity, TKey, TFactor> where TEntity : IBaseEntity<TKey, TFactor>
    {
        IQueryable<TEntity> GetEntities(Expression<Func<TEntity, bool>> condition = null, Expression<Func<TEntity, object>> includes = null);

        IQueryable<TEntity> GetAvailableEntities(Expression<Func<TEntity, bool>> condition = null, Expression<Func<TEntity, object>> includes = null);

        Task<TEntity> GetFirst(Expression<Func<TEntity, bool>> condition = null, Expression<Func<TEntity, object>> includes = null);

        Task<bool> IsAny(Expression<Func<TEntity, bool>> condition = null);
    }
}
