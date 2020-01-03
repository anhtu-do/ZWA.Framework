using MediatR;
using ZWA.Application.Core.Request.Payload;

namespace ZWA.Infrastructure.Core.RequestHandling.Handlers
{
    public interface IRequestInput<TResponse> : IBaseRequestInput, IRequest<TResponse> where TResponse : IBaseRequestOutput { }

    public interface IRequestInput : IBaseRequestInput, IRequest { }
   
}
