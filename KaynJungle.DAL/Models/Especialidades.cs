using System;
using System.Collections.Generic;

namespace KaynJungle.DAL.Models
{
    public partial class Especialidades
    {
        public string EspecialidadEspecialidad { get; set; }
        public int MecánicoIdMecánico { get; set; }

        public virtual Especialidad EspecialidadEspecialidadNavigation { get; set; }
        public virtual Mecanico MecánicoIdMecánicoNavigation { get; set; }
    }
}
