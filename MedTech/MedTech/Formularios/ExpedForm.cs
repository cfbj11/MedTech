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
    public partial class ExpedForm : MetroFramework.Forms.MetroForm
    {
        private bool flag = true;
        public ExpedForm()
        {
            InitializeComponent();
            lblInstruccion.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "¿Desea cancelar la creación/actualización de expediente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            tbIdExped.Clear();
            tbNombrePac.Clear();
            tbApellidoPac.Clear();
            dtFecCita.Value = DateTime.Today;
            tbMotivoCon.Clear();
            tbDiagnostico.Clear();
        }

        private void ExpedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }
    }
}
