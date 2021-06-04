using System;
using System.Collections.Generic;
using KaynJungle.BL.Contracts;
using KaynJungle.Core.DTO;
using KaynJungle.DAL.Repositories.Contracts;

namespace KaynJungle.BL.Implementations
{
    public class UsuarioBL : IUsuarioBL
    {

        public IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioBL(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {
           return _usuarioRepository.Login(usuarioDTO);
        }

        public void Add(UsuarioDTO usuarioDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioDTO> Get()
        {
            throw new NotImplementedException();
        }

        //  public void Add(UsuarioDTO usuarioDTO)
        //{
        // _usuarioRepository.Add(usuarioDTO);
        //}

        //  public IEnumerable<UsuarioDTO> Get()
        // {
        // var usuarios = _usuarioRepository.Get();
        //     return usuarios;
        //}
    }
}
