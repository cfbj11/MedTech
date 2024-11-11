using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTech.Servicio
{
    public class Validar
    {
        private readonly Dictionary<string,string> cred;

        public Validar(string filePath)
        {
            cred = new Dictionary<string,string>();
            CargarCred(filePath);
        }

        private void CargarCred(string filePath)
        {
            try
            {
                string[] lineas = File.ReadAllLines(filePath);
                foreach (string linea in lineas)
                {
                    ProcesarLinea(linea);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar el archivo: {ex.Message}");
            }
        }

        private void ProcesarLinea(string linea)
        {
            string[] partes = linea.Split(':');
            if (partes.Length == 2)
            {
                string user = partes[0].Trim();
                string password = partes[1].Trim();
                cred[user] = password;
            }
        }

        public bool ValidarCred(string user, string password)
        {
            return cred.TryGetValue(user, out string strPassword) && strPassword == password;
        }
    }
}
