using MedTech.Formularios;
using MedTech.Modelos;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTech.Servicio
{
    internal class AccForm
    {
        private readonly Form form; //  Formulario de origen desde el cual se realizan las operaciones

        //  Constructor de clase AccForms
        public AccForm(Form form)
        {
            this.form = form;
        }

        //****************************************************************
        //  MÉTODOS RELACIONADOS CON EL FORMULARIO DE MENÚ

        //  Muestra formulario de Agregar y Agendar Cita y oculta el formulario actual
        public void AgregarCita(ref bool flag, string user)
        {
            flag = false;
            AggCitaFrm aggCitaFrm = new AggCitaFrm(user);
            aggCitaFrm.Show();
            form.Close();
        }

        //  Muestra el formulario de Agregar Paciente y oculta el formulario actual
        public void AgregarPaciente(ref bool flag, string user)
        {
            flag = false;
            AggPacienteFrm aggPacienteFrm = new AggPacienteFrm(user);
            aggPacienteFrm.Show();
            form.Close();
        }

        //  Muestra el formulario de Expediente Médico y oculta el formulario actual
        public void ExpedMed(ref bool flag, string user)
        {
            flag = false;
            ExpedienteFrm expedienteFrm = new ExpedienteFrm(user);
            expedienteFrm.Show();
            form.Close();
        }

        //  Cierra sesión y muestra el formulario de Inicio de Sesión 
        public void CerrarSesion(ref bool flag)
        {
            var result = MetroMessageBox.Show(form, "¿Está seguro que desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                flag = false;
                InicioFrm inicioFrm = new InicioFrm();
                inicioFrm.Show();
                form.Close();
            }
        }

        //  Muestra información de ayuda sobre las funciones principales del sistema
        public void Ayuda()
        {
            string aggCita = "Se agrega los datos del paciente y se agenda la cita según la disponibilidad del doctor y paciente.";
            string aggPac = "Se ingresan los datos de un nuevo paciente dentro del sistema.";
            string expediente = "Se ingresan los datos de la cita del paciente dentro del sistema.";
            MetroMessageBox.Show(form, $"Agregar y Agendar Cita: {aggCita}\nAgregar Paciente: {aggPac}\nCrear o Actualizar Expediente Médico: {expediente}", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //****************************************************************
        //  MÉTODOS RELACIONADOS CON LOS FORMULARIOS AGREGAR CITA / AGREGAR PACIENTE / EXPEDIENTE MEDICO

        //  Muestra el reporte correspondiente al formulario actual
        public void VerReporte()
        {
            if (form is AggCitaFrm aggCitaFrm)
            {
                DataTable datosCita = aggCitaFrm.DatosCita();
                RpvCita rpvCita = new RpvCita(datosCita);
                rpvCita.Show();
            }
            else if (form is AggPacienteFrm aggPacienteFrm)
            {
                DataTable datosPaciente = aggPacienteFrm.DatosPaciente();
                RpvPaciente rpvPaciente = new RpvPaciente(datosPaciente);
                rpvPaciente.Show();
            }
            else if (form is ExpedienteFrm expedienteFrm)
            {
                DataTable datosExpediente = expedienteFrm.DatosExpediente();
                RpvExpediente rpvExpediente = new RpvExpediente(datosExpediente);
                rpvExpediente.Show();
            }
        }

        //  Cancela la operación actual y se pregunta al usuario si desea continuar
        public void Cancelar()
        {
            string msjCancelar = "¿Desea cancelar la operación?";

            //  Personalizar mensaje según el formulario activo
            if (form is AggCitaFrm) msjCancelar = "¿Desea cancelar la agendación de cita?";
            else if (form is AggPacienteFrm) msjCancelar = "¿Desea cancelar el ingreso del paciente al sistema?";
            else if (form is ExpedienteFrm) msjCancelar = "¿Desea cancelar la creación/actualización de expediente?";
            var result = MetroMessageBox.Show(form, msjCancelar, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) LimpiarCampos();
        }

        //  Vuelve al formulario de menú y cierra el formulario actual
        public void Volver(ref bool flag, string user)
        {
            flag = false;
            MenuFrm menuFrm = Application.OpenForms.OfType<MenuFrm>().FirstOrDefault();
            if (menuFrm == null)
                menuFrm = new MenuFrm(user);
            else
                menuFrm.Actualizar(user);
            menuFrm.Show();
            form.Close();
        }

        //  Limpia los campos de los datos de los formularios
        public void LimpiarCampos()
        {
            if (form is AggCitaFrm aggCitaFrm)    //  Limpia campos de AggCitaForm
            {
                aggCitaFrm.tbNombrePac.Clear();
                aggCitaFrm.tbApellidoPac.Clear();
                aggCitaFrm.dtFechaCita.Value = DateTime.Today;
                aggCitaFrm.tbHoraCita.Clear();
                aggCitaFrm.tbIdPaciente.Clear();
                aggCitaFrm.tbDoctor.Clear();
                aggCitaFrm.cbEspecialidad.SelectedIndex = -1;
                aggCitaFrm.cbxTelefono.Checked = false;
                aggCitaFrm.cbxCorreo.Checked = false;
                aggCitaFrm.tbContacto.Clear();
                aggCitaFrm.tbCosto.Clear();
            }

            if (form is AggPacienteFrm aggPacienteFrm)    //  Limpia campos de AggPacienteForm
            {
                aggPacienteFrm.tbNombrePac.Clear();
                aggPacienteFrm.tbApellidoPac.Clear();
                aggPacienteFrm.dtFechaNac.Value = DateTime.Today;
                aggPacienteFrm.tbAntecedentes.Clear();
                aggPacienteFrm.tbEnfermedades.Clear();
                aggPacienteFrm.lbEnfermedades.Items.Clear();
                aggPacienteFrm.cbxAlergias.Checked = false;
                aggPacienteFrm.cbxCirugias.Checked = false;
                aggPacienteFrm.tbId.Clear();
            }

            if (form is ExpedienteFrm expedienteFrm)    //  Limpia campos de ExpedForm
            {
                expedienteFrm.tbIdExped.Clear();
                expedienteFrm.tbNombrePac.Clear();
                expedienteFrm.tbApellidoPac.Clear();
                expedienteFrm.dtFechaCita.Value = DateTime.Today;
                expedienteFrm.tbMotivoCon.Clear();
                expedienteFrm.tbDiagnostico.Clear();
            }
        }
    }
}
