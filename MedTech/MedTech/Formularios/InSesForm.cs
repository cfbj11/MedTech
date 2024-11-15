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
    public partial class InSesForm : MetroFramework.Forms.MetroForm
    {
        private readonly Validar validar;
        private bool flag = true;

        public InSesForm()
        {
            InitializeComponent();
            lblBienvenida.Select();
            validar = new Validar(this, "usuarios.txt");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            validar.AccederMenu(tbUsuario.Text.Trim(), tbContraseña.Text.Trim(), ref flag);
        }

        private void InSesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
