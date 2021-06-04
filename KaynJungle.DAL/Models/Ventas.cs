using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.Models
{
    public partial class Ventas
    {
       

        public Ventas()
        {
            Propuesta = new HashSet<Propuesta>();
            Vehiculo = new HashSet<Vehiculo>();
        }



        public int IdVentas { get; set; }
        public int UsuarioIdUsuario { get; set; }
        //public int ConcecionarioIdConcesionario { get; set; }

        public virtual ICollection<Propuesta> Propuesta { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
        public int ConcesionarioIdConcesionario { get;  set; }
        public int Importe { get; set; }
    }
}
