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
        private readonly AccForm accForms;  //  Instancia para gestionar acciones comunes del formulario
        private readonly GuardarPaciente guardarPaciente;   //  Clase encargada de guardar los pacientes en el archivo
        private List<Paciente> listaPaciente = new List<Paciente>();    //  Lista para gestionar los pacientes
        private string user;    //  Usuario actual
        private bool flag = true;   //  Bandera para determinar si se debe cerrar la aplicación

        //  Constructor que inicializa el formulario con los servicios necesarios
        public AggPacienteFrm(string user)
        {
            InitializeComponent();
            this.user = user;
            accForms = new AccForm(this);
            guardarPaciente = new GuardarPaciente("PacienteRegistrados");
            lblInstruccion.Select();
        }

        //  Genera un DataTable a partir de los datos ingresados
        public DataTable DatosPaciente()
        {
            DataTable dt = new DataTable();

            //  Se define las columnas del DataTable
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("IdPaciente");
            dt.Columns.Add("FechaNac");
            dt.Columns.Add("Antecedentes");
            dt.Columns.Add("Enfermedades");
            dt.Columns.Add("Alergias");
            dt.Columns.Add("Cirugias");

            //  Rellenar el DataTable con los datos de cada fila
            foreach (DataGridViewRow fila in dgvPaciente.Rows)
            {
                if (!fila.IsNewRow) //  Ignora la fila nueva vacía
                {
                    DataRow dr = dt.NewRow();
                    dr["Nombre"] = fila.Cells["Nombre"].Value.ToString();
                    dr["Apellido"] = fila.Cells["Apellido"].Value.ToString();
                    dr["IdPaciente"] = fila.Cells["IdPaciente"].Value.ToString();
                    dr["FechaNac"] = fila.Cells["FechaNac"].Value;
                    dr["Antecedentes"] = fila.Cells["Antecedentes"].Value.ToString();
                    dr["Enfermedades"] = fila.Cells["Enfermedades"].Value.ToString();
                    dr["Alergias"] = fila.Cells["Alergias"].Value.ToString();
                    dr["Cirugias"] = fila.Cells["Cirugias"].Value.ToString();

                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        //  Evento del botón para generar reporte de paciente
        private void btnReporte_Click(object sender, EventArgs e)
        {
            accForms.VerReporte();
        }

        //  Evento del botón para agregar una enfermedad a la lista
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

        //  Evento del botón para guardar un nuevo paciente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string enfermedades = string.Join(", ", lbEnfermedades.Items.Cast<string>());
                string idPaciente = tbId.Text;
                string contraseña = guardarPaciente.GenerarContraseña();
                //  Crear objeto con los datos del formulario
                Paciente paciente = new Paciente()
                {
                    Nombre = tbNombrePac.Text,
                    Apellido = tbApellidoPac.Text,
                    IdPaciente = idPaciente,
                    FechaNac = dtFechaNac.Value.ToString("dd/MM/yyyy"),
                    Antecedentes = tbAntecedentes.Text,
                    Enfermedades = enfermedades,
                    Alergias = cbxAlergias.Checked ? "Sí" : "No",
                    Cirugias = cbxCirugias.Checked ? "Sí" : "No"
                };
                guardarPaciente.GuardarPac(paciente);   //  Gyardar paciente y actualizar la lista
                listaPaciente.Add(paciente);
                dgvPaciente.DataSource = null;
                dgvPaciente.DataSource = listaPaciente;
                accForms.LimpiarCampos();   //  Limpiar los campos del formulario
                MetroMessageBox.Show(this, $"Paciente registrado exitosamente\nID Asignado: {idPaciente}\nContraseña: {contraseña}", "Paciente ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error al registrar al paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void AggPacienteForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    tbId.Focus();
                }
            }
        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGuardar.Focus();
            }
        }
    }
}
