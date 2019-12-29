namespace ZWA.Domain.Core.ChangeTrackers
{
    public interface IChangeFactor<TKey> 
    {
        TKey CreatedBy { get; set; }

        TKey ModifiedBy { get; set; }
    }
}
