using Microsoft.Extensions.DependencyInjection;
using $saferootprojectname$.Infra.CrossCutting.IoC;

namespace $safeprojectname$.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
           Injector.RegisterServices(services);
        }
    }
}
