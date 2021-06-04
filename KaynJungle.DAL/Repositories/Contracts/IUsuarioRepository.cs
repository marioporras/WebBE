using System;
using System.Collections.Generic;
using KaynJungle.Core.DTO;
namespace KaynJungle.DAL.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        bool Login(UsuarioDTO usuarioDTO);
        //void Add(UsuarioDTO usuarioDTO);
        IEnumerable<UsuarioDTO> Get();
        //dotnet ef dbcontext scaffold "server=localhost;port=3306;user=root;password=1234546;database=elproyecto" MySql.Data:EntityFrameworkCore -o modelos2
    }
}
