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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMedTech = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSeleccion = new MetroFramework.Controls.MetroLabel();
            this.btnAggCita = new MetroFramework.Controls.MetroButton();
            this.btnAggPaciente = new MetroFramework.Controls.MetroButton();
            this.btnExped = new MetroFramework.Controls.MetroButton();
            this.btnAyuda = new MetroFramework.Controls.MetroButton();
            this.btnCerrSesion = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblMedTech);
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.lblMedTech.Location = new System.Drawing.Point(70, 15);
            this.lblMedTech.Name = "lblMedTech";
            this.lblMedTech.Size = new System.Drawing.Size(89, 25);
            this.lblMedTech.TabIndex = 1;
            this.lblMedTech.Text = "MedTech";
            this.lblMedTech.UseCustomBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedTech.Properties.Resources.Logotipo_medtech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSeleccion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSeleccion.Location = new System.Drawing.Point(250, 150);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(295, 25);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione que acción desea realizar";
            // 
            // btnAggCita
            // 
            this.btnAggCita.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggCita.Location = new System.Drawing.Point(290, 200);
            this.btnAggCita.Name = "btnAggCita";
            this.btnAggCita.Size = new System.Drawing.Size(220, 40);
            this.btnAggCita.TabIndex = 2;
            this.btnAggCita.Text = "Agregar y Agendar Cita";
            this.btnAggCita.UseCustomBackColor = true;
            this.btnAggCita.UseSelectable = true;
            this.btnAggCita.Click += new System.EventHandler(this.btnAggRegCita_Click);
            // 
            // btnAggPaciente
            // 
            this.btnAggPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggPaciente.Location = new System.Drawing.Point(290, 246);
            this.btnAggPaciente.Name = "btnAggPaciente";
            this.btnAggPaciente.Size = new System.Drawing.Size(220, 40);
            this.btnAggPaciente.TabIndex = 3;
            this.btnAggPaciente.Text = "Agregar Paciente";
            this.btnAggPaciente.UseCustomBackColor = true;
            this.btnAggPaciente.UseSelectable = true;
            this.btnAggPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnExped
            // 
            this.btnExped.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExped.Location = new System.Drawing.Point(290, 292);
            this.btnExped.Name = "btnExped";
            this.btnExped.Size = new System.Drawing.Size(220, 40);
            this.btnExped.TabIndex = 4;
            this.btnExped.Text = "Crear o Actualizar Expediente Médico";
            this.btnExped.UseCustomBackColor = true;
            this.btnExped.UseSelectable = true;
            this.btnExped.Click += new System.EventHandler(this.btnExpedMed_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(697, 402);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(80, 25);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseSelectable = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCerrSesion
            // 
            this.btnCerrSesion.Location = new System.Drawing.Point(611, 402);
            this.btnCerrSesion.Name = "btnCerrSesion";
            this.btnCerrSesion.Size = new System.Drawing.Size(80, 25);
            this.btnCerrSesion.TabIndex = 10;
            this.btnCerrSesion.Text = "Cerrar Sesión";
            this.btnCerrSesion.UseSelectable = true;
            this.btnCerrSesion.Click += new System.EventHandler(this.btnCerrSesion_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblMedTech;
        private MetroFramework.Controls.MetroLabel lblSeleccion;
        private MetroFramework.Controls.MetroButton btnAggCita;
        private MetroFramework.Controls.MetroButton btnAggPaciente;
        private MetroFramework.Controls.MetroButton btnExped;
        private MetroFramework.Controls.MetroButton btnAyuda;
        private MetroFramework.Controls.MetroButton btnCerrSesion;
    }
}