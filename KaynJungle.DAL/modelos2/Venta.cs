using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.modelos2
{
    public partial class Venta
    {
        public int IdVendedor { get; set; }
        public int? IdCliente { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdVehiculo { get; set; }
        public DateTime? FechaSalida { get; set; }
        public float? Precio { get; set; }
        public string Matricula { get; set; }
        public string Presupuesto { get; set; }

        public Venta()
        {
           // Propuesta = new HashSet<Propuestas>();
            Vehiculo = new HashSet<Vehiculo>();
        }

        public int IdVentas { get; set; }
        public int UsuarioIdUsuario { get; set; }

        public virtual ICollection<Propuestas> Propuesta { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
