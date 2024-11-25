using MedTech.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTech.Dao
{
    internal class GuardarCita
    {
        private readonly string filePath;

        public GuardarCita(string filePath)
        {
            this.filePath = filePath;
        }

        public void Guardar(Cita cita)
        {
            try
            {
                CamposLlenos(cita);

                Validar(cita);

                string datosCita = Datos(cita);

                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] datos = Encoding.UTF8.GetBytes(datosCita);
                    fs.Write(datos, 0, datos.Length);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Validar(Cita cita)
        {
            if (!TimeSpan.TryParseExact(cita.HoraCita, @"hh\:mm", null, out TimeSpan _))
                throw new Exception("Ingrese una hora válida.");
            else if (!int.TryParse(cita.IdPaciente, out _))
                throw new Exception("Ingrese un ID de Paciente válido.");
            else if (cita.TipoContacto == "Teléfono" && !cita.Contacto.All(char.IsDigit))
                throw new Exception("Ingrese un número de teléfono válido.");
            else if (cita.TipoContacto == "Correo" && (!cita.Contacto.Contains("@") || !cita.Contacto.Contains(".")))
                throw new Exception("Ingrese un correo electrónico válido.");
            else if (!int.TryParse(cita.CostoConsulta, out _))
                throw new Exception("Ingrese un valor válido para el costo.");
        }

        public string Datos(Cita cita)
        {
            return $"Nombre: {cita.Nombre}\n"
                   + $"Apellido: {cita.Apellido}\n"
                   + $"ID Paciente: {cita.IdPaciente}\n"
                   + $"Doctor: {cita.Doctor}\n"
                   + $"Fecha de Cita: {cita.FechaCita}\n"
                   + $"Hora de Cita: {cita.HoraCita}\n"
                   + $"Especialidad: {cita.Especialidad}\n"
                   + $"Contacto: {cita.Contacto}\n"
                   + $"Costo de la Consulta: {cita.CostoConsulta}\n"
                   + "---------------------------------\n";
        }

        public void CamposLlenos(Cita cita)
        {
            if (string.IsNullOrWhiteSpace(cita.Nombre)
                || string.IsNullOrWhiteSpace(cita.Apellido)
                || string.IsNullOrWhiteSpace(cita.IdPaciente)
                || string.IsNullOrWhiteSpace(cita.Doctor)
                || string.IsNullOrWhiteSpace(cita.FechaCita)
                || string.IsNullOrWhiteSpace(cita.HoraCita)
                || string.IsNullOrWhiteSpace(cita.Especialidad)
                || string.IsNullOrWhiteSpace(cita.Contacto)
                || string.IsNullOrWhiteSpace(cita.TipoContacto)
                || string.IsNullOrWhiteSpace(cita.CostoConsulta))
                throw new Exception("Por favor, complete los campos obligatorios.");
        }
    }
}
