using Microsoft.Extensions.DependencyInjection;
using MicroServiceBase.Domain.Core.Notifications;
using MicroServiceBase.Domain.UsuarioRoot.Repository;
using MicroServiceBase.Domain.UsuarioRoot.Service;
using MicroServiceBase.Domain.UsuarioRoot.Service.Interfaces;
using MicroServiceBase.Infra.Data.SqlServer.Context;
using MicroServiceBase.Infra.Data.SqlServer.Repository;

namespace MicroServiceBase.Infra.CrossCutting.IoC
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Service
            services.AddScoped<IUsuarioService, UsuarioService>();

            //Infra Data
            services.AddScoped<ServiceContext>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<NotificationHandler>();
        }
    }
}
