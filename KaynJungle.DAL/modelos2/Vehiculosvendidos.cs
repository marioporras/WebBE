using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.modelos2
{
    public partial class Vehiculosvendidos
    {
        public int Idvehiculosvendidos { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Asientos { get; set; }
        public string Tipo { get; set; }
        public string Fechabaja { get; set; }
        public string Precio { get; set; }
    }
}
