namespace ZWA.Domain.Core
{
    public interface IIdentity<TKey>
    {
        TKey Id { get; set; }
    }
}
