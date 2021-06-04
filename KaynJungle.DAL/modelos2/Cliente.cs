using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.modelos2
{
    public partial class Cliente
    {
        public Cliente()
        {
            Vehiculo = new HashSet<Vehiculo>();
        }

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string FechaAlta { get; set; }
        public int IdCliente { get; set; }

        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
