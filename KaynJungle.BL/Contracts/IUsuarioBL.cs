using System;
using System.Collections.Generic;
using KaynJungle.Core.DTO;

namespace KaynJungle.BL.Contracts
{
    public interface IUsuarioBL
    {
        bool Login(UsuarioDTO usuarioDTO);
        //void Add(UsuarioDTO usuarioDTO);
        //IEnumerable<UsuarioDTO> Get();
    }
}
