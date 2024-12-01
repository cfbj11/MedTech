namespace MedTech.Formularios
{
    partial class MenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            this.lblFechaHora = new MetroFramework.Controls.MetroLabel();
            this.lblMedTech = new MetroFramework.Controls.MetroLabel();
            this.lblSeleccion = new MetroFramework.Controls.MetroLabel();
            this.btnAggCita = new MetroFramework.Controls.MetroButton();
            this.btnAggPaciente = new MetroFramework.Controls.MetroButton();
            this.btnExped = new MetroFramework.Controls.MetroButton();
            this.btnAyuda = new MetroFramework.Controls.MetroButton();
            this.btnCerrSesion = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbAyuda = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbExpediente = new System.Windows.Forms.PictureBox();
            this.pbAggPaciente = new System.Windows.Forms.PictureBox();
            this.pbAggCita = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAggPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAggCita)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.BackColor = System.Drawing.Color.White;
            this.lblFechaHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFechaHora.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFechaHora.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblFechaHora.Location = new System.Drawing.Point(682, 33);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(118, 25);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "Fecha: Hora:";
            this.lblFechaHora.UseCustomBackColor = true;
            this.lblFechaHora.UseCustomForeColor = true;
            // 
            // lblMedTech
            // 
            this.lblMedTech.AutoSize = true;
            this.lblMedTech.BackColor = System.Drawing.Color.White;
            this.lblMedTech.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMedTech.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMedTech.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblMedTech.Location = new System.Drawing.Point(66, 47);
            this.lblMedTech.Name = "lblMedTech";
            this.lblMedTech.Size = new System.Drawing.Size(89, 25);
            this.lblMedTech.TabIndex = 1;
            this.lblMedTech.Text = "MedTech";
            this.lblMedTech.UseCustomBackColor = true;
            this.lblMedTech.UseCustomForeColor = true;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblSeleccion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSeleccion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSeleccion.ForeColor = System.Drawing.Color.White;
            this.lblSeleccion.Location = new System.Drawing.Point(240, 125);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(321, 25);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione que acción desea realizar";
            this.lblSeleccion.UseCustomBackColor = true;
            this.lblSeleccion.UseCustomForeColor = true;
            // 
            // btnAggCita
            // 
            this.btnAggCita.BackColor = System.Drawing.Color.White;
            this.btnAggCita.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggCita.Location = new System.Drawing.Point(240, 200);
            this.btnAggCita.Name = "btnAggCita";
            this.btnAggCita.Size = new System.Drawing.Size(275, 40);
            this.btnAggCita.TabIndex = 1;
            this.btnAggCita.Text = "Agregar y Agendar Cita";
            this.btnAggCita.UseCustomBackColor = true;
            this.btnAggCita.UseCustomForeColor = true;
            this.btnAggCita.UseSelectable = true;
            this.btnAggCita.Click += new System.EventHandler(this.btnAggRegCita_Click);
            // 
            // btnAggPaciente
            // 
            this.btnAggPaciente.BackColor = System.Drawing.Color.White;
            this.btnAggPaciente.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggPaciente.Location = new System.Drawing.Point(240, 156);
            this.btnAggPaciente.Name = "btnAggPaciente";
            this.btnAggPaciente.Size = new System.Drawing.Size(275, 40);
            this.btnAggPaciente.TabIndex = 2;
            this.btnAggPaciente.Text = "Agregar Paciente";
            this.btnAggPaciente.UseCustomBackColor = true;
            this.btnAggPaciente.UseCustomForeColor = true;
            this.btnAggPaciente.UseSelectable = true;
            this.btnAggPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnExped
            // 
            this.btnExped.BackColor = System.Drawing.Color.White;
            this.btnExped.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnExped.Location = new System.Drawing.Point(240, 292);
            this.btnExped.Name = "btnExped";
            this.btnExped.Size = new System.Drawing.Size(275, 40);
            this.btnExped.TabIndex = 3;
            this.btnExped.Text = "Crear o Actualizar Expediente Médico";
            this.btnExped.UseCustomBackColor = true;
            this.btnExped.UseCustomForeColor = true;
            this.btnExped.UseSelectable = true;
            this.btnExped.Click += new System.EventHandler(this.btnExpedMed_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.White;
            this.btnAyuda.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyuda.Location = new System.Drawing.Point(677, 281);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(100, 25);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseCustomBackColor = true;
            this.btnAyuda.UseCustomForeColor = true;
            this.btnAyuda.UseSelectable = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCerrSesion
            // 
            this.btnCerrSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrSesion.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCerrSesion.Location = new System.Drawing.Point(677, 312);
            this.btnCerrSesion.Name = "btnCerrSesion";
            this.btnCerrSesion.Size = new System.Drawing.Size(100, 25);
            this.btnCerrSesion.TabIndex = 5;
            this.btnCerrSesion.Text = "Cerrar Sesión";
            this.btnCerrSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrSesion.UseCustomBackColor = true;
            this.btnCerrSesion.UseCustomForeColor = true;
            this.btnCerrSesion.UseSelectable = true;
            this.btnCerrSesion.Click += new System.EventHandler(this.btnCerrSesion_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pbAyuda);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Controls.Add(this.pbExpediente);
            this.panel1.Controls.Add(this.btnCerrSesion);
            this.panel1.Controls.Add(this.pbAggPaciente);
            this.panel1.Controls.Add(this.btnAggPaciente);
            this.panel1.Controls.Add(this.pbAggCita);
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 360);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MedTech.Properties.Resources.historial_medico;
            this.pictureBox4.Location = new System.Drawing.Point(521, 202);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MedTech.Properties.Resources.hospitalizacion;
            this.pictureBox5.Location = new System.Drawing.Point(521, 156);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MedTech.Properties.Resources.cita;
            this.pictureBox6.Location = new System.Drawing.Point(521, 110);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MedTech.Properties.Resources.Logotipo_medtech;
            this.pbLogo.Location = new System.Drawing.Point(0, 30);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbAyuda
            // 
            this.pbAyuda.BackColor = System.Drawing.Color.White;
            this.pbAyuda.Image = global::MedTech.Properties.Resources.informacion;
            this.pbAyuda.Location = new System.Drawing.Point(678, 282);
            this.pbAyuda.Name = "pbAyuda";
            this.pbAyuda.Size = new System.Drawing.Size(23, 23);
            this.pbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAyuda.TabIndex = 12;
            this.pbAyuda.TabStop = false;
            this.pbAyuda.Click += new System.EventHandler(this.pbAyuda_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.White;
            this.pbCerrar.Image = global::MedTech.Properties.Resources.cerrar_sesion;
            this.pbCerrar.Location = new System.Drawing.Point(678, 313);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(23, 23);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 11;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbExpediente
            // 
            this.pbExpediente.Image = global::MedTech.Properties.Resources.historial_medico;
            this.pbExpediente.Location = new System.Drawing.Point(521, 202);
            this.pbExpediente.Name = "pbExpediente";
            this.pbExpediente.Size = new System.Drawing.Size(40, 40);
            this.pbExpediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExpediente.TabIndex = 5;
            this.pbExpediente.TabStop = false;
            // 
            // pbAggPaciente
            // 
            this.pbAggPaciente.Image = global::MedTech.Properties.Resources.hospitalizacion;
            this.pbAggPaciente.Location = new System.Drawing.Point(521, 156);
            this.pbAggPaciente.Name = "pbAggPaciente";
            this.pbAggPaciente.Size = new System.Drawing.Size(40, 40);
            this.pbAggPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAggPaciente.TabIndex = 4;
            this.pbAggPaciente.TabStop = false;
            // 
            // pbAggCita
            // 
            this.pbAggCita.Image = global::MedTech.Properties.Resources.cita;
            this.pbAggCita.Location = new System.Drawing.Point(521, 110);
            this.pbAggCita.Name = "pbAggCita";
            this.pbAggCita.Size = new System.Drawing.Size(40, 40);
            this.pbAggCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAggCita.TabIndex = 3;
            this.pbAggCita.TabStop = false;
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExped);
            this.Controls.Add(this.lblMedTech);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.btnAggCita);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAggPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAggCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroLabel lblMedTech;
        private MetroFramework.Controls.MetroLabel lblSeleccion;
        private MetroFramework.Controls.MetroButton btnAggCita;
        private MetroFramework.Controls.MetroButton btnAggPaciente;
        private MetroFramework.Controls.MetroButton btnExped;
        private MetroFramework.Controls.MetroButton btnAyuda;
        private MetroFramework.Controls.MetroButton btnCerrSesion;
        private MetroFramework.Controls.MetroLabel lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pbAggCita;
        private System.Windows.Forms.PictureBox pbAggPaciente;
        private System.Windows.Forms.PictureBox pbExpediente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbAyuda;
    }
}