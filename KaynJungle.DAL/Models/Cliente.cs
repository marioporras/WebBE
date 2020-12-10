using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Propuesta = new HashSet<Propuesta>();
            Reparacion = new HashSet<Reparacion>();
            Vehiculo = new HashSet<Vehiculo>();
        }

        public int IdCliente { get; set; }
        public string Dni { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Comunidad { get; set; }
        public string Localidad { get; set; }
        public string CodPostal { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Propuesta> Propuesta { get; set; }
        public virtual ICollection<Reparacion> Reparacion { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
