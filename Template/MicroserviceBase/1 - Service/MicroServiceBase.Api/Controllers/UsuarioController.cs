using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using $safeprojectname$.ViewModels;
using $saferootprojectname$.Domain.UsuarioRoot;
using $saferootprojectname$.Domain.UsuarioRoot.Service.Interfaces;
using System;

namespace $safeprojectname$.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioVM usuarioVM)
        {
            try
            {
                Usuario usuario = Mapper.Map<Usuario>(usuarioVM);
                _usuarioService.InserirUsuario(usuario);

                return Ok(true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var usuariosVM = _usuarioService.GetAll();
                return Ok(usuariosVM);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
