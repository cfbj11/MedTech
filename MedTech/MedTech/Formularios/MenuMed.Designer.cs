namespace MedTech.Formularios
{
    partial class MenuMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMed));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAggRegCita = new MetroFramework.Controls.MetroButton();
            this.btnPaciente = new MetroFramework.Controls.MetroButton();
            this.btnExpedMed = new MetroFramework.Controls.MetroButton();
            this.btnAyuda = new MetroFramework.Controls.MetroButton();
            this.btnCerrSesion = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(70, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "MedTech";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(250, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(295, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Seleccione que acción desea realizar";
            // 
            // btnAggRegCita
            // 
            this.btnAggRegCita.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggRegCita.Location = new System.Drawing.Point(290, 200);
            this.btnAggRegCita.Name = "btnAggRegCita";
            this.btnAggRegCita.Size = new System.Drawing.Size(220, 40);
            this.btnAggRegCita.TabIndex = 2;
            this.btnAggRegCita.Text = "Agregar y Agendar Cita";
            this.btnAggRegCita.UseCustomBackColor = true;
            this.btnAggRegCita.UseSelectable = true;
            this.btnAggRegCita.Click += new System.EventHandler(this.btnAggRegCita_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPaciente.Location = new System.Drawing.Point(290, 246);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(220, 40);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "Agregar Paciente";
            this.btnPaciente.UseCustomBackColor = true;
            this.btnPaciente.UseSelectable = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnExpedMed
            // 
            this.btnExpedMed.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExpedMed.Location = new System.Drawing.Point(290, 292);
            this.btnExpedMed.Name = "btnExpedMed";
            this.btnExpedMed.Size = new System.Drawing.Size(220, 40);
            this.btnExpedMed.TabIndex = 4;
            this.btnExpedMed.Text = "Crear o Actualizar Expediente Médico";
            this.btnExpedMed.UseCustomBackColor = true;
            this.btnExpedMed.UseSelectable = true;
            this.btnExpedMed.Click += new System.EventHandler(this.btnExpedMed_Click);
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
            // MenuMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrSesion);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnExpedMed);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnAggRegCita);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuMed";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAggRegCita;
        private MetroFramework.Controls.MetroButton btnPaciente;
        private MetroFramework.Controls.MetroButton btnExpedMed;
        private MetroFramework.Controls.MetroButton btnAyuda;
        private MetroFramework.Controls.MetroButton btnCerrSesion;
    }
}