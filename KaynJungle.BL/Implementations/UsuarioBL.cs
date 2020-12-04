using System;
using KaynJungle.BL.Contracts;
using KaynJungle.Core.DTO;

namespace KaynJungle.BL.Implementations
{
    public class UsuarioBL : IUsuarioBL
    {
        public UsuarioBL()
        {
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO.Username == "sergio" && usuarioDTO.Password == "pilotes")
                return true;
            else
            {
                return false;
            }
        }
    }
}
