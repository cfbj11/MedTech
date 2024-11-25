using MedTech.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTech.Dao
{
    internal class GuardarPaciente
    {
        private readonly string filePath;

        public GuardarPaciente(string filePath)
        {
            this.filePath = filePath;
        }

        public void GuardarPac(Paciente paciente)
        {
            try
            {
                CamposLlenos(paciente);

                string datosPaciente = Datos(paciente);

                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] datos = Encoding.UTF8.GetBytes(datosPaciente);
                    fs.Write(datos, 0, datos.Length);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CamposLlenos(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Nombre)
                || string.IsNullOrWhiteSpace(paciente.Apellido)
                || string.IsNullOrWhiteSpace(paciente.FechaNac))
                throw new Exception("Por favor, complete los campos obligatorios.");
        }

        public string Datos(Paciente paciente)
        {
            return $"Nombre: {paciente.Nombre}\n"
                   + $"Apellido: {paciente.Apellido}\n"
                   + $"ID Paciente: {paciente.Apellido}\n"
                   + $"Fecha de Nacimiento: {paciente.FechaNac}\n"
                   + $"Antecedentes:\n{paciente.Antecedentes}\n"
                   + $"Enfermedades:\n{paciente.Enfermedades}\n"
                   + $"Alergias: {paciente.Alergias}\n"
                   + $"Cirugias: {paciente.Cirugias}\n"
                   + "---------------------------------\n";
        }
    }
}
