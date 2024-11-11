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
    public partial class AggCitaForm : MetroFramework.Forms.MetroForm
    {
        private bool flag = true;
        public AggCitaForm()
        {
            InitializeComponent();
            lblInstruccion.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "¿Desea cancelar la agendación de cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            flag = false;
            MenuForm menuMedForm = new MenuForm();
            menuMedForm.Show();
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            dtFecha.Value = DateTime.Today;
            tbHora.Clear();
            tbIdPaciente.Clear();
            tbNombreDoc.Clear();
            cbEspecialidad.SelectedIndex = -1;
            cbxTelefono.Checked = false;
            cbxCorreo.Checked = false;
            tbContacto.Clear();
            tbCosto.Clear();
        }

        private void AggCitaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
