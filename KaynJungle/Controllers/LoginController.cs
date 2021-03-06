using System;
using KaynJungle.BL.Contracts;
using KaynJungle.Core.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KaynJungle.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController
    {
        public IUsuarioBL _usuarioBL { get; set; }

        public LoginController(IUsuarioBL pollo)
        {
            _usuarioBL = pollo;
        }

        [HttpPost]
        public bool Login(UsuarioDTO usuarioDTO)
        {
            return _usuarioBL.Login(usuarioDTO);
        }
    }
}
