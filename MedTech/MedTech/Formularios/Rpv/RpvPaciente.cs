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
        private DataTable datosPaciente;
        public RpvPaciente(DataTable data)
        {
            InitializeComponent();
            datosPaciente = data;
        }

        private void RpvPaciente_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", datosPaciente);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
