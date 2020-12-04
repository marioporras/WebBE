using System;
using KaynJungle.Core.DTO;

namespace KaynJungle.BL.Contracts
{
    public interface IUsuarioBL
    {
        bool Login(UsuarioDTO usuarioDTO);
    }
}
