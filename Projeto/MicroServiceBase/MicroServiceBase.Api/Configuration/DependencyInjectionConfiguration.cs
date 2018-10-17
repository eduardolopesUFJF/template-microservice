using Microsoft.Extensions.DependencyInjection;
using MicroServiceBase.Infra.CrossCutting.IoC;

namespace MicroServiceBase.Api.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
           Injector.RegisterServices(services);
        }
    }
}
