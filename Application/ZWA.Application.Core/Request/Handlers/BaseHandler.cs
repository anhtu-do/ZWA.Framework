using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ZWA.Application.Core.Request.Payload;

namespace ZWA.Application.Core.Request.Handlers
{
    public abstract class AsynchronousRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequestInput<TResponse> where TResponse : IRequestResponse
    {
        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }

    public abstract class AsynchronousRequestHandler<TRequest> : AsyncRequestHandler<TRequest> where TRequest : IRequestInput { }

    public abstract class SynchronousRequestHandler<TRequest, TResponse> : RequestHandler<TRequest, TResponse> where TRequest : IRequestInput<TResponse> where TResponse : IRequestResponse { }

    public abstract class SynchronousRequestHandler<TRequest> : RequestHandler<TRequest> where TRequest : IRequestInput { }

    public abstract class NotificationRequestHandler<TNotificationRequest> : INotificationHandler<TNotificationRequest> where TNotificationRequest : INotificationtInput
    {
        public abstract Task Handle(TNotificationRequest notification, CancellationToken cancellationToken);
    }
}
