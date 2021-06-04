using System;
using System.Collections.Generic;
using System.Linq;
using KaynJungle.Core.DTO;
using KaynJungle.DAL.Models;
using KaynJungle.DAL.Repositories.Contracts;

namespace KaynJungle.DAL.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public ConcesionarioDBContext _context { get; set; }

        public UsuarioRepository(ConcesionarioDBContext context)
        {
            _context = context;
        }

        public bool Login(UsuarioDTO usuarioDTO) {
            if (_context.Usuario.Any(u => u.User == usuarioDTO.Username &&
                          u.Password == usuarioDTO.Password)){
                return true;
            }else return false;

        }

      

          public IEnumerable<UsuarioDTO> Get()
        {
             var usuarios = _context.Usuario.ToList();

    //Mapeo de Usuario a UsuarioDTO

   List<UsuarioDTO> usuariosdto = new List<UsuarioDTO>();

        foreach(var u in usuarios)
        {
   var usuario = new UsuarioDTO
          {
            IdUsuario = u.IdUsuario,
             Username = u.User,
       Password = u.Password,
       Email = u.Email,
       Apellidos = u.Apellidos,
             Name = u.Name,
            Rol = u.Rol,
            ConcesionarioIdConcesionario = u.ConcesionarioIdConcesionario
     };
    usuariosdto.Add(usuario);
    }

      return usuariosdto;

    }
}
}
