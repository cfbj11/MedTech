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
    public partial class ExpedienteFrm : MetroFramework.Forms.MetroForm
    {
        private readonly AccForm accForms;
        private readonly GuardarExpediente guardarExpediente;
        private List<Expediente> listaExpediente = new List<Expediente>();
        private string user;
        private bool flag = true;

        public ExpedienteFrm(string user)
        {
            InitializeComponent();
            this.user = user;
            accForms = new AccForm(this);
            guardarExpediente = new GuardarExpediente("Expedientes.txt");
            lblInstruccion.Select();
        }

        public DataTable DatosExpediente()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("IdExpediente");
            dt.Columns.Add("NombrePac");
            dt.Columns.Add("ApellidoPac");
            dt.Columns.Add("FechaCita");
            dt.Columns.Add("Motivo");
            dt.Columns.Add("Diagnostico");

            foreach (DataGridViewRow fila in dgvExpediente.Rows)
            {
                if (!fila.IsNewRow)
                {
                    DataRow dr = dt.NewRow();

                    dr["IdExpediente"] = fila.Cells["IdExpediente"].Value.ToString();
                    dr["NombrePac"] = fila.Cells["NombrePac"].Value.ToString();
                    dr["ApellidoPac"] = fila.Cells["ApellidoPac"].Value.ToString();
                    dr["FechaCita"] = fila.Cells["FechaCita"].Value;
                    dr["Motivo"] = fila.Cells["Motivo"].Value.ToString();
                    dr["Diagnostico"] = fila.Cells["Diagnostico"].Value.ToString();

                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            accForms.VerReporte();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Expediente expediente = new Expediente()
                {
                    IdExpediente = tbIdExped.Text,
                    NombrePac = tbNombrePac.Text,
                    ApellidoPac = tbApellidoPac.Text,
                    FechaCita = dtFechaCita.Value.ToString("dd/MM/yyyy"),
                    Motivo = tbMotivoCon.Text,
                    Diagnostico = tbDiagnostico.Text
                };
                guardarExpediente.Expediente(expediente);
                listaExpediente.Add(expediente);
                dgvExpediente.DataSource = null;
                dgvExpediente.DataSource = listaExpediente;
                accForms.LimpiarCampos();
                MetroMessageBox.Show(this, "Expediente creado/actualizado exitosamente", "Expediente Creado/Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accForms.Cancelar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            accForms.Volver(ref flag, user);
        }

        private void ExpedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }

        private void tbIdExped_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbNombrePac.Focus();
            }
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
                tbMotivoCon.Focus();
            }
        }

        private void tbMotivoCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbDiagnostico.Focus();
            }
        }

        private void tbDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGuardar.Focus();
            }
        }
    }
}
