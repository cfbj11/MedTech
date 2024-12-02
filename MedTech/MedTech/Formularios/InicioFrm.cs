using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedTech.Servicio;

namespace MedTech.Formularios
{
    public partial class InicioFrm : MetroFramework.Forms.MetroForm
    {
        private readonly Validar validar;   //  Clase para validar el acceso al sistema
        private bool flag = true;   //  Bandera para controlar si la aplicación debe cerrarse
        private bool enseñar = false;   //  Indica si la contraseña debe mostrarse o debe estar oculta
        
        //  Constructor que inicializa formulario
        public InicioFrm()
        {
            InitializeComponent();
            lblBienvenida.Select();
            validar = new Validar(this, "usuarios.txt");
        }

        //  Evento que maneja si se muestra o se oculta la contraseña
        private void pbContraseña_Click(object sender, EventArgs e)
        {
            enseñar = !enseñar; //  Alternar entre mostrar y ocultar
            if (enseñar)
            {
                tbContraseña.PasswordChar = '\0';
                pbContraseña.Image = Properties.Resources.hide;
            }
            else
            {
                tbContraseña.PasswordChar = '*';
                pbContraseña.Image = Properties.Resources.show;
            }
        }

        //  Evento que maneja la validación de las credenciales
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            validar.AccederMenu(tbUsuario.Text.Trim(), tbContraseña.Text.Trim(), ref flag);
        }

        //  Evento de cierre del formulario
        private void InSesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }

        //  Métodos para manejar eventos que permiten la navegación por el formulario

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbContraseña.Focus();
            }
        }

        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSiguiente.Focus();
            }
        }
    }
}
