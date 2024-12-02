namespace MedTech.Formularios
{
    partial class RpvCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpvCita));
            this.citaDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDato = new MedTech.DataSet.DsDato();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.citaDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // citaDTBindingSource
            // 
            this.citaDTBindingSource.DataMember = "CitaDT";
            this.citaDTBindingSource.DataSource = this.dsDato;
            // 
            // dsDato
            // 
            this.dsDato.DataSetName = "DsDato";
            this.dsDato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.citaDTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedTech.Reportes.RptCita.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsDatoBindingSource
            // 
            this.dsDatoBindingSource.DataSource = this.dsDato;
            this.dsDatoBindingSource.Position = 0;
            // 
            // RpvCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RpvCita";
            this.Load += new System.EventHandler(this.RpvCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citaDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsDatoBindingSource;
        private DataSet.DsDato dsDato;
        private System.Windows.Forms.BindingSource citaDTBindingSource;
    }
}