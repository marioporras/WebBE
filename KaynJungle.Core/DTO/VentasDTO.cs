using System;

namespace KaynJungle.Core.DTO
{
    public class VentasDTO
    {
       
        public int Usuario_id { get; set; }
        
        public int Importe { get; set; }
        public int ConcesionarioIdConcesionario { get; set; }
        public VentasDTO() 
        { 
        }
    }
}
