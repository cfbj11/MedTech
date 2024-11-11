namespace MedTech.Formularios
{
    partial class ExpedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpedForm));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecCita = new MetroFramework.Controls.MetroLabel();
            this.dtFecCita = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblInstruccion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblInstruccion.ForeColor = System.Drawing.Color.White;
            this.lblInstruccion.Location = new System.Drawing.Point(31, 86);
            this.lblInstruccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblIdExped.Location = new System.Drawing.Point(31, 154);
            this.lblIdExped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdExped.Name = "lblIdExped";
            this.lblIdExped.Size = new System.Drawing.Size(106, 20);
            this.lblIdExped.TabIndex = 1;
            this.lblIdExped.Text = "ID Expediente";
            // 
            // tbIdExped
            // 
            // 
            // 
            // 
            this.tbIdExped.CustomButton.Image = null;
            this.tbIdExped.CustomButton.Location = new System.Drawing.Point(143, 2);
            this.tbIdExped.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIdExped.CustomButton.Name = "";
            this.tbIdExped.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.tbIdExped.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIdExped.CustomButton.TabIndex = 1;
            this.tbIdExped.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIdExped.CustomButton.UseSelectable = true;
            this.tbIdExped.CustomButton.Visible = false;
            this.tbIdExped.Lines = new string[0];
            this.tbIdExped.Location = new System.Drawing.Point(31, 181);
            this.tbIdExped.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIdExped.MaxLength = 32767;
            this.tbIdExped.Name = "tbIdExped";
            this.tbIdExped.PasswordChar = '\0';
            this.tbIdExped.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIdExped.SelectedText = "";
            this.tbIdExped.SelectionLength = 0;
            this.tbIdExped.SelectionStart = 0;
            this.tbIdExped.ShortcutsEnabled = true;
            this.tbIdExped.Size = new System.Drawing.Size(133, 28);
            this.tbIdExped.TabIndex = 2;
            this.tbIdExped.UseSelectable = true;
            this.tbIdExped.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIdExped.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombrePac
            // 
            this.lblNombrePac.AutoSize = true;
            this.lblNombrePac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNombrePac.Location = new System.Drawing.Point(31, 246);
            this.lblNombrePac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePac.Name = "lblNombrePac";
            this.lblNombrePac.Size = new System.Drawing.Size(155, 20);
            this.lblNombrePac.TabIndex = 3;
            this.lblNombrePac.Text = "Nombre del Paciente";
            // 
            // tbNombrePac
            // 
            // 
            // 
            // 
            this.tbNombrePac.CustomButton.Image = null;
            this.tbNombrePac.CustomButton.Location = new System.Drawing.Point(232, 2);
            this.tbNombrePac.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombrePac.CustomButton.Name = "";
            this.tbNombrePac.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.tbNombrePac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombrePac.CustomButton.TabIndex = 1;
            this.tbNombrePac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombrePac.CustomButton.UseSelectable = true;
            this.tbNombrePac.CustomButton.Visible = false;
            this.tbNombrePac.Lines = new string[0];
            this.tbNombrePac.Location = new System.Drawing.Point(31, 273);
            this.tbNombrePac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombrePac.MaxLength = 32767;
            this.tbNombrePac.Name = "tbNombrePac";
            this.tbNombrePac.PasswordChar = '\0';
            this.tbNombrePac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombrePac.SelectedText = "";
            this.tbNombrePac.SelectionLength = 0;
            this.tbNombrePac.SelectionStart = 0;
            this.tbNombrePac.ShortcutsEnabled = true;
            this.tbNombrePac.Size = new System.Drawing.Size(200, 28);
            this.tbNombrePac.TabIndex = 4;
            this.tbNombrePac.UseSelectable = true;
            this.tbNombrePac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombrePac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblApellidoPac
            // 
            this.lblApellidoPac.AutoSize = true;
            this.lblApellidoPac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblApellidoPac.Location = new System.Drawing.Point(31, 338);
            this.lblApellidoPac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPac.Name = "lblApellidoPac";
            this.lblApellidoPac.Size = new System.Drawing.Size(155, 20);
            this.lblApellidoPac.TabIndex = 5;
            this.lblApellidoPac.Text = "Apellido del Paciente";
            // 
            // tbApellidoPac
            // 
            // 
            // 
            // 
            this.tbApellidoPac.CustomButton.Image = null;
            this.tbApellidoPac.CustomButton.Location = new System.Drawing.Point(232, 2);
            this.tbApellidoPac.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApellidoPac.CustomButton.Name = "";
            this.tbApellidoPac.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.tbApellidoPac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbApellidoPac.CustomButton.TabIndex = 1;
            this.tbApellidoPac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbApellidoPac.CustomButton.UseSelectable = true;
            this.tbApellidoPac.CustomButton.Visible = false;
            this.tbApellidoPac.Lines = new string[0];
            this.tbApellidoPac.Location = new System.Drawing.Point(31, 366);
            this.tbApellidoPac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbApellidoPac.MaxLength = 32767;
            this.tbApellidoPac.Name = "tbApellidoPac";
            this.tbApellidoPac.PasswordChar = '\0';
            this.tbApellidoPac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbApellidoPac.SelectedText = "";
            this.tbApellidoPac.SelectionLength = 0;
            this.tbApellidoPac.SelectionStart = 0;
            this.tbApellidoPac.ShortcutsEnabled = true;
            this.tbApellidoPac.Size = new System.Drawing.Size(200, 28);
            this.tbApellidoPac.TabIndex = 6;
            this.tbApellidoPac.UseSelectable = true;
            this.tbApellidoPac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbApellidoPac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMotivo.Location = new System.Drawing.Point(400, 277);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(145, 20);
            this.lblMotivo.TabIndex = 7;
            this.lblMotivo.Text = "Motivo de Consulta";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDiagnostico.Location = new System.Drawing.Point(800, 154);
            this.lblDiagnostico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(92, 20);
            this.lblDiagnostico.TabIndex = 8;
            this.lblDiagnostico.Text = "Diagnóstico";
            // 
            // tbMotivoCon
            // 
            // 
            // 
            // 
            this.tbMotivoCon.CustomButton.Image = null;
            this.tbMotivoCon.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.tbMotivoCon.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMotivoCon.CustomButton.Name = "";
            this.tbMotivoCon.CustomButton.Size = new System.Drawing.Size(116, 107);
            this.tbMotivoCon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMotivoCon.CustomButton.TabIndex = 1;
            this.tbMotivoCon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMotivoCon.CustomButton.UseSelectable = true;
            this.tbMotivoCon.CustomButton.Visible = false;
            this.tbMotivoCon.Lines = new string[0];
            this.tbMotivoCon.Location = new System.Drawing.Point(400, 302);
            this.tbMotivoCon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMotivoCon.MaxLength = 32767;
            this.tbMotivoCon.Multiline = true;
            this.tbMotivoCon.Name = "tbMotivoCon";
            this.tbMotivoCon.PasswordChar = '\0';
            this.tbMotivoCon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMotivoCon.SelectedText = "";
            this.tbMotivoCon.SelectionLength = 0;
            this.tbMotivoCon.SelectionStart = 0;
            this.tbMotivoCon.ShortcutsEnabled = true;
            this.tbMotivoCon.Size = new System.Drawing.Size(200, 92);
            this.tbMotivoCon.TabIndex = 9;
            this.tbMotivoCon.UseSelectable = true;
            this.tbMotivoCon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMotivoCon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDiagnostico
            // 
            // 
            // 
            // 
            this.tbDiagnostico.CustomButton.Image = null;
            this.tbDiagnostico.CustomButton.Location = new System.Drawing.Point(-16, 1);
            this.tbDiagnostico.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDiagnostico.CustomButton.Name = "";
            this.tbDiagnostico.CustomButton.Size = new System.Drawing.Size(281, 260);
            this.tbDiagnostico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDiagnostico.CustomButton.TabIndex = 1;
            this.tbDiagnostico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDiagnostico.CustomButton.UseSelectable = true;
            this.tbDiagnostico.CustomButton.Visible = false;
            this.tbDiagnostico.Lines = new string[0];
            this.tbDiagnostico.Location = new System.Drawing.Point(800, 181);
            this.tbDiagnostico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDiagnostico.MaxLength = 32767;
            this.tbDiagnostico.Multiline = true;
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.PasswordChar = '\0';
            this.tbDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDiagnostico.SelectedText = "";
            this.tbDiagnostico.SelectionLength = 0;
            this.tbDiagnostico.SelectionStart = 0;
            this.tbDiagnostico.ShortcutsEnabled = true;
            this.tbDiagnostico.Size = new System.Drawing.Size(200, 213);
            this.tbDiagnostico.TabIndex = 10;
            this.tbDiagnostico.UseSelectable = true;
            this.tbDiagnostico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDiagnostico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(693, 473);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseCustomForeColor = true;
            this.btnGuardar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(801, 473);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 12;
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
            this.btnVolver.Location = new System.Drawing.Point(909, 473);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 13;
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
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(0, 80);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1067, 43);
            this.metroPanel1.TabIndex = 23;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 480);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecCita
            // 
            this.lblFecCita.AutoSize = true;
            this.lblFecCita.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFecCita.Location = new System.Drawing.Point(400, 154);
            this.lblFecCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecCita.Name = "lblFecCita";
            this.lblFecCita.Size = new System.Drawing.Size(101, 20);
            this.lblFecCita.TabIndex = 29;
            this.lblFecCita.Text = "Fecha de Cita";
            // 
            // dtFecCita
            // 
            this.dtFecCita.Location = new System.Drawing.Point(400, 181);
            this.dtFecCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFecCita.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtFecCita.Name = "dtFecCita";
            this.dtFecCita.Size = new System.Drawing.Size(199, 30);
            this.dtFecCita.TabIndex = 30;
            // 
            // ExpedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtFecCita);
            this.Controls.Add(this.lblFecCita);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ExpedForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Crear o Actualizar Expediente Médico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpedForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblInstruccion;
        private MetroFramework.Controls.MetroLabel lblIdExped;
        private MetroFramework.Controls.MetroTextBox tbIdExped;
        private MetroFramework.Controls.MetroLabel lblNombrePac;
        private MetroFramework.Controls.MetroTextBox tbNombrePac;
        private MetroFramework.Controls.MetroLabel lblApellidoPac;
        private MetroFramework.Controls.MetroTextBox tbApellidoPac;
        private MetroFramework.Controls.MetroLabel lblMotivo;
        private MetroFramework.Controls.MetroLabel lblDiagnostico;
        private MetroFramework.Controls.MetroTextBox tbMotivoCon;
        private MetroFramework.Controls.MetroTextBox tbDiagnostico;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblFecCita;
        private MetroFramework.Controls.MetroDateTime dtFecCita;
    }
}