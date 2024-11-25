using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTech.Modelos
{
    internal class Cita
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string IdPaciente { get; set; }
        public string FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string Doctor { get; set; }
        public string Especialidad { get; set; }
        public string Contacto { get; set; }
        public string TipoContacto { get; set; }
        public string CostoConsulta { get; set; }
    }
}
