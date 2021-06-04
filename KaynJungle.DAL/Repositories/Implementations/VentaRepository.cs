using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaynJungle.Core.DTO;
using KaynJungle.DAL.Models;
using KaynJungle.DAL.Repositories.Contracts;

namespace KaynJungle.DAL.Repositories.Implementations
{
    public class VentaRepository: IVentaRepository
    {
        public ConcesionarioDBContext _context { get; set; }

        public VentaRepository(ConcesionarioDBContext context)
        {
            _context = context;
        }

       
        public IEnumerable<VentasDTO> Get()
        {
            var ventas = _context.Ventas.ToList();

            //Mapeo de Usuario a UsuarioDTO
            List<VentasDTO> ventasdto = new List<VentasDTO>();

            foreach (var v in ventas)
            {
                var venta = new VentasDTO
                {
                    Usuario_id = v.UsuarioIdUsuario,
                    Importe = v.Importe,
                    ConcesionarioIdConcesionario = v.ConcesionarioIdConcesionario
                    
                };
                ventasdto.Add(venta);
            }

            return ventasdto;

        }
    }
}

