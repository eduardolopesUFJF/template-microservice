using System.Collections.Generic;

namespace $safeprojectname$.UsuarioRoot.Service.Interfaces
{
    public interface IUsuarioService
    {
        void InserirUsuario(Usuario usuario);
        List<Usuario> GetAll();
    }
}
