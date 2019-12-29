using System;

namespace ZWA.Domain.Core.ChangeTrackers
{
    public interface IDateTimeTracker
    {
        DateTimeOffset CreatedDate { get; set; }

        DateTimeOffset ModifiedDate { get; set; }
    }
}
