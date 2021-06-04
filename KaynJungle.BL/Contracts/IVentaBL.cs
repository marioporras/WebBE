using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaynJungle.Core.DTO;

namespace KaynJungle.BL.Contracts
{
    public interface IVentaBL
    {
        IEnumerable<VentasDTO> Get();
    }
}

