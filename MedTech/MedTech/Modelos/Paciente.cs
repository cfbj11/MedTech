using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTech.Modelos
{
    internal class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNac { get; set; }
        public string Antecedentes { get; set; }
        public string Enfermedades { get; set; }
        public string Alergias { get; set; }
        public string Cirugias { get; set; }
    }
}
