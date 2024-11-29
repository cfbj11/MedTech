namespace MedTech.Formularios
{
    partial class AggCitaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AggCitaFrm));
            this.lblInstruccion = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.tbNombrePac = new MetroFramework.Controls.MetroTextBox();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.tbApellidoPac = new MetroFramework.Controls.MetroTextBox();
            this.lblHoraCita = new MetroFramework.Controls.MetroLabel();
            this.tbHoraCita = new MetroFramework.Controls.MetroTextBox();
            this.lblFecCita = new MetroFramework.Controls.MetroLabel();
            this.dtFechaCita = new MetroFramework.Controls.MetroDateTime();
            this.lblDoctor = new MetroFramework.Controls.MetroLabel();
            this.tbDoctor = new MetroFramework.Controls.MetroTextBox();
            this.lblEspecialidad = new MetroFramework.Controls.MetroLabel();
            this.cbEspecialidad = new MetroFramework.Controls.MetroComboBox();
            this.lblContacto = new MetroFramework.Controls.MetroLabel();
            this.cbxTelefono = new MetroFramework.Controls.MetroCheckBox();
            this.cbxCorreo = new MetroFramework.Controls.MetroCheckBox();
            this.tbContacto = new MetroFramework.Controls.MetroTextBox();
            this.lblCosto = new MetroFramework.Controls.MetroLabel();
            this.tbCosto = new MetroFramework.Controls.MetroTextBox();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblIdPaciente = new MetroFramework.Controls.MetroLabel();
            this.tbIdPaciente = new MetroFramework.Controls.MetroTextBox();
            this.dgvCita = new System.Windows.Forms.DataGridView();
            this.btnReporte = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).BeginInit();
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNombre.Location = new System.Drawing.Point(23, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
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
            this.tbNombrePac.Location = new System.Drawing.Point(23, 142);
            this.tbNombrePac.MaxLength = 32767;
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
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblApellido.Location = new System.Drawing.Point(23, 180);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 19);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
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
            this.tbApellidoPac.Location = new System.Drawing.Point(23, 202);
            this.tbApellidoPac.MaxLength = 32767;
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
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHoraCita.Location = new System.Drawing.Point(23, 315);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(94, 19);
            this.lblHoraCita.TabIndex = 7;
            this.lblHoraCita.Text = "Hora de Cita";
            // 
            // tbHoraCita
            // 
            // 
            // 
            // 
            this.tbHoraCita.CustomButton.Image = null;
            this.tbHoraCita.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbHoraCita.CustomButton.Name = "";
            this.tbHoraCita.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbHoraCita.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbHoraCita.CustomButton.TabIndex = 1;
            this.tbHoraCita.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbHoraCita.CustomButton.UseSelectable = true;
            this.tbHoraCita.CustomButton.Visible = false;
            this.tbHoraCita.Lines = new string[0];
            this.tbHoraCita.Location = new System.Drawing.Point(23, 337);
            this.tbHoraCita.MaxLength = 32767;
            this.tbHoraCita.Name = "tbHoraCita";
            this.tbHoraCita.PasswordChar = '\0';
            this.tbHoraCita.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbHoraCita.SelectedText = "";
            this.tbHoraCita.SelectionLength = 0;
            this.tbHoraCita.SelectionStart = 0;
            this.tbHoraCita.ShortcutsEnabled = true;
            this.tbHoraCita.Size = new System.Drawing.Size(100, 23);
            this.tbHoraCita.TabIndex = 8;
            this.tbHoraCita.UseSelectable = true;
            this.tbHoraCita.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbHoraCita.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbHoraCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoraCita_KeyPress);
            // 
            // lblFecCita
            // 
            this.lblFecCita.AutoSize = true;
            this.lblFecCita.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFecCita.Location = new System.Drawing.Point(23, 247);
            this.lblFecCita.Name = "lblFecCita";
            this.lblFecCita.Size = new System.Drawing.Size(98, 19);
            this.lblFecCita.TabIndex = 5;
            this.lblFecCita.Text = "Fecha de Cita";
            // 
            // dtFechaCita
            // 
            this.dtFechaCita.Location = new System.Drawing.Point(23, 269);
            this.dtFechaCita.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaCita.Name = "dtFechaCita";
            this.dtFechaCita.Size = new System.Drawing.Size(150, 29);
            this.dtFechaCita.TabIndex = 6;
            this.dtFechaCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtFechaCita_KeyPress);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDoctor.Location = new System.Drawing.Point(300, 180);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(55, 19);
            this.lblDoctor.TabIndex = 11;
            this.lblDoctor.Text = "Doctor";
            // 
            // tbDoctor
            // 
            // 
            // 
            // 
            this.tbDoctor.CustomButton.Image = null;
            this.tbDoctor.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbDoctor.CustomButton.Name = "";
            this.tbDoctor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDoctor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDoctor.CustomButton.TabIndex = 1;
            this.tbDoctor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDoctor.CustomButton.UseSelectable = true;
            this.tbDoctor.CustomButton.Visible = false;
            this.tbDoctor.Lines = new string[0];
            this.tbDoctor.Location = new System.Drawing.Point(300, 202);
            this.tbDoctor.MaxLength = 32767;
            this.tbDoctor.Name = "tbDoctor";
            this.tbDoctor.PasswordChar = '\0';
            this.tbDoctor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDoctor.SelectedText = "";
            this.tbDoctor.SelectionLength = 0;
            this.tbDoctor.SelectionStart = 0;
            this.tbDoctor.ShortcutsEnabled = true;
            this.tbDoctor.Size = new System.Drawing.Size(150, 23);
            this.tbDoctor.TabIndex = 12;
            this.tbDoctor.UseSelectable = true;
            this.tbDoctor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDoctor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDoctor_KeyPress);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEspecialidad.Location = new System.Drawing.Point(300, 247);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(92, 19);
            this.lblEspecialidad.TabIndex = 13;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.ItemHeight = 23;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Anestesiología",
            "Cardiología",
            "Cirugía General",
            "Dermatología",
            "Endocrinología",
            "Gerontología",
            "Ginecología",
            "Infectología",
            "Medicina Interna",
            "Nefrología",
            "Neurología",
            "Oncología",
            "Oftalmología",
            "Ortopedia",
            "Otorrinolaringología",
            "Pediatría",
            "Psiquiatría",
            "Radiología",
            "Reumatología",
            "Urología"});
            this.cbEspecialidad.Location = new System.Drawing.Point(300, 269);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(150, 29);
            this.cbEspecialidad.TabIndex = 14;
            this.cbEspecialidad.UseSelectable = true;
            this.cbEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEspecialidad_KeyPress);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblContacto.Location = new System.Drawing.Point(600, 120);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(69, 19);
            this.lblContacto.TabIndex = 15;
            this.lblContacto.Text = "Contacto";
            // 
            // cbxTelefono
            // 
            this.cbxTelefono.AutoSize = true;
            this.cbxTelefono.Location = new System.Drawing.Point(600, 142);
            this.cbxTelefono.Name = "cbxTelefono";
            this.cbxTelefono.Size = new System.Drawing.Size(68, 15);
            this.cbxTelefono.TabIndex = 16;
            this.cbxTelefono.Text = "Teléfono";
            this.cbxTelefono.UseSelectable = true;
            this.cbxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTelefono_KeyPress);
            // 
            // cbxCorreo
            // 
            this.cbxCorreo.AutoSize = true;
            this.cbxCorreo.Location = new System.Drawing.Point(600, 163);
            this.cbxCorreo.Name = "cbxCorreo";
            this.cbxCorreo.Size = new System.Drawing.Size(59, 15);
            this.cbxCorreo.TabIndex = 17;
            this.cbxCorreo.Text = "Correo";
            this.cbxCorreo.UseSelectable = true;
            this.cbxCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCorreo_KeyPress);
            // 
            // tbContacto
            // 
            // 
            // 
            // 
            this.tbContacto.CustomButton.Image = null;
            this.tbContacto.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbContacto.CustomButton.Name = "";
            this.tbContacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbContacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbContacto.CustomButton.TabIndex = 1;
            this.tbContacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbContacto.CustomButton.UseSelectable = true;
            this.tbContacto.CustomButton.Visible = false;
            this.tbContacto.Lines = new string[0];
            this.tbContacto.Location = new System.Drawing.Point(600, 184);
            this.tbContacto.MaxLength = 32767;
            this.tbContacto.Name = "tbContacto";
            this.tbContacto.PasswordChar = '\0';
            this.tbContacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContacto.SelectedText = "";
            this.tbContacto.SelectionLength = 0;
            this.tbContacto.SelectionStart = 0;
            this.tbContacto.ShortcutsEnabled = true;
            this.tbContacto.Size = new System.Drawing.Size(150, 23);
            this.tbContacto.TabIndex = 18;
            this.tbContacto.UseSelectable = true;
            this.tbContacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbContacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContacto_KeyPress);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCosto.Location = new System.Drawing.Point(600, 247);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(145, 19);
            this.lblCosto.TabIndex = 19;
            this.lblCosto.Text = "Costo de la Consulta";
            // 
            // tbCosto
            // 
            // 
            // 
            // 
            this.tbCosto.CustomButton.Image = null;
            this.tbCosto.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbCosto.CustomButton.Name = "";
            this.tbCosto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCosto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCosto.CustomButton.TabIndex = 1;
            this.tbCosto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCosto.CustomButton.UseSelectable = true;
            this.tbCosto.CustomButton.Visible = false;
            this.tbCosto.Lines = new string[0];
            this.tbCosto.Location = new System.Drawing.Point(600, 269);
            this.tbCosto.MaxLength = 32767;
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.PasswordChar = '\0';
            this.tbCosto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCosto.SelectedText = "";
            this.tbCosto.SelectionLength = 0;
            this.tbCosto.SelectionStart = 0;
            this.tbCosto.ShortcutsEnabled = true;
            this.tbCosto.Size = new System.Drawing.Size(75, 23);
            this.tbCosto.TabIndex = 20;
            this.tbCosto.UseSelectable = true;
            this.tbCosto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCosto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCosto_KeyPress);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(682, 384);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseCustomBackColor = true;
            this.btnVolver.UseCustomForeColor = true;
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(601, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseCustomBackColor = true;
            this.btnCancelar.UseCustomForeColor = true;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(520, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseCustomForeColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.metroPanel1.TabIndex = 22;
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
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIdPaciente.Location = new System.Drawing.Point(300, 120);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(84, 19);
            this.lblIdPaciente.TabIndex = 9;
            this.lblIdPaciente.Text = "ID Paciente";
            // 
            // tbIdPaciente
            // 
            // 
            // 
            // 
            this.tbIdPaciente.CustomButton.Image = null;
            this.tbIdPaciente.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbIdPaciente.CustomButton.Name = "";
            this.tbIdPaciente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIdPaciente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIdPaciente.CustomButton.TabIndex = 1;
            this.tbIdPaciente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIdPaciente.CustomButton.UseSelectable = true;
            this.tbIdPaciente.CustomButton.Visible = false;
            this.tbIdPaciente.Lines = new string[0];
            this.tbIdPaciente.Location = new System.Drawing.Point(300, 142);
            this.tbIdPaciente.MaxLength = 32767;
            this.tbIdPaciente.Name = "tbIdPaciente";
            this.tbIdPaciente.PasswordChar = '\0';
            this.tbIdPaciente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIdPaciente.SelectedText = "";
            this.tbIdPaciente.SelectionLength = 0;
            this.tbIdPaciente.SelectionStart = 0;
            this.tbIdPaciente.ShortcutsEnabled = true;
            this.tbIdPaciente.Size = new System.Drawing.Size(100, 23);
            this.tbIdPaciente.TabIndex = 10;
            this.tbIdPaciente.UseSelectable = true;
            this.tbIdPaciente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIdPaciente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbIdPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdPaciente_KeyPress);
            // 
            // dgvCita
            // 
            this.dgvCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCita.Location = new System.Drawing.Point(23, 413);
            this.dgvCita.Name = "dgvCita";
            this.dgvCita.Size = new System.Drawing.Size(737, 164);
            this.dgvCita.TabIndex = 25;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(23, 384);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 21;
            this.btnReporte.Text = "Ver Reporte";
            this.btnReporte.UseCustomBackColor = true;
            this.btnReporte.UseCustomForeColor = true;
            this.btnReporte.UseSelectable = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // AggCitaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvCita);
            this.Controls.Add(this.tbIdPaciente);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.tbContacto);
            this.Controls.Add(this.cbxCorreo);
            this.Controls.Add(this.cbxTelefono);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.tbDoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.dtFechaCita);
            this.Controls.Add(this.lblFecCita);
            this.Controls.Add(this.tbHoraCita);
            this.Controls.Add(this.lblHoraCita);
            this.Controls.Add(this.tbApellidoPac);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombrePac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AggCitaFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AggCitaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblInstruccion;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroLabel lblHoraCita;
        private MetroFramework.Controls.MetroLabel lblFecCita;
        private MetroFramework.Controls.MetroLabel lblDoctor;
        private MetroFramework.Controls.MetroLabel lblEspecialidad;
        private MetroFramework.Controls.MetroLabel lblContacto;
        private MetroFramework.Controls.MetroLabel lblCosto;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroLabel lblIdPaciente;
        internal MetroFramework.Controls.MetroTextBox tbNombrePac;
        internal MetroFramework.Controls.MetroTextBox tbApellidoPac;
        internal MetroFramework.Controls.MetroTextBox tbHoraCita;
        internal MetroFramework.Controls.MetroDateTime dtFechaCita;
        internal MetroFramework.Controls.MetroTextBox tbDoctor;
        internal MetroFramework.Controls.MetroComboBox cbEspecialidad;
        internal MetroFramework.Controls.MetroCheckBox cbxTelefono;
        internal MetroFramework.Controls.MetroCheckBox cbxCorreo;
        internal MetroFramework.Controls.MetroTextBox tbContacto;
        internal MetroFramework.Controls.MetroTextBox tbCosto;
        internal MetroFramework.Controls.MetroTextBox tbIdPaciente;
        internal System.Windows.Forms.DataGridView dgvCita;
        private MetroFramework.Controls.MetroButton btnReporte;
    }
}