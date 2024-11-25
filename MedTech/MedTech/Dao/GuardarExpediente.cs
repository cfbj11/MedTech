using MedTech.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTech.Dao
{
    internal class GuardarExpediente
    {
        private readonly string filePath;

        public GuardarExpediente(string filePath)
        {
            this.filePath = filePath;
        }

        public void Expediente(Expediente expediente)
        {
            try
            {
                CamposLlenos(expediente);

                Validar(expediente);

                string datosExped = Datos(expediente);

                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] datos = Encoding.UTF8.GetBytes(datosExped);
                    fs.Write(datos, 0, datos.Length);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CamposLlenos(Expediente expediente)
        {
            if (string.IsNullOrWhiteSpace(expediente.IdExpediente)
                || string.IsNullOrWhiteSpace(expediente.NombrePac)
                || string.IsNullOrWhiteSpace(expediente.ApellidoPac)
                || string.IsNullOrWhiteSpace(expediente.FechaCita)
                || string.IsNullOrWhiteSpace(expediente.Motivo)
                || string.IsNullOrWhiteSpace(expediente.Diagnostico))
                throw new Exception("Por favor, complete los campos obligatorios.");
        }

        public void Validar(Expediente expediente)
        {
            if (!int.TryParse(expediente.IdExpediente, out _))
                throw new Exception("Ingrese un valor válido.");
        }

        public string Datos(Expediente expediente)
        {
            return $"ID Expediente: {expediente.IdExpediente}\n"
                   + $"Nombre: {expediente.NombrePac}\n"
                   + $"Apellido: {expediente.ApellidoPac}\n"
                   + $"Fecha de Cita: {expediente.FechaCita}\n"
                   + $"Motivo de Consulta: \n{expediente.Motivo}\n"
                   + $"Diagnóstico: \n{expediente.Diagnostico}\n"
                   + "---------------------------------\n";
        }
    }
}
