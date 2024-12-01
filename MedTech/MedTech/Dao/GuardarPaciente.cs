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

                Validar(paciente);

                string datosPaciente = Datos(paciente);

                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] datos = Encoding.UTF8.GetBytes(datosPaciente);
                    fs.Write(datos, 0, datos.Length);
                }

                string usuario = $"{paciente.IdPaciente:D4}";
                string contraseña = GenerarContraseña();
                GuardarUsuario(usuario, contraseña);
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
                || string.IsNullOrWhiteSpace(paciente.FechaNac)
                || string.IsNullOrWhiteSpace(paciente.IdPaciente))
                throw new Exception("Por favor, complete los campos obligatorios.");
        }

        public void Validar(Paciente paciente)
        {
            if (!int.TryParse(paciente.IdPaciente, out _))
                throw new Exception("Ingrese un valor válido para el ID.");
        }

        public string GenerarContraseña()
        {
            Random contraseña = new Random();
            return contraseña.Next(100000,999999).ToString("D6");
        }

        public void GuardarUsuario(string usuario, string contraseña)
        {
            string datosUsuario = $"\n{usuario}:{contraseña}";
            using (FileStream fs = new FileStream("usuarios.txt", FileMode.Append, FileAccess.Write))
            {
                byte[] datos = Encoding.UTF8.GetBytes(datosUsuario);
                fs.Write(datos, 0, datos.Length);
            }
        }

        public string Datos(Paciente paciente)
        {
            return $"ID Paciente: {paciente.IdPaciente}\n"
                   + $"Nombre: {paciente.Nombre}\n"
                   + $"Apellido: {paciente.Apellido}\n"
                   + $"Fecha de Nacimiento: {paciente.FechaNac}\n"
                   + $"Antecedentes:\n{paciente.Antecedentes}\n"
                   + $"Enfermedades:\n{paciente.Enfermedades}\n"
                   + $"Alergias: {paciente.Alergias}\n"
                   + $"Cirugias: {paciente.Cirugias}\n"
                   + "---------------------------------\n";
        }
    }
}
