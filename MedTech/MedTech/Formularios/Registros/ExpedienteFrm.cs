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
        private readonly AccForm accForms;  //  Instancia para gestionar acciones comunes del formulario
        private readonly GuardarExpediente guardarExpediente;   //  Clase encargada de guardar los expedientes en el archivo
        private List<Expediente> listaExpediente = new List<Expediente>();  //  Lista para gestionar los expedientes
        private string user;    //  Usuario actual
        private bool flag = true;   //  Bandera para determinar si se debe cerrar la aplicación

        //  Constructor que inicializa el formulario y los servicios necesarios
        public ExpedienteFrm(string user)
        {
            InitializeComponent();
            this.user = user;
            accForms = new AccForm(this);
            guardarExpediente = new GuardarExpediente("Expedientes.txt");
            lblInstruccion.Select();
        }

        //  Genera un DataTable a partir de los datos ingresados
        public DataTable DatosExpediente()
        {
            DataTable dt = new DataTable();

            //  Se define las columnas del DataTable
            dt.Columns.Add("IdExpediente");
            dt.Columns.Add("NombrePac");
            dt.Columns.Add("ApellidoPac");
            dt.Columns.Add("FechaCita");
            dt.Columns.Add("Motivo");
            dt.Columns.Add("Diagnostico");

            //  Rellenar el DataTable con los datos de cada fila
            foreach (DataGridViewRow fila in dgvExpediente.Rows)
            {
                if (!fila.IsNewRow) //  Ignora la fila nueva vacía
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

        //  Evento del botón para generar un reporte de los expedientes
        private void btnReporte_Click(object sender, EventArgs e)
        {
            accForms.VerReporte();
        }

        //  Evento del botón para guardar un nuevo expediente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //  Crear objeto con los datos ingresados
                Expediente expediente = new Expediente()
                {
                    IdExpediente = tbIdExped.Text,
                    NombrePac = tbNombrePac.Text,
                    ApellidoPac = tbApellidoPac.Text,
                    FechaCita = dtFechaCita.Value.ToString("dd/MM/yyyy"),
                    Motivo = tbMotivoCon.Text,
                    Diagnostico = tbDiagnostico.Text
                };
                guardarExpediente.Expediente(expediente);   //  Guardar el expediente y actualizar la lista
                listaExpediente.Add(expediente);
                dgvExpediente.DataSource = null;
                dgvExpediente.DataSource = listaExpediente;
                accForms.LimpiarCampos();   //  Limpiar los campos del formulario
                MetroMessageBox.Show(this, "Expediente creado/actualizado exitosamente", "Expediente Creado/Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Evento del botón para cancelar la operación
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accForms.Cancelar();
        }

        //  Evento del botón para volver al menú anterior
        private void btnVolver_Click(object sender, EventArgs e)
        {
            accForms.Volver(ref flag, user);
        }

        //  Evento de cierre del formulario
        private void ExpedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }

        //  Métodos para manejar eventos que permiten la navegación por el formulario

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
