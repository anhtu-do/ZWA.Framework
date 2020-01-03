using System;
using ZWA.Domain.Core.ChangeTrackers;

namespace ZWA.Domain.Core
{
    public interface IBaseEntity<TKey, TFactor> : IIdentity<TKey>, IChangeFactor<TFactor>, IDateTimeTracker { }

    public abstract class BaseEntity<TKey, TFactor> : IBaseEntity<TKey, TFactor>
    {
        public TKey Id { get; set; }

        public TFactor CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public TFactor ModifiedBy { get; set; }

        public DateTimeOffset ModifiedDate { get; set; }
    }

}
