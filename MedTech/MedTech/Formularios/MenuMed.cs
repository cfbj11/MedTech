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

namespace MedTech.Formularios
{
    public partial class MenuMed : MetroFramework.Forms.MetroForm
    {
        public MenuMed()
        {
            InitializeComponent();
        }

        private void btnAggRegCita_Click(object sender, EventArgs e)
        {
            AggRegCita aggRegCitaForm = new AggRegCita();
            aggRegCitaForm.Show();
            this.Close();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AggPaciente aggPacienteForm = new AggPaciente();
            aggPacienteForm.Show();
            this.Close();
        }

        private void btnExpedMed_Click(object sender, EventArgs e)
        {
            ExpedMed expedMedForm = new ExpedMed();
            expedMedForm.Show();
            this.Close();
        }

        private void btnCerrSesion_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "Está seguro que quiere cerrar sesión", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                InicioSesion inicioSesionForm = new InicioSesion();
                inicioSesionForm.Show();
                this.Close();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Agregar y Agendar Cita: Se agrega los datos del paciente y se agenda la cita según la disponibilidad del doctor y paciente.\nAgregar Paciente: Se ingresan los datos de un nuevo paciente dentro del sistema.\nCrear o Actualizar Expediente Médico: Se ingresan los datos de la cita del paciente dentro del sistema.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
