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
    public partial class AggPacienteFrm : MetroFramework.Forms.MetroForm
    {
        private readonly AccForm accForms;
        private readonly GuardarPaciente guardarPaciente;
        private List<Paciente> listaPaciente = new List<Paciente>();
        private bool flag = true;

        public AggPacienteFrm()
        {
            InitializeComponent();
            accForms = new AccForm(this);
            guardarPaciente = new GuardarPaciente("PacienteRegistrados");
            lblInstruccion.Select();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            accForms.VerReporte();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEnfermedades.Text))
            {
                lbEnfermedades.Items.Add(tbEnfermedades.Text);
                tbEnfermedades.Clear();
                tbEnfermedades.Focus();
            }
            else MetroMessageBox.Show(this, "No hay nada por agregar.", "¡!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string enfermedades = string.Join(", ", lbEnfermedades.Items.Cast<string>());
                Paciente paciente = new Paciente()
                {
                    Nombre = tbNombrePac.Text,
                    Apellido = tbApellidoPac.Text,
                    FechaNac = dtFechaNac.Value.ToString("dd/MM/yyyy"),
                    Antecedentes = tbAntecedentes.Text,
                    Enfermedades = enfermedades,
                    Alergias = cbxAlergias.Checked ? "Sí" : "No",
                    Cirugias = cbxCirugias.Checked ? "Sí" : "No"
                };
                guardarPaciente.GuardarPac(paciente);
                listaPaciente.Add(paciente);
                dgvPaciente.DataSource = null;
                dgvPaciente.DataSource = listaPaciente;
                accForms.LimpiarCampos();
                MetroMessageBox.Show(this, "Paciente registrado exitosamente", "Paciente ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error al registrar al paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AggPacienteForm_FormClosing(object sender, FormClosingEventArgs e)
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
                dtFechaNac.Focus();
            }
        }

        private void dtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbAntecedentes.Focus();
            }
        }

        private void tbAntecedentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbEnfermedades.Focus();
            }
        }

        private void tbEnfermedades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAñadir.Focus();
            }
        }

        private void btnAñadir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbEnfermedades.Focus();
            }
        }

        private void cbxAlergias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (cbxAlergias != null)
                {
                    cbxAlergias.Checked = !cbxAlergias.Checked;
                    cbxCirugias.Focus();
                }
            }
        }

        private void cbxCirugias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (cbxCirugias != null)
                {
                    cbxCirugias.Checked = !cbxCirugias.Checked;
                    btnGuardar.Focus();
                }
            }
        }
    }
}
