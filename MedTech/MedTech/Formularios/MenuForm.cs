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
    public partial class MenuForm : MetroFramework.Forms.MetroForm
    {
        private readonly AccForms menu;
        private bool flag = true;

        public MenuForm()
        {
            InitializeComponent();
            lblMedTech.Select();
            menu = new AccForms(this);
        }

        private void btnAggRegCita_Click(object sender, EventArgs e)
        {
            menu.AgregarCita(ref flag);
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            menu.AgregarPaciente(ref flag);
        }

        private void btnExpedMed_Click(object sender, EventArgs e)
        {
            menu.ExpedMed(ref flag);
        }

        private void btnCerrSesion_Click(object sender, EventArgs e)
        {
            menu.CerrarSesion(ref flag);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            menu.Ayuda();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
