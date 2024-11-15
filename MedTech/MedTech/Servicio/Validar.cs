using MedTech.Formularios;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTech.Servicio
{
    public class Validar
    {
        private readonly Dictionary<string,string> cred;    //  Diccionario que almacena las credenciales
        private readonly Form form; //  Formulario de origen desde el cual se realiza el inicio de sesión

        //  Constructor de clase Validar
        public Validar(Form form, string filePath)
        {
            this.form = form;
            cred = new Dictionary<string,string>();
            CargarCred(filePath);   //  Cargar credenciales desde el archivo
        }

        //  Verifica las credenciales y permite el acceso al menú si son correctas
        public void AccederMenu(string user, string password, ref bool flag)
        {
            try
            {
                if (ValidarCred(user, password))    //  Valida las credenciales del usuario
                {
                    flag = false;
                    MostrarMenu();
                }
                else MsjError("Usuario o contraseña incorrectos. Inténtelo de nuevo."); //  Mensaje de error
            }
            catch (Exception ex)
            {
                MsjError(ex.Message);   //  Mensaje de error en caso de excepción
            }
        }

        //  Muestra el formulario del menú y oculta el formulario de inicio de sesión
        public void MostrarMenu()
        {
            MenuForm menuForm = new MenuForm(); //  Instancia del formulario de menú
            menuForm.Show();
            form.Hide();
        }

        //  Muestra mensaje de error
        public void MsjError(string msj)
        {
            MetroMessageBox.Show(form, msj, "Error de Inicio de Sesión.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //  Carga las credenciales desde el archivo especificado
        private void CargarCred(string filePath)
        {
            try
            {
                string[] lineas = File.ReadAllLines(filePath);  //  Leer todas las líneas del archivo
                foreach (string linea in lineas)
                {
                    ProcesarLinea(linea);
                }
            }
            catch (Exception ex)    //  Excepción en caso de error
            {
                throw new Exception($"Error al cargar el archivo: {ex.Message}");
            }
        }

        //  Procesa una línea de texto para extraer el usuario y la contraseña y los almacena en el diccionario
        private void ProcesarLinea(string linea)
        {
            string[] partes = linea.Split(':');
            if (partes.Length == 2)
            {
                string user = partes[0].Trim();
                string password = partes[1].Trim();
                cred[user] = password;  //  Almacena el usuario y la contraseña en el diccionario
            }
        }

        //  Valida si las credenciales proporcionadas coinciden con las almacenadas
        public bool ValidarCred(string user, string password)
        {
            return cred.TryGetValue(user, out string GPassword) && GPassword == password;
        }
    }
}
