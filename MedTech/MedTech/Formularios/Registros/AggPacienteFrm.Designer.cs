namespace MedTech.Formularios
{
    partial class AggPacienteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AggPacienteFrm));
            this.lblNombrePac = new MetroFramework.Controls.MetroLabel();
            this.tbNombrePac = new MetroFramework.Controls.MetroTextBox();
            this.lblApellidoPac = new MetroFramework.Controls.MetroLabel();
            this.tbApellidoPac = new MetroFramework.Controls.MetroTextBox();
            this.lblFechaNac = new MetroFramework.Controls.MetroLabel();
            this.dtFechaNac = new MetroFramework.Controls.MetroDateTime();
            this.lblAntecedentes = new MetroFramework.Controls.MetroLabel();
            this.lblEnfermedades = new MetroFramework.Controls.MetroLabel();
            this.tbEnfermedades = new MetroFramework.Controls.MetroTextBox();
            this.btnAñadir = new MetroFramework.Controls.MetroButton();
            this.lblAlerCir = new MetroFramework.Controls.MetroLabel();
            this.cbxAlergias = new MetroFramework.Controls.MetroCheckBox();
            this.cbxCirugias = new MetroFramework.Controls.MetroCheckBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.lblInstruccion = new MetroFramework.Controls.MetroLabel();
            this.tbAntecedentes = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbEnfermedades = new System.Windows.Forms.ListBox();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.btnReporte = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePac
            // 
            this.lblNombrePac.AutoSize = true;
            this.lblNombrePac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNombrePac.Location = new System.Drawing.Point(150, 120);
            this.lblNombrePac.Name = "lblNombrePac";
            this.lblNombrePac.Size = new System.Drawing.Size(151, 19);
            this.lblNombrePac.TabIndex = 1;
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
            this.tbNombrePac.Location = new System.Drawing.Point(149, 142);
            this.tbNombrePac.MaxLength = 50;
            this.tbNombrePac.Name = "tbNombrePac";
            this.tbNombrePac.PasswordChar = '\0';
            this.tbNombrePac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombrePac.SelectedText = "";
            this.tbNombrePac.SelectionLength = 0;
            this.tbNombrePac.SelectionStart = 0;
            this.tbNombrePac.ShortcutsEnabled = true;
            this.tbNombrePac.Size = new System.Drawing.Size(150, 23);
            this.tbNombrePac.TabIndex = 2;
            this.tbNombrePac.UseSelectable = true;
            this.tbNombrePac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombrePac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombrePac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombrePac_KeyPress);
            // 
            // lblApellidoPac
            // 
            this.lblApellidoPac.AutoSize = true;
            this.lblApellidoPac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblApellidoPac.Location = new System.Drawing.Point(150, 180);
            this.lblApellidoPac.Name = "lblApellidoPac";
            this.lblApellidoPac.Size = new System.Drawing.Size(152, 19);
            this.lblApellidoPac.TabIndex = 3;
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
            this.tbApellidoPac.Location = new System.Drawing.Point(149, 202);
            this.tbApellidoPac.MaxLength = 50;
            this.tbApellidoPac.Name = "tbApellidoPac";
            this.tbApellidoPac.PasswordChar = '\0';
            this.tbApellidoPac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbApellidoPac.SelectedText = "";
            this.tbApellidoPac.SelectionLength = 0;
            this.tbApellidoPac.SelectionStart = 0;
            this.tbApellidoPac.ShortcutsEnabled = true;
            this.tbApellidoPac.Size = new System.Drawing.Size(150, 23);
            this.tbApellidoPac.TabIndex = 4;
            this.tbApellidoPac.UseSelectable = true;
            this.tbApellidoPac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbApellidoPac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbApellidoPac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidoPac_KeyPress);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFechaNac.Location = new System.Drawing.Point(150, 240);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(149, 19);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(149, 260);
            this.dtFechaNac.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(150, 29);
            this.dtFechaNac.TabIndex = 6;
            this.dtFechaNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtFechaNac_KeyPress);
            // 
            // lblAntecedentes
            // 
            this.lblAntecedentes.AutoSize = true;
            this.lblAntecedentes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAntecedentes.Location = new System.Drawing.Point(150, 300);
            this.lblAntecedentes.Name = "lblAntecedentes";
            this.lblAntecedentes.Size = new System.Drawing.Size(99, 19);
            this.lblAntecedentes.TabIndex = 7;
            this.lblAntecedentes.Text = "Antecedentes";
            // 
            // lblEnfermedades
            // 
            this.lblEnfermedades.AutoSize = true;
            this.lblEnfermedades.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEnfermedades.Location = new System.Drawing.Point(400, 120);
            this.lblEnfermedades.Name = "lblEnfermedades";
            this.lblEnfermedades.Size = new System.Drawing.Size(104, 19);
            this.lblEnfermedades.TabIndex = 9;
            this.lblEnfermedades.Text = "Enfermedades";
            // 
            // tbEnfermedades
            // 
            // 
            // 
            // 
            this.tbEnfermedades.CustomButton.Image = null;
            this.tbEnfermedades.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbEnfermedades.CustomButton.Name = "";
            this.tbEnfermedades.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEnfermedades.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEnfermedades.CustomButton.TabIndex = 1;
            this.tbEnfermedades.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEnfermedades.CustomButton.UseSelectable = true;
            this.tbEnfermedades.CustomButton.Visible = false;
            this.tbEnfermedades.Lines = new string[0];
            this.tbEnfermedades.Location = new System.Drawing.Point(400, 142);
            this.tbEnfermedades.MaxLength = 50;
            this.tbEnfermedades.Name = "tbEnfermedades";
            this.tbEnfermedades.PasswordChar = '\0';
            this.tbEnfermedades.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEnfermedades.SelectedText = "";
            this.tbEnfermedades.SelectionLength = 0;
            this.tbEnfermedades.SelectionStart = 0;
            this.tbEnfermedades.ShortcutsEnabled = true;
            this.tbEnfermedades.Size = new System.Drawing.Size(150, 23);
            this.tbEnfermedades.TabIndex = 10;
            this.tbEnfermedades.UseSelectable = true;
            this.tbEnfermedades.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEnfermedades.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbEnfermedades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEnfermedades_KeyPress);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(556, 142);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 11;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseSelectable = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            this.btnAñadir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAñadir_KeyPress);
            // 
            // lblAlerCir
            // 
            this.lblAlerCir.AutoSize = true;
            this.lblAlerCir.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAlerCir.Location = new System.Drawing.Point(400, 262);
            this.lblAlerCir.Name = "lblAlerCir";
            this.lblAlerCir.Size = new System.Drawing.Size(169, 19);
            this.lblAlerCir.TabIndex = 14;
            this.lblAlerCir.Text = "Tiene o le han realizado";
            // 
            // cbxAlergias
            // 
            this.cbxAlergias.AutoSize = true;
            this.cbxAlergias.Location = new System.Drawing.Point(400, 284);
            this.cbxAlergias.Name = "cbxAlergias";
            this.cbxAlergias.Size = new System.Drawing.Size(65, 15);
            this.cbxAlergias.TabIndex = 15;
            this.cbxAlergias.Text = "Alergias";
            this.cbxAlergias.UseSelectable = true;
            this.cbxAlergias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAlergias_KeyPress);
            // 
            // cbxCirugias
            // 
            this.cbxCirugias.AutoSize = true;
            this.cbxCirugias.Location = new System.Drawing.Point(400, 305);
            this.cbxCirugias.Name = "cbxCirugias";
            this.cbxCirugias.Size = new System.Drawing.Size(66, 15);
            this.cbxCirugias.TabIndex = 16;
            this.cbxCirugias.Text = "Cirugias";
            this.cbxCirugias.UseSelectable = true;
            this.cbxCirugias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCirugias_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(520, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
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
            this.btnCancelar.TabIndex = 19;
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
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseCustomBackColor = true;
            this.btnVolver.UseCustomForeColor = true;
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.lblInstruccion.TabIndex = 21;
            this.lblInstruccion.Text = "Ingrese los datos";
            this.lblInstruccion.UseCustomBackColor = true;
            this.lblInstruccion.UseCustomForeColor = true;
            // 
            // tbAntecedentes
            // 
            // 
            // 
            // 
            this.tbAntecedentes.CustomButton.Image = null;
            this.tbAntecedentes.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.tbAntecedentes.CustomButton.Name = "";
            this.tbAntecedentes.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.tbAntecedentes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAntecedentes.CustomButton.TabIndex = 1;
            this.tbAntecedentes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAntecedentes.CustomButton.UseSelectable = true;
            this.tbAntecedentes.CustomButton.Visible = false;
            this.tbAntecedentes.Lines = new string[0];
            this.tbAntecedentes.Location = new System.Drawing.Point(149, 322);
            this.tbAntecedentes.MaxLength = 150;
            this.tbAntecedentes.Multiline = true;
            this.tbAntecedentes.Name = "tbAntecedentes";
            this.tbAntecedentes.PasswordChar = '\0';
            this.tbAntecedentes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAntecedentes.SelectedText = "";
            this.tbAntecedentes.SelectionLength = 0;
            this.tbAntecedentes.SelectionStart = 0;
            this.tbAntecedentes.ShortcutsEnabled = true;
            this.tbAntecedentes.Size = new System.Drawing.Size(150, 50);
            this.tbAntecedentes.TabIndex = 8;
            this.tbAntecedentes.UseSelectable = true;
            this.tbAntecedentes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAntecedentes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbAntecedentes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAntecedentes_KeyPress);
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
            this.pbLogo.TabIndex = 25;
            this.pbLogo.TabStop = false;
            // 
            // lbEnfermedades
            // 
            this.lbEnfermedades.FormattingEnabled = true;
            this.lbEnfermedades.Location = new System.Drawing.Point(400, 171);
            this.lbEnfermedades.Name = "lbEnfermedades";
            this.lbEnfermedades.Size = new System.Drawing.Size(231, 69);
            this.lbEnfermedades.TabIndex = 12;
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(23, 413);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.Size = new System.Drawing.Size(734, 164);
            this.dgvPaciente.TabIndex = 21;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(23, 384);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Ver Reporte";
            this.btnReporte.UseCustomBackColor = true;
            this.btnReporte.UseCustomForeColor = true;
            this.btnReporte.UseSelectable = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // AggPacienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.lbEnfermedades);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbAntecedentes);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxCirugias);
            this.Controls.Add(this.cbxAlergias);
            this.Controls.Add(this.lblAlerCir);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.tbEnfermedades);
            this.Controls.Add(this.lblEnfermedades);
            this.Controls.Add(this.lblAntecedentes);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.tbApellidoPac);
            this.Controls.Add(this.lblApellidoPac);
            this.Controls.Add(this.tbNombrePac);
            this.Controls.Add(this.lblNombrePac);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AggPacienteFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AggPacienteForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNombrePac;
        private MetroFramework.Controls.MetroLabel lblApellidoPac;
        private MetroFramework.Controls.MetroLabel lblFechaNac;
        private MetroFramework.Controls.MetroLabel lblAntecedentes;
        private MetroFramework.Controls.MetroLabel lblEnfermedades;
        private MetroFramework.Controls.MetroButton btnAñadir;
        private MetroFramework.Controls.MetroLabel lblAlerCir;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroLabel lblInstruccion;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pbLogo;
        internal MetroFramework.Controls.MetroTextBox tbNombrePac;
        internal MetroFramework.Controls.MetroTextBox tbApellidoPac;
        internal MetroFramework.Controls.MetroDateTime dtFechaNac;
        internal MetroFramework.Controls.MetroTextBox tbEnfermedades;
        internal MetroFramework.Controls.MetroCheckBox cbxAlergias;
        internal MetroFramework.Controls.MetroCheckBox cbxCirugias;
        internal MetroFramework.Controls.MetroTextBox tbAntecedentes;
        internal System.Windows.Forms.ListBox lbEnfermedades;
        internal System.Windows.Forms.DataGridView dgvPaciente;
        private MetroFramework.Controls.MetroButton btnReporte;
    }
}