using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.modelos2
{
    public partial class Vehiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Precio { get; set; }
        public string FechaAlta { get; set; }
        public string TipoVehiculo { get; set; }
        public int IdVehiculo { get; set; }
        public int? IdCliente { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdConcesionario { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
