using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ZWA.Application.Core.Request.Handlers;
using ZWA.Application.Core.Request.Payload;
using ZWA.Infrastructure.Core.RequestHandling.Payload;

namespace ZWA.Infrastructure.Core.RequestHandling.Handlers
{
    public sealed class ApplicationRequestRouting : Mediator, IApplicationRequestRouting
    {
        public ApplicationRequestRouting(ServiceFactory serviceFactory) : base(serviceFactory) { }

        public async Task<TResponse> Send<TResponse>(IBaseRequestInput requestInput, CancellationToken cancellationToken = default) where TResponse : IBaseRequestOutput
        {
            return await base.Send(requestInput as IRequestInput<TResponse>, cancellationToken).ConfigureAwait(false);
        }

        public async Task Send(IBaseRequestInput requestInput, CancellationToken cancellationToken = default)
        {
            await base.Send(requestInput as IRequestInput, cancellationToken).ConfigureAwait(false);
        }

        public async Task Publish(IBaseNotificationInput notificationInput, CancellationToken cancellationToken = default)
        {
            await base.Publish(notificationInput as INotificationtInput, cancellationToken).ConfigureAwait(false);
        }
    }
}
