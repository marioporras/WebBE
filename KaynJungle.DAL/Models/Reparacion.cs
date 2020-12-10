using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.Models
{
    public partial class Reparacion
    {
        public int IdReparacion { get; set; }
        public int MecánicoIdMecánico { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
        public int ClienteIdCliente { get; set; }
        public int VehículosIdVehiculo { get; set; }

        public virtual Cliente ClienteIdClienteNavigation { get; set; }
        public virtual Mecanico MecánicoIdMecánicoNavigation { get; set; }
        public virtual Vehiculo VehículosIdVehiculoNavigation { get; set; }
    }
}
