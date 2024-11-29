using MedTech.Dao;
using MedTech.Modelos;
using MedTech.Servicio;
using MetroFramework;
using Microsoft.Reporting.WinForms;
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
        private List<Cita> listaCitas = new List<Cita>();
        private bool flag = true;

        public AggCitaFrm()
        {
            InitializeComponent();
            accForms = new AccForm(this);
            guardarCita = new GuardarCita("CitasRegistradas.txt");
            lblInstruccion.Select();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            accForms.VerReporte();
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
                listaCitas.Add(cita);
                dgvCita.DataSource = null;
                dgvCita.DataSource = listaCitas;
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

        private void tbNombrePac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbApellidoPac.Focus();
            }
        }

        private void tbApellidoPac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                dtFechaCita.Focus();
            }
        }

        private void dtFechaCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbHoraCita.Focus();
            }
        }

        private void tbHoraCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbIdPaciente.Focus();
            }
        }

        private void tbIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbDoctor.Focus();
            }
        }

        private void tbDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cbEspecialidad.Focus();
            }
        }

        private void cbEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cbxTelefono.Focus();
            }
        }

        private void cbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (cbxTelefono != null)
                {
                    cbxTelefono.Checked = !cbxTelefono.Checked;
                    cbxCorreo.Focus();
                }
            }
        }

        private void cbxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (cbxCorreo != null)
                {
                    cbxCorreo.Checked = !cbxCorreo.Checked;
                    tbContacto.Focus();
                }
            }
        }

        private void tbContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbCosto.Focus();
            }
        }

        private void tbCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGuardar.Focus();
            }
        }
    }
}
