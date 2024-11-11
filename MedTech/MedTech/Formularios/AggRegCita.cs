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
    public partial class AggRegCita : MetroFramework.Forms.MetroForm
    {
        public AggRegCita()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "¿Desea cancelar la agendación de cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            tbNombre.Clear();
            tbApellido.Clear();
            tbHora.Clear();
            dtFecha.Value = DateTime.Today;
            tbNombreDoc.Clear();
            cbxTelefono.Checked = false;
            cbxCorreo.Checked = false;
            tbCosto.Clear();
        }
    }
}
