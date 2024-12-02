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
        private readonly string filePath;   //  Ruta del archivo donde se almacenarán los expedientes

        //  Constructor que inicializa la ruta del archivo
        public GuardarExpediente(string filePath)
        {
            this.filePath = filePath;
        }

        //  Guarda un expediente médico en el archivo
        public void Expediente(Expediente expediente)
        {
            try
            {
                CamposLlenos(expediente);

                Validar(expediente);

                string datosExped = Datos(expediente);

                //  Escribir los datos del expediente en el archivo
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

        //  Verifica que todos los campos requeridos del expediente están llenos
        public void CamposLlenos(Expediente expediente)
        {
            if (string.IsNullOrWhiteSpace(expediente.IdExpediente)
                || string.IsNullOrWhiteSpace(expediente.NombrePac)
                || string.IsNullOrWhiteSpace(expediente.ApellidoPac)
                || string.IsNullOrWhiteSpace(expediente.FechaCita)
                || string.IsNullOrWhiteSpace(expediente.Motivo)
                || string.IsNullOrWhiteSpace(expediente.Diagnostico))
                throw new Exception("Por favor, complete todos los campos.");
        }

        //  Valida los campos específicos del expediente para asegurarse que cumplen los formatos esperados
        public void Validar(Expediente expediente)
        {
            if (!int.TryParse(expediente.IdExpediente, out _))
                throw new Exception("Ingrese un valor válido para el ID Expediente.");
        }

        //  Genera una representación de los datos del expediente médico
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
