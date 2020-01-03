using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ZWA.Infrastructure.Core
{
    public interface IBootstrapper
    {
        IServiceCollection Boot(IServiceCollection services, params Assembly[] assemblies);
    }
}
