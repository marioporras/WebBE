using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.Models
{
    public partial class Coche
    {
        public int Puertas { get; set; }
        public int Id { get; set; }
        public int VehiculosIdVehiculo { get; set; }

        public virtual Vehiculo VehiculosIdVehiculoNavigation { get; set; }
    }
}
