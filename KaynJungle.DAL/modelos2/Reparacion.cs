using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.modelos2
{
    public partial class Reparacion
    {
        public int IdReparacion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdJefeMecanico { get; set; }
        public int? IdVehiculo { get; set; }
        public string FechaReparacion { get; set; }
        public float? Tiempo { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinalizacion { get; set; }
        public string Reparacioncol { get; set; }
    }
}
