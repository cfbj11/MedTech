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
    public partial class RpvPaciente : MetroFramework.Forms.MetroForm
    {
        private DataTable datosPaciente;    //  Tabla de datos de pacientes para generar reporte

        //  Constructor que inicializa el formulario con los datos necesarios
        public RpvPaciente(DataTable data)
        {
            InitializeComponent();
            datosPaciente = data;
        }

        //  Evento al cargar el formulario
        private void RpvPaciente_Load(object sender, EventArgs e)
        {
            rptPaciente.LocalReport.DataSources.Clear();    //  Limpiar fuente de datos
            ReportDataSource rds = new ReportDataSource("DataSet1", datosPaciente); //  Crear nueva fuente de datos
            rptPaciente.LocalReport.DataSources.Add(rds);   //  Agregar fuente de datos
            rptPaciente.RefreshReport();    //  Refrescar reporte actualizado
        }
    }
}
