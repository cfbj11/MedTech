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
        private bool flag = true;

        public AggPacienteFrm()
        {
            InitializeComponent();
            accForms = new AccForm(this);
            guardarPaciente = new GuardarPaciente("PacienteRegistrados");
            lblInstruccion.Select();
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
    }
}
