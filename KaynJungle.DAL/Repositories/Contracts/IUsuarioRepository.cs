using System;
using System.Collections.Generic;
using KaynJungle.Core.DTO;
namespace KaynJungle.DAL.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        bool Login(UsuarioDTO usuarioDTO);
        void Add(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
    }
}
