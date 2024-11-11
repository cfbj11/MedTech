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
    public partial class AggPaciente : MetroFramework.Forms.MetroForm
    {
        public AggPaciente()
        {
            InitializeComponent();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "¿Desea cancelar el ingreso del paciente al sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuMed menuMedForm = new MenuMed();
            menuMedForm.Show();
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbNombrePac.Clear();
            tbApellidoPac.Clear();
            dtFechaNac.Value = DateTime.Today;
            tbAntecedentes.Clear();
            tbEnfermedades.Clear();
            lbEnfermedades.Items.Clear();
            cbxAlergias.Checked = false;
            cbxCirugias.Checked = false;
        }
    }
}
