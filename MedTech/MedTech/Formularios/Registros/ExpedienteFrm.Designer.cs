namespace MedTech.Formularios
{
    partial class ExpedienteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpedienteFrm));
            this.lblInstruccion = new MetroFramework.Controls.MetroLabel();
            this.lblIdExped = new MetroFramework.Controls.MetroLabel();
            this.tbIdExped = new MetroFramework.Controls.MetroTextBox();
            this.lblNombrePac = new MetroFramework.Controls.MetroLabel();
            this.tbNombrePac = new MetroFramework.Controls.MetroTextBox();
            this.lblApellidoPac = new MetroFramework.Controls.MetroLabel();
            this.tbApellidoPac = new MetroFramework.Controls.MetroTextBox();
            this.lblMotivo = new MetroFramework.Controls.MetroLabel();
            this.lblDiagnostico = new MetroFramework.Controls.MetroLabel();
            this.tbMotivoCon = new MetroFramework.Controls.MetroTextBox();
            this.tbDiagnostico = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblFecCita = new MetroFramework.Controls.MetroLabel();
            this.dtFechaCita = new MetroFramework.Controls.MetroDateTime();
            this.dgvExpediente = new System.Windows.Forms.DataGridView();
            this.btnReporte = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblInstruccion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblInstruccion.ForeColor = System.Drawing.Color.White;
            this.lblInstruccion.Location = new System.Drawing.Point(23, 70);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(139, 25);
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Ingrese los datos";
            this.lblInstruccion.UseCustomBackColor = true;
            this.lblInstruccion.UseCustomForeColor = true;
            // 
            // lblIdExped
            // 
            this.lblIdExped.AutoSize = true;
            this.lblIdExped.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIdExped.Location = new System.Drawing.Point(23, 125);
            this.lblIdExped.Name = "lblIdExped";
            this.lblIdExped.Size = new System.Drawing.Size(101, 19);
            this.lblIdExped.TabIndex = 1;
            this.lblIdExped.Text = "ID Expediente";
            // 
            // tbIdExped
            // 
            // 
            // 
            // 
            this.tbIdExped.CustomButton.Image = null;
            this.tbIdExped.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbIdExped.CustomButton.Name = "";
            this.tbIdExped.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIdExped.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIdExped.CustomButton.TabIndex = 1;
            this.tbIdExped.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIdExped.CustomButton.UseSelectable = true;
            this.tbIdExped.CustomButton.Visible = false;
            this.tbIdExped.Lines = new string[0];
            this.tbIdExped.Location = new System.Drawing.Point(23, 147);
            this.tbIdExped.MaxLength = 4;
            this.tbIdExped.Name = "tbIdExped";
            this.tbIdExped.PasswordChar = '\0';
            this.tbIdExped.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIdExped.SelectedText = "";
            this.tbIdExped.SelectionLength = 0;
            this.tbIdExped.SelectionStart = 0;
            this.tbIdExped.ShortcutsEnabled = true;
            this.tbIdExped.Size = new System.Drawing.Size(100, 23);
            this.tbIdExped.TabIndex = 2;
            this.tbIdExped.UseSelectable = true;
            this.tbIdExped.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIdExped.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbIdExped.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdExped_KeyPress);
            // 
            // lblNombrePac
            // 
            this.lblNombrePac.AutoSize = true;
            this.lblNombrePac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNombrePac.Location = new System.Drawing.Point(23, 200);
            this.lblNombrePac.Name = "lblNombrePac";
            this.lblNombrePac.Size = new System.Drawing.Size(151, 19);
            this.lblNombrePac.TabIndex = 3;
            this.lblNombrePac.Text = "Nombre del Paciente";
            // 
            // tbNombrePac
            // 
            // 
            // 
            // 
            this.tbNombrePac.CustomButton.Image = null;
            this.tbNombrePac.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbNombrePac.CustomButton.Name = "";
            this.tbNombrePac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNombrePac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombrePac.CustomButton.TabIndex = 1;
            this.tbNombrePac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombrePac.CustomButton.UseSelectable = true;
            this.tbNombrePac.CustomButton.Visible = false;
            this.tbNombrePac.Lines = new string[0];
            this.tbNombrePac.Location = new System.Drawing.Point(23, 222);
            this.tbNombrePac.MaxLength = 50;
            this.tbNombrePac.Name = "tbNombrePac";
            this.tbNombrePac.PasswordChar = '\0';
            this.tbNombrePac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombrePac.SelectedText = "";
            this.tbNombrePac.SelectionLength = 0;
            this.tbNombrePac.SelectionStart = 0;
            this.tbNombrePac.ShortcutsEnabled = true;
            this.tbNombrePac.Size = new System.Drawing.Size(150, 23);
            this.tbNombrePac.TabIndex = 4;
            this.tbNombrePac.UseSelectable = true;
            this.tbNombrePac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombrePac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombrePac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombrePac_KeyPress);
            // 
            // lblApellidoPac
            // 
            this.lblApellidoPac.AutoSize = true;
            this.lblApellidoPac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblApellidoPac.Location = new System.Drawing.Point(23, 275);
            this.lblApellidoPac.Name = "lblApellidoPac";
            this.lblApellidoPac.Size = new System.Drawing.Size(152, 19);
            this.lblApellidoPac.TabIndex = 5;
            this.lblApellidoPac.Text = "Apellido del Paciente";
            // 
            // tbApellidoPac
            // 
            // 
            // 
            // 
            this.tbApellidoPac.CustomButton.Image = null;
            this.tbApellidoPac.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbApellidoPac.CustomButton.Name = "";
            this.tbApellidoPac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbApellidoPac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbApellidoPac.CustomButton.TabIndex = 1;
            this.tbApellidoPac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbApellidoPac.CustomButton.UseSelectable = true;
            this.tbApellidoPac.CustomButton.Visible = false;
            this.tbApellidoPac.Lines = new string[0];
            this.tbApellidoPac.Location = new System.Drawing.Point(23, 297);
            this.tbApellidoPac.MaxLength = 50;
            this.tbApellidoPac.Name = "tbApellidoPac";
            this.tbApellidoPac.PasswordChar = '\0';
            this.tbApellidoPac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbApellidoPac.SelectedText = "";
            this.tbApellidoPac.SelectionLength = 0;
            this.tbApellidoPac.SelectionStart = 0;
            this.tbApellidoPac.ShortcutsEnabled = true;
            this.tbApellidoPac.Size = new System.Drawing.Size(150, 23);
            this.tbApellidoPac.TabIndex = 6;
            this.tbApellidoPac.UseSelectable = true;
            this.tbApellidoPac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbApellidoPac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbApellidoPac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidoPac_KeyPress);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMotivo.Location = new System.Drawing.Point(300, 225);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(139, 19);
            this.lblMotivo.TabIndex = 8;
            this.lblMotivo.Text = "Motivo de Consulta";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDiagnostico.Location = new System.Drawing.Point(600, 125);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(88, 19);
            this.lblDiagnostico.TabIndex = 10;
            this.lblDiagnostico.Text = "Diagnóstico";
            // 
            // tbMotivoCon
            // 
            // 
            // 
            // 
            this.tbMotivoCon.CustomButton.Image = null;
            this.tbMotivoCon.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tbMotivoCon.CustomButton.Name = "";
            this.tbMotivoCon.CustomButton.Size = new System.Drawing.Size(73, 73);
            this.tbMotivoCon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMotivoCon.CustomButton.TabIndex = 1;
            this.tbMotivoCon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMotivoCon.CustomButton.UseSelectable = true;
            this.tbMotivoCon.CustomButton.Visible = false;
            this.tbMotivoCon.Lines = new string[0];
            this.tbMotivoCon.Location = new System.Drawing.Point(300, 245);
            this.tbMotivoCon.MaxLength = 150;
            this.tbMotivoCon.Multiline = true;
            this.tbMotivoCon.Name = "tbMotivoCon";
            this.tbMotivoCon.PasswordChar = '\0';
            this.tbMotivoCon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMotivoCon.SelectedText = "";
            this.tbMotivoCon.SelectionLength = 0;
            this.tbMotivoCon.SelectionStart = 0;
            this.tbMotivoCon.ShortcutsEnabled = true;
            this.tbMotivoCon.Size = new System.Drawing.Size(150, 75);
            this.tbMotivoCon.TabIndex = 9;
            this.tbMotivoCon.UseSelectable = true;
            this.tbMotivoCon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMotivoCon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbMotivoCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMotivoCon_KeyPress);
            // 
            // tbDiagnostico
            // 
            // 
            // 
            // 
            this.tbDiagnostico.CustomButton.Image = null;
            this.tbDiagnostico.CustomButton.Location = new System.Drawing.Point(-15, 1);
            this.tbDiagnostico.CustomButton.Name = "";
            this.tbDiagnostico.CustomButton.Size = new System.Drawing.Size(171, 171);
            this.tbDiagnostico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDiagnostico.CustomButton.TabIndex = 1;
            this.tbDiagnostico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDiagnostico.CustomButton.UseSelectable = true;
            this.tbDiagnostico.CustomButton.Visible = false;
            this.tbDiagnostico.Lines = new string[0];
            this.tbDiagnostico.Location = new System.Drawing.Point(600, 147);
            this.tbDiagnostico.MaxLength = 150;
            this.tbDiagnostico.Multiline = true;
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.PasswordChar = '\0';
            this.tbDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDiagnostico.SelectedText = "";
            this.tbDiagnostico.SelectionLength = 0;
            this.tbDiagnostico.SelectionStart = 0;
            this.tbDiagnostico.ShortcutsEnabled = true;
            this.tbDiagnostico.Size = new System.Drawing.Size(157, 173);
            this.tbDiagnostico.TabIndex = 11;
            this.tbDiagnostico.UseSelectable = true;
            this.tbDiagnostico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDiagnostico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbDiagnostico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiagnostico_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(520, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseCustomForeColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(601, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseCustomBackColor = true;
            this.btnCancelar.UseCustomForeColor = true;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(682, 384);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseCustomBackColor = true;
            this.btnVolver.UseCustomForeColor = true;
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 65);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 35);
            this.metroPanel1.TabIndex = 23;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MedTech.Properties.Resources.Logotipo_medtech;
            this.pbLogo.Location = new System.Drawing.Point(0, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 26;
            this.pbLogo.TabStop = false;
            // 
            // lblFecCita
            // 
            this.lblFecCita.AutoSize = true;
            this.lblFecCita.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFecCita.Location = new System.Drawing.Point(300, 125);
            this.lblFecCita.Name = "lblFecCita";
            this.lblFecCita.Size = new System.Drawing.Size(98, 19);
            this.lblFecCita.TabIndex = 7;
            this.lblFecCita.Text = "Fecha de Cita";
            // 
            // dtFechaCita
            // 
            this.dtFechaCita.Location = new System.Drawing.Point(300, 147);
            this.dtFechaCita.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaCita.Name = "dtFechaCita";
            this.dtFechaCita.Size = new System.Drawing.Size(150, 29);
            this.dtFechaCita.TabIndex = 8;
            this.dtFechaCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtFechaCita_KeyPress);
            // 
            // dgvExpediente
            // 
            this.dgvExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpediente.Location = new System.Drawing.Point(23, 413);
            this.dgvExpediente.Name = "dgvExpediente";
            this.dgvExpediente.Size = new System.Drawing.Size(734, 164);
            this.dgvExpediente.TabIndex = 16;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(23, 384);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 12;
            this.btnReporte.Text = "Ver Reporte";
            this.btnReporte.UseCustomBackColor = true;
            this.btnReporte.UseCustomForeColor = true;
            this.btnReporte.UseSelectable = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // ExpedienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvExpediente);
            this.Controls.Add(this.dtFechaCita);
            this.Controls.Add(this.lblFecCita);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbDiagnostico);
            this.Controls.Add(this.tbMotivoCon);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.tbApellidoPac);
            this.Controls.Add(this.lblApellidoPac);
            this.Controls.Add(this.tbNombrePac);
            this.Controls.Add(this.lblNombrePac);
            this.Controls.Add(this.tbIdExped);
            this.Controls.Add(this.lblIdExped);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExpedienteFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpedForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblInstruccion;
        private MetroFramework.Controls.MetroLabel lblIdExped;
        private MetroFramework.Controls.MetroLabel lblNombrePac;
        private MetroFramework.Controls.MetroLabel lblApellidoPac;
        private MetroFramework.Controls.MetroLabel lblMotivo;
        private MetroFramework.Controls.MetroLabel lblDiagnostico;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroLabel lblFecCita;
        internal MetroFramework.Controls.MetroTextBox tbIdExped;
        internal MetroFramework.Controls.MetroTextBox tbNombrePac;
        internal MetroFramework.Controls.MetroTextBox tbApellidoPac;
        internal MetroFramework.Controls.MetroTextBox tbMotivoCon;
        internal MetroFramework.Controls.MetroTextBox tbDiagnostico;
        internal MetroFramework.Controls.MetroDateTime dtFechaCita;
        internal System.Windows.Forms.DataGridView dgvExpediente;
        private MetroFramework.Controls.MetroButton btnReporte;
    }
}