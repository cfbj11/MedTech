using MedTech.Formularios;
using MedTech.Modelos;
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
        private readonly List<Usuario> usuarios;    //  Lista para almacenar los datos de los usuarios
        private readonly Form form; //  Formulario de origen desde el cual se realiza el inicio de sesión

        //  Constructor de clase Validar
        public Validar(Form form, string filePath)
        {
            this.form = form;
            usuarios = new List<Usuario>();
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
            MenuFrm menuForm = new MenuFrm(); //  Instancia del formulario de menú
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

        //  Procesa una línea de texto para extraer el usuario y la contraseña
        private void ProcesarLinea(string linea)
        {
            string[] partes = linea.Split(':');
            if (partes.Length == 2)
            {
                var usuario = new Usuario()
                {
                    IdUsuario = partes[0].Trim(),
                    Contraseña = partes[1].Trim()
                };
                usuarios.Add(usuario);  //  Agrega el usuario a la lista
            }
        }

        //  Valida si las credenciales proporcionadas coinciden con las almacenadas
        public bool ValidarCred(string user, string password)
        {
            return usuarios.Exists(u => u.IdUsuario == user && u.Contraseña == password);
        }
    }
}
