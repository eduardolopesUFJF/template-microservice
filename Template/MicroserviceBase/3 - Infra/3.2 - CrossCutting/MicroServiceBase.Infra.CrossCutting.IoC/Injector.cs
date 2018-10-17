using Microsoft.Extensions.DependencyInjection;
using $saferootprojectname$.Domain.Core.Notifications;
using $saferootprojectname$.Domain.UsuarioRoot.Repository;
using $saferootprojectname$.Domain.UsuarioRoot.Service;
using $saferootprojectname$.Domain.UsuarioRoot.Service.Interfaces;
using $saferootprojectname$.Infra.Data.SqlServer.Context;
using $saferootprojectname$.Infra.Data.SqlServer.Repository;

namespace $safeprojectname$
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
