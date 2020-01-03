using System;
using System.Threading.Tasks;

namespace ZWA.Application.Core.DbInteractors
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();

        Task<int> CommitAsync();
    }
}
