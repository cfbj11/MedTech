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
    public partial class MenuForm : MetroFramework.Forms.MetroForm
    {
        private bool flag = true;
        public MenuForm()
        {
            InitializeComponent();
            lblMedTech.Select();
        }

        private void btnAggRegCita_Click(object sender, EventArgs e)
        {
            flag = false;
            AggCitaForm aggRegCitaForm = new AggCitaForm();
            aggRegCitaForm.Show();
            this.Hide();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            flag = false;
            AggPacienteForm aggPacienteForm = new AggPacienteForm();
            aggPacienteForm.Show();
            this.Hide();
        }

        private void btnExpedMed_Click(object sender, EventArgs e)
        {
            flag = false;
            ExpedForm expedMedForm = new ExpedForm();
            expedMedForm.Show();
            this.Hide();
        }

        private void btnCerrSesion_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "Está seguro que quiere cerrar sesión", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                flag = false;
                InSesForm inicioSesionForm = new InSesForm();
                inicioSesionForm.Show();
                this.Close();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string aggCita = "Se agrega los datos del paciente y se agenda la cita según la disponibilidad del doctor y paciente.";
            string aggPac = "Se ingresan los datos de un nuevo paciente dentro del sistema.";
            string expedMed = "Se ingresan los datos de la cita del paciente dentro del sistema.";
            MetroMessageBox.Show(this, $"Agregar y Agendar Cita: {aggCita}\nAgregar Paciente: {aggPac}\nCrear o Actualizar Expediente Médico: {expedMed}", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
