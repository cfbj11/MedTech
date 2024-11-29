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
        private readonly Validar validar;
        private bool flag = true;
        private bool enseñar = false;

        public InicioFrm()
        {
            InitializeComponent();
            lblBienvenida.Select();
            validar = new Validar(this, "usuarios.txt");
        }

        private void pbContraseña_Click(object sender, EventArgs e)
        {
            enseñar = !enseñar;
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            validar.AccederMenu(tbUsuario.Text.Trim(), tbContraseña.Text.Trim(), ref flag);
        }

        private void InSesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }

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
