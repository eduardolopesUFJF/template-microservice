using $safeprojectname$.UsuarioRoot.Repository;
using $safeprojectname$.UsuarioRoot.Service.Interfaces;
using System.Collections.Generic;

namespace $safeprojectname$.UsuarioRoot.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void InserirUsuario(Usuario usuario)
        {
            _usuarioRepository.InserirUsuario(usuario);
        }


        public List<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }
    }
}
