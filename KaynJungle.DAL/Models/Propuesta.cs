using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.Models
{
    public partial class Propuesta
    {
        public int Idpropuesta { get; set; }
        public int ClienteIdCliente { get; set; }
        public int VentasIdVentas { get; set; }
        public int Precio { get; set; }
        public byte Estado { get; set; }
        public int VehículosIdVehiculo { get; set; }

        public virtual Cliente ClienteIdClienteNavigation { get; set; }
        public virtual Vehiculo VehículosIdVehiculoNavigation { get; set; }
        public virtual Ventas VentasIdVentasNavigation { get; set; }
    }
}
