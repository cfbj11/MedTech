using MedTech.Dao;
using MedTech.Modelos;
using MedTech.Servicio;
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
    public partial class AggCitaFrm : MetroFramework.Forms.MetroForm
    {
        private readonly AccForm accForms;
        private readonly GuardarCita guardarCita;
        private bool flag = true;

        public AggCitaFrm()
        {
            InitializeComponent();
            accForms = new AccForm(this);
            guardarCita = new GuardarCita("CitasRegistradas.txt");
            lblInstruccion.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cita cita = new Cita()
                {
                    Nombre = tbNombrePac.Text,
                    Apellido = tbApellidoPac.Text,
                    IdPaciente = tbIdPaciente.Text,
                    Doctor = tbDoctor.Text,
                    FechaCita = dtFechaCita.Value.ToString("dd/MM/yyyy"),
                    HoraCita = tbHoraCita.Text,
                    Especialidad = cbEspecialidad.SelectedItem?.ToString() ?? "",
                    Contacto = tbContacto.Text,
                    TipoContacto = cbxTelefono.Checked ? "Teléfono" : cbxCorreo.Checked ? "Correo" : null,
                    CostoConsulta = tbCosto.Text,
                };
                guardarCita.Guardar(cita);
                accForms.LimpiarCampos();
                MetroMessageBox.Show(this, "Cita registrada exitosamente", "Cita agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error al guardar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accForms.Cancelar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            accForms.Volver(ref flag);
        }

        private void AggCitaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
