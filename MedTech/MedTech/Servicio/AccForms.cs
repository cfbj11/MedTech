using MedTech.Formularios;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTech.Servicio
{
    internal class AccForms
    {
        private readonly Form form; //  Formulario de origen desde el cual se realizan las operaciones

        //  Constructor de clase AccForms
        public AccForms(Form form)
        {
            this.form = form;
        }

        //****************************************************************
        //  MÉTODOS RELACIONADOS CON EL FORMULARIO DE MENÚ

        //  Muestra formulario de Agregar y Agendar Cita y oculta el formulario actual
        public void AgregarCita(ref bool flag)
        {
            flag = false;
            AggCitaFrm aggCitaForm = new AggCitaFrm();
            aggCitaForm.Show();
            form.Hide();
        }

        //  Muestra el formulario de Agregar Paciente y oculta el formulario actual
        public void AgregarPaciente(ref bool flag)
        {
            flag = false;
            AggPacienteFrm aggPacienteForm = new AggPacienteFrm();
            aggPacienteForm.Show();
            form.Hide();
        }

        //  Muestra el formulario de Expediente Médico y oculta el formulario actual
        public void ExpedMed(ref bool flag)
        {
            flag = false;
            ExpedienteFrm expedMedForm = new ExpedienteFrm();
            expedMedForm.Show();
            form.Hide();
        }

        //  Cierra sesión y muestra el formulario de Inicio de Sesión 
        public void CerrarSesion(ref bool flag)
        {
            var result = MetroMessageBox.Show(form, "¿Está seguro que desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                flag = false;
                InicioFrm inSesForm = new InicioFrm();
                inSesForm.Show();
                form.Close();
            }
        }

        //  Muestra información de ayuda sobre las funciones principales del sistema
        public void Ayuda()
        {
            string aggCita = "Se agrega los datos del paciente y se agenda la cita según la disponibilidad del doctor y paciente.";
            string aggPac = "Se ingresan los datos de un nuevo paciente dentro del sistema.";
            string expedMed = "Se ingresan los datos de la cita del paciente dentro del sistema.";
            MetroMessageBox.Show(form, $"Agregar y Agendar Cita: {aggCita}\nAgregar Paciente: {aggPac}\nCrear o Actualizar Expediente Médico: {expedMed}", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //****************************************************************
        //  MÉTODOS RELACIONADOS CON LOS FORMULARIOS AGREGAR CITA / AGREGAR PACIENTE / EXPEDIENTE MEDICO

        //  Guarda los datos ingresados en el formulario actual y muestra un mensaje de confirmación
        public void Guardar()
        {
            string msjGuardar = "Se han guardado los datos correctamente.";
            MetroMessageBox.Show(form, msjGuardar, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //  Cancela la operación actual y se pregunta al usuario si desea continuar
        public void Cancelar()
        {
            string msjCancelar = "¿Desea cancelar la operación?";

            //  Personaliza el mensaje según el formulario activo
            if (form is AggCitaFrm) msjCancelar = "¿Desea cancelar la agendación de cita?";
            else if (form is AggPacienteFrm) msjCancelar = "¿Desea cancelar el ingreso del paciente al sistema?";
            else if (form is ExpedienteFrm) msjCancelar = "¿Desea cancelar la creación/actualización de expediente?";
            var result = MetroMessageBox.Show(form, msjCancelar, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) LimpiarCampos();
        }

        //  Vuelve al formulario de menú y cierra el formulario actual
        public void Volver(ref bool flag)
        {
            flag = false;
            MenuFrm menuMedForm = new MenuFrm();
            menuMedForm.Show();
            form.Close();
        }

        //  Limpia los campos de los datos de los formularios
        private void LimpiarCampos()
        {
            if (form is AggCitaFrm aggCitaForm)    //  Limpia campos de AggCitaForm
            {
                aggCitaForm.tbNombrePac.Clear();
                aggCitaForm.tbApellidoPac.Clear();
                aggCitaForm.dtFechaCita.Value = DateTime.Today;
                aggCitaForm.tbHoraCita.Clear();
                aggCitaForm.tbIdPaciente.Clear();
                aggCitaForm.tbDoctor.Clear();
                aggCitaForm.cbEspecialidad.SelectedIndex = -1;
                aggCitaForm.cbxTelefono.Checked = false;
                aggCitaForm.cbxCorreo.Checked = false;
                aggCitaForm.tbContacto.Clear();
                aggCitaForm.tbCosto.Clear();
            }

            if (form is AggPacienteFrm aggPacienteForm)    //  Limpia campos de AggPacienteForm
            {
                aggPacienteForm.tbNombrePac.Clear();
                aggPacienteForm.tbApellidoPac.Clear();
                aggPacienteForm.dtFechaNac.Value = DateTime.Today;
                aggPacienteForm.tbAntecedentes.Clear();
                aggPacienteForm.tbEnfermedades.Clear();
                aggPacienteForm.lbEnfermedades.Items.Clear();
                aggPacienteForm.cbxAlergias.Checked = false;
                aggPacienteForm.cbxCirugias.Checked = false;
            }

            if (form is ExpedienteFrm expedForm)    //  Limpia campos de ExpedForm
            {
                expedForm.tbIdExped.Clear();
                expedForm.tbNombrePac.Clear();
                expedForm.tbApellidoPac.Clear();
                expedForm.dtFechaCita.Value = DateTime.Today;
                expedForm.tbMotivoCon.Clear();
                expedForm.tbDiagnostico.Clear();
            }
        }
    }
}
