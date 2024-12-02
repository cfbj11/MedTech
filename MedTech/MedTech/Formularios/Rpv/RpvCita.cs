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
    public partial class RpvCita : MetroFramework.Forms.MetroForm
    {
        private DataTable datosCita;    //  Tabla de datos de citas para generar el reporte

        //  Constructor que inicializa el formulario con los datos necesarios
        public RpvCita(DataTable data)
        {
            InitializeComponent();
            datosCita = data;
        }

        //  Evento al cargar el formulario
        private void RpvCita_Load(object sender, EventArgs e)
        {
            rptCita.LocalReport.DataSources.Clear();  //  Limpiar fuentes de datos
            ReportDataSource rds = new ReportDataSource("DataSet1", datosCita); //  Crear nueva fuente de datos
            rptCita.LocalReport.DataSources.Add(rds); //  Agregar fuente de datos al ReportViewer
            rptCita.RefreshReport();  //  Refrescar reporte actualizado
        }
    }
}
