using System.Collections.Generic;

namespace MicroServiceBase.Domain.UsuarioRoot.Repository
{
    public interface IUsuarioRepository
    {
        void InserirUsuario(Usuario usuario);
        List<Usuario> GetAll();
        bool ValidarNomeUsuario(string nomeUsuario);
    }
}
