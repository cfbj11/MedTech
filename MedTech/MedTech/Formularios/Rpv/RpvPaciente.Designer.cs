namespace MedTech.Formularios
{
    partial class RpvPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpvPaciente));
            this.pacienteDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDato = new MedTech.DataSet.DsDato();
            this.rptPaciente = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).BeginInit();
            this.SuspendLayout();
            // 
            // pacienteDTBindingSource
            // 
            this.pacienteDTBindingSource.DataMember = "PacienteDT";
            this.pacienteDTBindingSource.DataSource = this.dsDato;
            // 
            // dsDato
            // 
            this.dsDato.DataSetName = "DsDato";
            this.dsDato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptPaciente
            // 
            this.rptPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pacienteDTBindingSource;
            this.rptPaciente.LocalReport.DataSources.Add(reportDataSource1);
            this.rptPaciente.LocalReport.ReportEmbeddedResource = "MedTech.Reportes.RptPaciente.rdlc";
            this.rptPaciente.Location = new System.Drawing.Point(20, 60);
            this.rptPaciente.Name = "rptPaciente";
            this.rptPaciente.ServerReport.BearerToken = null;
            this.rptPaciente.Size = new System.Drawing.Size(760, 370);
            this.rptPaciente.TabIndex = 0;
            // 
            // RpvPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RpvPaciente";
            this.Load += new System.EventHandler(this.RpvPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPaciente;
        private System.Windows.Forms.BindingSource pacienteDTBindingSource;
        private DataSet.DsDato dsDato;
    }
}