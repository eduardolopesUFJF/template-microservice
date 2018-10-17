using AutoMapper;
using $safeprojectname$.ViewModels;
using $saferootprojectname$.Domain.UsuarioRoot;

namespace $safeprojectname$.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioVM>();
        }
    }
}
