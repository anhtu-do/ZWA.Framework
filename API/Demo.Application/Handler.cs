using System.Threading;
using System.Threading.Tasks;
using ZWA.Application.Core.Request;
using ZWA.Application.Core.Request.Handlers;

namespace Demo.Application
{
    public class AsyncWithReturnTypeHandler : AsynchronousRequestHandler<AsyncWithReturnTypeRequest, ResponseBaseModel>
    {
        public override async Task<ResponseBaseModel> Handle(AsyncWithReturnTypeRequest request, CancellationToken cancellationToken)
        {
            // Implement your logic code in here
            return new ResponseBaseModel();
        }

    }

    public class AsyncReturnTaskHandler : AsynchronousRequestHandler<AsyncReturnTaskRequest>
    {
        protected override async Task Handle(AsyncReturnTaskRequest request, CancellationToken cancellationToken)
        {
            // Implement your logic code in here
        }
    }

    public class SyncReturnTypeHandler : SynchronousRequestHandler<SyncReturnTypeRequest, ResponseBaseModel>
    {
        protected override ResponseBaseModel Handle(SyncReturnTypeRequest request)
        {
            // Implement your logic code in here
            return new ResponseBaseModel();
        }
    }

    public class SyncVoidHandler : SynchronousRequestHandler<SyncVoidRequest>
    {
        protected override void Handle(SyncVoidRequest request)
        {
            // Implement your logic code in here
        }
    }
    
    public class AsyncNotificationHandler : SynchronousRequestHandler<SyncVoidRequest>
    {
        private readonly IRequestDependenciesContainer<AsyncNotificationHandler> _requestDependenciesContainer;
        public AsyncNotificationHandler(IRequestDependenciesContainer<AsyncNotificationHandler> requestDependenciesContainer)
        {
            _requestDependenciesContainer = requestDependenciesContainer;
        }
        protected override void Handle(SyncVoidRequest request)
        {
            // Implement your logic code in here
            _requestDependenciesContainer.Router.Publish(new Data());
        }
    }

    public class Notification1 : NotificationRequestHandler<Data>
    {
        public override async Task Handle(Data notification, CancellationToken cancellationToken)
        {
        }
    }

    public class Notification2 : NotificationRequestHandler<Data>
    {
        public override async Task Handle(Data notification, CancellationToken cancellationToken)
        {
        }
    }
}
