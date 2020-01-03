using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using ZWA.Application.Core.Request.Handlers;
using ZWA.Infrastructure.Core.RequestHandling.Handlers;

namespace ZWA.Infrastructure.Core.RequestHandling
{
    public class Bootstrapper : IBootstrapper
    {
        public IServiceCollection Boot(IServiceCollection services, params Assembly[] assemblies)
        {
            services.AddMediatR(assemblies);

            services.AddTransient<IApplicationRequestRouting, ApplicationRequestRouting>();

            return services;
        }
    }
}
