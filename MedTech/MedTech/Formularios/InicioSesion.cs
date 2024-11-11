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
    public partial class InicioSesion : MetroFramework.Forms.MetroForm
    {
        private readonly Validar validar;
        public InicioSesion()
        {
            InitializeComponent();
            validar = new Validar("usuarios.txt");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string user = tbUsuario.Text.Trim();
            string password = tbContraseña.Text.Trim();

            try
            {
                if (validar.ValidarCred(user, password))
                {
                    MenuMed menuForm = new MenuMed();
                    menuForm.Show();
                    this.Hide();
                }
                else MetroMessageBox.Show(this, "Usuario o contraseña incorrectos. Inténtelo de nuevo.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
