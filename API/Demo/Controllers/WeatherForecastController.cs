using Demo.Application;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZWA.Application.Core.Request;
using ZWA.Application.Core.Request.Payload;

namespace Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IRequestDependenciesContainer<WeatherForecastController> _requestDependenciesContainer;

        public WeatherForecastController(IRequestDependenciesContainer<WeatherForecastController> requestDependenciesContainer)
        {
            _requestDependenciesContainer = requestDependenciesContainer;
        }

        [HttpGet]
        public async Task<IRequestResponse> Test()
        {
            //await _requestDependenciesContainer.Router.Send(new AsyncWithReturnTypeRequest());
            //await _requestDependenciesContainer.Router.Send(new AsyncReturnTaskRequest());
            // await _requestDependenciesContainer.Router.Send(new SyncReturnTypeRequest());
            await _requestDependenciesContainer.Router.Send(new SyncVoidRequest());

            return null;
        }
    }
}
