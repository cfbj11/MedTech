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
    public partial class MenuFrm : MetroFramework.Forms.MetroForm
    {
        private readonly AccForm menu;
        private string user;
        private bool flag = true;

        public MenuFrm(string user)
        {
            InitializeComponent();
            lblMedTech.Select();
            this.user = user;
            Ocultar();
            menu = new AccForm(this);
            timer1.Enabled = true;
        }

        public void Actualizar(string user)
        {
            this.user = user;
            Ocultar();
        }

        private void Ocultar()
        {
            if (int.TryParse(user, out int id))
            {
                bool visible = id <= 50;
                btnExped.Visible = visible;
                pbExpediente.Visible = visible;
                if (!visible)
                {
                    btnAggCita.Location = new Point(btnAggCita.Location.X, 220);
                    btnAggPaciente.Location = new Point(btnAggPaciente.Location.X, 176);
                    pbAggCita.Location = new Point(pbAggCita.Location.X, 130);
                    pbAggPaciente.Location = new Point(pbAggPaciente.Location.X, 176);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = $"{DateTime.Now:dd/MM/yy}\n{DateTime.Now:HH:mm:ss}";
        }

        private void btnAggRegCita_Click(object sender, EventArgs e)
        {
            menu.AgregarCita(ref flag, user);
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            menu.AgregarPaciente(ref flag, user);
        }

        private void btnExpedMed_Click(object sender, EventArgs e)
        {
            menu.ExpedMed(ref flag, user);
        }

        private void btnCerrSesion_Click(object sender, EventArgs e)
        {
            menu.CerrarSesion(ref flag);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            menu.CerrarSesion(ref flag);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            menu.Ayuda();
        }

        private void pbAyuda_Click(object sender, EventArgs e)
        {
            menu.Ayuda();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
