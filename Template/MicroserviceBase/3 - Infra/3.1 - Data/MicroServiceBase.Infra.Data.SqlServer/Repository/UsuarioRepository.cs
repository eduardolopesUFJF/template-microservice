using $saferootprojectname$.Domain.UsuarioRoot;
using $saferootprojectname$.Domain.UsuarioRoot.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace $safeprojectname$.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context.ServiceContext _serviceBContext;

        public UsuarioRepository(Context.ServiceContext serviceBContext)
        {
            _serviceBContext = serviceBContext;
        }

        public void InserirUsuario(Usuario usuario)
        {
            try
            {
                _serviceBContext.Usuarios.Add(usuario);
                var commit = _serviceBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                return _serviceBContext.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidarNomeUsuario(string nomeUsuario)
        {
            return _serviceBContext.Usuarios.Any(x => x.Nome == nomeUsuario);
        }
    }
}
