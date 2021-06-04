using System;
namespace KaynJungle.Core.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public string Apellidos { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }
        //public int Id { get; set; }
        public int ConcesionarioIdConcesionario { get; set; }

        public UsuarioDTO()
        {
        }
    }
}
