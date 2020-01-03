using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ZWA.Domain.Core;

namespace ZWA.Application.Core.DbInteractors
{
    public interface ICommandRepository<TEntity, TKey, TFactor> where TEntity : IBaseEntity<TKey, TFactor> 
    {
        Task AddAsync(TEntity entity);

        Task AddMultipleAsync(IEnumerable<TEntity> entities);

        Task UpdateAsync(TEntity entity);
        
        Task UpdateMultipleAsync(IEnumerable<TEntity> entities);

        Task SoftDeleteAsync(TEntity entity);

        Task SoftDeleteMultipleAsync(IEnumerable<TEntity> entities);

        Task SoftDeleteByConditionAsync(Expression<Func<TEntity, bool>> condition);
        
        Task HardDeleteAsync(TEntity entity);

        Task HardDeleteMultipleAsync(IEnumerable<TEntity> entities);

        Task HardDeleteByConditionAsync(Expression<Func<TEntity, bool>> condition);
    }
}
