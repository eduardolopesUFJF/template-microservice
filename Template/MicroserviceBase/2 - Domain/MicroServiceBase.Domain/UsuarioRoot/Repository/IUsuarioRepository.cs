using System.Collections.Generic;

namespace $safeprojectname$.UsuarioRoot.Repository
{
    public interface IUsuarioRepository
    {
        void InserirUsuario(Usuario usuario);
        List<Usuario> GetAll();
        bool ValidarNomeUsuario(string nomeUsuario);
    }
}
