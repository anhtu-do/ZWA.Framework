using MediatR;

namespace ZWA.Application.Core.Request.Payload
{
    public interface IRequestInput<TResponse> : IRequest<TResponse> where TResponse : IRequestResponse { }

    public interface IRequestInput : IRequest { }

}
