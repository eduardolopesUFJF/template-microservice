using AutoMapper;
using MicroServiceBase.Api.ViewModels;
using MicroServiceBase.Domain.UsuarioRoot;

namespace MicroServiceBase.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioVM>();
        }
    }
}
