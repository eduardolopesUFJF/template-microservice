using System.Collections.Generic;

namespace MicroServiceBase.Domain.UsuarioRoot.Service.Interfaces
{
    public interface IUsuarioService
    {
        void InserirUsuario(Usuario usuario);
        List<Usuario> GetAll();
    }
}
