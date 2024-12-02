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
        private readonly AccForm menu;  //  Instancia para manejar acciones comunes del menú
        private string user;    //  Usuario actual
        private bool flag = true;   //  Bandera para controlar si la aplicación debe cerrarse

        //  Constructor que inicializa el formulario
        public MenuFrm(string user)
        {
            InitializeComponent();
            lblMedTech.Select();
            this.user = user;
            Ocultar();
            menu = new AccForm(this);
            timer1.Enabled = true;
        }

        //  Actualiza la información del usuario y ajusta la visibilidad de los elementos del menú
        public void Actualizar(string user)
        {
            this.user = user;
            Ocultar();
        }

        //  Ajusta la visibilidad y posición de los elementos del menú según el identificador del usuario.
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

        //  Actualiza la etiqueta de fecha y hora con la hora actual
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = $"{DateTime.Now:dd/MM/yy}\n{DateTime.Now:HH:mm:ss}";
        }

        //  Abre formulario para agregar cita
        private void btnAggRegCita_Click(object sender, EventArgs e)
        {
            menu.AgregarCita(ref flag, user);
        }

        //  Abre formulario para agregar paciente
        private void btnPaciente_Click(object sender, EventArgs e)
        {
            menu.AgregarPaciente(ref flag, user);
        }

        //  Abre formulario para gestionar expedientes
        private void btnExpedMed_Click(object sender, EventArgs e)
        {
            menu.ExpedMed(ref flag, user);
        }

        //  Cierra sesión
        private void btnCerrSesion_Click(object sender, EventArgs e)
        {
            menu.CerrarSesion(ref flag);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            menu.CerrarSesion(ref flag);
        }

        //  Abre información de ayuda
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            menu.Ayuda();
        }

        private void pbAyuda_Click(object sender, EventArgs e)
        {
            menu.Ayuda();
        }

        //  Evento de cierre del formulario
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
