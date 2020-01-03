using ZWA.Application.Core.Request.Payload;

namespace Demo.Application
{
    public class ResponseBaseModel : IRequestResponse
    {

    }

    public class Data : INotificationtInput
    {

    }

    public class AsyncWithReturnTypeRequest : IRequestInput<ResponseBaseModel>
    {

    }

    public class AsyncReturnTaskRequest : IRequestInput
    {

    }

    public class SyncReturnTypeRequest : IRequestInput<ResponseBaseModel>
    {

    }

    public class SyncVoidRequest : IRequestInput
    {

    }
}
