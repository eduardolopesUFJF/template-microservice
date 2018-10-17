using AutoMapper;
using MicroServiceBase.Api.ViewModels;
using MicroServiceBase.Domain.UsuarioRoot;

namespace MicroServiceBase.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
           CreateMap<UsuarioVM, Usuario>();
        }
    }
}
