using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTech.Modelos
{
    internal class Expediente
    {
        public string IdExpediente { get; set; }
        public string NombrePac { get; set; }
        public string ApellidoPac { get; set; }
        public string FechaCita { get; set; }
        public string Motivo { get; set; }
        public string Diagnostico { get; set; }
    }
}
