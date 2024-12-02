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
        private readonly AccForm accForms;  //  Instancia para gestionar acciones comunes del formulario
        private readonly GuardarCita guardarCita;   //  Clase encargada de guardar citas en el archivo
        private List<Cita> listaCitas = new List<Cita>();   //  Lista para gestionar las citas
        private string user;    //  Usuario actual
        private bool flag = true;   //  Bandera para determinar si se debe cerrar la aplicación

        //  Constructor que inicializa los componentes del formulario y las dependencias
        public AggCitaFrm(string user)
        {
            InitializeComponent();
            this.user = user;
            accForms = new AccForm(this);
            guardarCita = new GuardarCita("CitasRegistradas.txt");
            lblInstruccion.Select();
        }

        //  Genera un DataTable basado en los datos ingresados
        public DataTable DatosCita()
        {
            DataTable dt = new DataTable();

            //  Se define las columnas del DataTable que coinciden con los campos de la cita
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("IdPaciente");
            dt.Columns.Add("FechaCita");
            dt.Columns.Add("HoraCita");
            dt.Columns.Add("Doctor");
            dt.Columns.Add("Especialidad");
            dt.Columns.Add("TipoContacto");
            dt.Columns.Add("Contacto");
            dt.Columns.Add("CostoConsulta");

            //  Rellena el DataTable con los datos de cada fila
            foreach (DataGridViewRow fila in dgvCita.Rows)
            {
                if (!fila.IsNewRow) //  Ignora la fila nueva vacía
                {
                    DataRow dr = dt.NewRow();

                    dr["Nombre"] = fila.Cells["Nombre"].Value.ToString();
                    dr["Apellido"] = fila.Cells["Apellido"].Value.ToString();
                    dr["IdPaciente"] = fila.Cells["IdPaciente"].Value.ToString();
                    dr["FechaCita"] = fila.Cells["FechaCita"].Value;
                    dr["HoraCita"] = fila.Cells["HoraCita"].Value.ToString();
                    dr["Doctor"] = fila.Cells["Doctor"].Value.ToString();
                    dr["Especialidad"] = fila.Cells["Especialidad"].Value.ToString();
                    dr["TipoContacto"] = fila.Cells["TipoContacto"].Value.ToString();
                    dr["Contacto"] = fila.Cells["Contacto"].Value.ToString();
                    dr["CostoConsulta"] = fila.Cells["CostoConsulta"].Value;

                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        //  Evento del botón para generar un reporte
        private void btnReporte_Click(object sender, EventArgs e)
        {
            accForms.VerReporte();
        }

        //  Evento del botón para guardar una nueva cita
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //  Crear nuevo objeto con los datos del formulario
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
                guardarCita.Guardar(cita);  //  Guardar la cita utilizando la clase GuardarCita
                listaCitas.Add(cita);   //  Actualiza la lista de citas
                dgvCita.DataSource = null;
                dgvCita.DataSource = listaCitas;
                accForms.LimpiarCampos();   //  Limpia los campos después de guardar la cita
                MetroMessageBox.Show(this, "Cita registrada exitosamente", "Cita agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error al guardar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        //  Evento del botón para cancelar la operación
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accForms.Cancelar();
        }

        //  Evento para volver al menú anterior
        private void btnVolver_Click(object sender, EventArgs e)
        {
            accForms.Volver(ref flag, user);
        }

        //  Evento de cierre del formulario
        private void AggCitaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag) Application.Exit();
        }

        //  Métodos para manejar eventos que permiten la navegación por el formulario

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
