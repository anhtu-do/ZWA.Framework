using MediatR;
using Microsoft.Extensions.Logging;

namespace ZWA.Application.Core.Request
{
    public interface IRequestDependenciesContainer<TCaller>
    {
        ILogger Logger { get; }

        IMediator Router { get; }
    }

    public class RequestDependenciesContainer<TCaller> : IRequestDependenciesContainer<TCaller>
    {
        public ILogger Logger { get; }

        public IMediator Router { get; }

        public RequestDependenciesContainer(IMediator router, ILoggerFactory loggerFactory)
        {
            Router = router;
            Logger = loggerFactory.CreateLogger<TCaller>();
        }
    }
}
