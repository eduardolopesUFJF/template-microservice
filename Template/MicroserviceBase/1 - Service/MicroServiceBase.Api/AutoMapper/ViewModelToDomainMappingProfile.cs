using AutoMapper;
using $safeprojectname$.ViewModels;
using $saferootprojectname$.Domain.UsuarioRoot;

namespace $safeprojectname$.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
           CreateMap<UsuarioVM, Usuario>();
        }
    }
}
