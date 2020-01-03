using MediatR;
using ZWA.Application.Core.Request.Payload;

namespace ZWA.Infrastructure.Core.RequestHandling.Payload
{
    public interface INotificationtInput : IBaseNotificationInput, INotification { }
}
