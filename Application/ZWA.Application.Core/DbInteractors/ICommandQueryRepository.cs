using ZWA.Domain.Core;

namespace ZWA.Application.Core.DbInteractors
{
    public interface ICommandQueryRepositor<TEntity, TKey, TFactor> : ICommandRepository<TEntity, TKey, TFactor>, IQueryRepository<TEntity, TKey, TFactor>
                                                                      where TEntity : IBaseEntity<TKey, TFactor>
    { }
}
