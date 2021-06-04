using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.modelos2
{
    public partial class Jefemecanico
    {
        public int IdUsuario { get; set; }
        public string Seudonimo { get; set; }
        public string Contrasena { get; set; }
        public int? IdReparacion { get; set; }
        public string Clase { get; set; }
        public string Nombre { get; set; }
        public string Apeliidos { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
