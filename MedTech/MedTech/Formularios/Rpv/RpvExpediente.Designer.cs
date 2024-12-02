namespace MedTech.Formularios
{
    partial class RpvExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpvExpediente));
            this.expedienteDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDato = new MedTech.DataSet.DsDato();
            this.rptExpediente = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.expedienteDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).BeginInit();
            this.SuspendLayout();
            // 
            // expedienteDTBindingSource
            // 
            this.expedienteDTBindingSource.DataMember = "ExpedienteDT";
            this.expedienteDTBindingSource.DataSource = this.dsDato;
            // 
            // dsDato
            // 
            this.dsDato.DataSetName = "DsDato";
            this.dsDato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptExpediente
            // 
            this.rptExpediente.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.expedienteDTBindingSource;
            this.rptExpediente.LocalReport.DataSources.Add(reportDataSource1);
            this.rptExpediente.LocalReport.ReportEmbeddedResource = "MedTech.Reportes.RptExpediente.rdlc";
            this.rptExpediente.Location = new System.Drawing.Point(20, 60);
            this.rptExpediente.Name = "rptExpediente";
            this.rptExpediente.ServerReport.BearerToken = null;
            this.rptExpediente.Size = new System.Drawing.Size(760, 370);
            this.rptExpediente.TabIndex = 0;
            // 
            // RpvExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptExpediente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RpvExpediente";
            this.Load += new System.EventHandler(this.RpvExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expedienteDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptExpediente;
        private System.Windows.Forms.BindingSource expedienteDTBindingSource;
        private DataSet.DsDato dsDato;
    }
}