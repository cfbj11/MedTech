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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDato = new MedTech.DataSet.DsDato();
            this.expedienteDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expedienteDTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.expedienteDTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedTech.Reportes.RptExpediente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsDato
            // 
            this.dsDato.DataSetName = "DsDato";
            this.dsDato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expedienteDTBindingSource
            // 
            this.expedienteDTBindingSource.DataMember = "ExpedienteDT";
            this.expedienteDTBindingSource.DataSource = this.dsDato;
            // 
            // RpvExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RpvExpediente";
            this.Load += new System.EventHandler(this.RpvExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expedienteDTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource expedienteDTBindingSource;
        private DataSet.DsDato dsDato;
    }
}