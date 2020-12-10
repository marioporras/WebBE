using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaynJungle.BL.Contracts;
using KaynJungle.Core.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KaynJungle.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        public IUsuarioBL _usuarioBL { get; set; }

        public UsuarioController(IUsuarioBL pollo)
        {
            _usuarioBL = pollo;
        }

        [HttpPost]
        public ActionResult<bool> Add(UsuarioDTO usuarioDTO)
        {
            _usuarioBL.Add(usuarioDTO);
            return Ok(true);
        }

        public ActionResult<IEnumerable<UsuarioDTO>> Get()
        {
            return Ok(_usuarioBL.Get()) ;
        }
    }
}
