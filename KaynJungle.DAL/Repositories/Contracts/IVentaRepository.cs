using System.Collections.Generic;
using KaynJungle.Core.DTO;


namespace KaynJungle.DAL.Repositories.Contracts
{
    public interface IVentaRepository
    {
        IEnumerable<VentasDTO> Get();
    }
}
