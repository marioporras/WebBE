    using System;
    using System.Collections.Generic;
    using System.Linq;
    using KaynJungle.BL.Contracts;
    using KaynJungle.Core.DTO;
    using KaynJungle.DAL.Models;
    using KaynJungle.DAL.Repositories.Contracts;

namespace KaynJungle.BL.Implementations
    {
    public class VentaBL : IVentaBL
        {

            public IVentaRepository _ventaRepository { get; set; }
            public IUsuarioRepository _usuarioRepository { get; set; }
            List<VentasDTO> ventasFinales = new List<VentasDTO>();
        public VentaBL(IVentaRepository ventaRepository, IUsuarioRepository usuarioRepository)
            {
                _ventaRepository = ventaRepository;
                _usuarioRepository = usuarioRepository;
            }

    
            public IEnumerable<VentasDTO> Get()
            {
            var ventas = _ventaRepository.Get();
            //return (IEnumerable<VentasDTO>)ventas;

            foreach (var v in ventas)
            {
                if (!ventasFinales.Any(venta => venta.Usuario_id == v.Usuario_id))
                {
                    ventasFinales.Add(v);
                }
                else
                {
                    ventasFinales.FirstOrDefault(venta => venta.Usuario_id == v.Usuario_id).Importe += v.Importe;
                }
            }

            return ventasFinales;
        }
    }



}
      