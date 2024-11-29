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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMedTech = new MetroFramework.Controls.MetroLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblSeleccion = new MetroFramework.Controls.MetroLabel();
            this.btnAggCita = new MetroFramework.Controls.MetroButton();
            this.btnAggPaciente = new MetroFramework.Controls.MetroButton();
            this.btnExped = new MetroFramework.Controls.MetroButton();
            this.btnAyuda = new MetroFramework.Controls.MetroButton();
            this.btnCerrSesion = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFechaHora = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblFechaHora);
            this.panel1.Controls.Add(this.lblMedTech);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblMedTech
            // 
            this.lblMedTech.AutoSize = true;
            this.lblMedTech.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMedTech.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMedTech.ForeColor = System.Drawing.Color.White;
            this.lblMedTech.Location = new System.Drawing.Point(70, 15);
            this.lblMedTech.Name = "lblMedTech";
            this.lblMedTech.Size = new System.Drawing.Size(89, 25);
            this.lblMedTech.TabIndex = 1;
            this.lblMedTech.Text = "MedTech";
            this.lblMedTech.UseCustomBackColor = true;
            this.lblMedTech.UseCustomForeColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MedTech.Properties.Resources.Logotipo_medtech;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSeleccion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSeleccion.Location = new System.Drawing.Point(240, 150);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(321, 25);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione que acción desea realizar";
            // 
            // btnAggCita
            // 
            this.btnAggCita.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggCita.ForeColor = System.Drawing.Color.White;
            this.btnAggCita.Location = new System.Drawing.Point(240, 200);
            this.btnAggCita.Name = "btnAggCita";
            this.btnAggCita.Size = new System.Drawing.Size(321, 40);
            this.btnAggCita.TabIndex = 2;
            this.btnAggCita.Text = "Agregar y Agendar Cita";
            this.btnAggCita.UseCustomBackColor = true;
            this.btnAggCita.UseCustomForeColor = true;
            this.btnAggCita.UseSelectable = true;
            this.btnAggCita.Click += new System.EventHandler(this.btnAggRegCita_Click);
            // 
            // btnAggPaciente
            // 
            this.btnAggPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggPaciente.ForeColor = System.Drawing.Color.White;
            this.btnAggPaciente.Location = new System.Drawing.Point(240, 246);
            this.btnAggPaciente.Name = "btnAggPaciente";
            this.btnAggPaciente.Size = new System.Drawing.Size(321, 40);
            this.btnAggPaciente.TabIndex = 3;
            this.btnAggPaciente.Text = "Agregar Paciente";
            this.btnAggPaciente.UseCustomBackColor = true;
            this.btnAggPaciente.UseCustomForeColor = true;
            this.btnAggPaciente.UseSelectable = true;
            this.btnAggPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnExped
            // 
            this.btnExped.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExped.ForeColor = System.Drawing.Color.White;
            this.btnExped.Location = new System.Drawing.Point(240, 292);
            this.btnExped.Name = "btnExped";
            this.btnExped.Size = new System.Drawing.Size(321, 40);
            this.btnExped.TabIndex = 4;
            this.btnExped.Text = "Crear o Actualizar Expediente Médico";
            this.btnExped.UseCustomBackColor = true;
            this.btnExped.UseCustomForeColor = true;
            this.btnExped.UseSelectable = true;
            this.btnExped.Click += new System.EventHandler(this.btnExpedMed_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(697, 402);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(80, 25);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseCustomBackColor = true;
            this.btnAyuda.UseCustomForeColor = true;
            this.btnAyuda.UseSelectable = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCerrSesion
            // 
            this.btnCerrSesion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCerrSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrSesion.Location = new System.Drawing.Point(611, 402);
            this.btnCerrSesion.Name = "btnCerrSesion";
            this.btnCerrSesion.Size = new System.Drawing.Size(80, 25);
            this.btnCerrSesion.TabIndex = 10;
            this.btnCerrSesion.Text = "Cerrar Sesión";
            this.btnCerrSesion.UseCustomBackColor = true;
            this.btnCerrSesion.UseCustomForeColor = true;
            this.btnCerrSesion.UseSelectable = true;
            this.btnCerrSesion.Click += new System.EventHandler(this.btnCerrSesion_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFechaHora.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFechaHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaHora.Location = new System.Drawing.Point(679, 5);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(118, 25);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "Fecha: Hora:";
            this.lblFechaHora.UseCustomBackColor = true;
            this.lblFechaHora.UseCustomForeColor = true;
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrSesion);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnExped);
            this.Controls.Add(this.btnAggPaciente);
            this.Controls.Add(this.btnAggCita);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}