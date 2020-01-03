using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using ZWA.Application.Core.Request;

namespace ZWA.Application.Core
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterCoreAppComponents(this IServiceCollection container, params Assembly[] assemblies)
        {
            if (assemblies == null || !assemblies.Any())
            {
                throw new Exception("Configuration assemblies are missing");
            }
            
            container.AddTransient(typeof(IRequestDependenciesContainer<>), typeof(RequestDependenciesContainer<>));
            
            container.AddMediatR(assemblies);

            return container;
        }
    }
}
