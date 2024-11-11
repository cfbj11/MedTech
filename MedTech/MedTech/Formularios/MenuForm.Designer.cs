namespace MedTech.Formularios
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
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
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblMedTech
            // 
            this.lblMedTech.AutoSize = true;
            this.lblMedTech.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMedTech.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMedTech.Location = new System.Drawing.Point(93, 18);
            this.lblMedTech.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedTech.Name = "lblMedTech";
            this.lblMedTech.Size = new System.Drawing.Size(89, 25);
            this.lblMedTech.TabIndex = 1;
            this.lblMedTech.Text = "MedTech";
            this.lblMedTech.UseCustomBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSeleccion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSeleccion.Location = new System.Drawing.Point(333, 185);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(295, 25);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione que acción desea realizar";
            // 
            // btnAggCita
            // 
            this.btnAggCita.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggCita.Location = new System.Drawing.Point(387, 246);
            this.btnAggCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggCita.Name = "btnAggCita";
            this.btnAggCita.Size = new System.Drawing.Size(293, 49);
            this.btnAggCita.TabIndex = 2;
            this.btnAggCita.Text = "Agregar y Agendar Cita";
            this.btnAggCita.UseCustomBackColor = true;
            this.btnAggCita.UseSelectable = true;
            this.btnAggCita.Click += new System.EventHandler(this.btnAggRegCita_Click);
            // 
            // btnAggPaciente
            // 
            this.btnAggPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAggPaciente.Location = new System.Drawing.Point(387, 303);
            this.btnAggPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggPaciente.Name = "btnAggPaciente";
            this.btnAggPaciente.Size = new System.Drawing.Size(293, 49);
            this.btnAggPaciente.TabIndex = 3;
            this.btnAggPaciente.Text = "Agregar Paciente";
            this.btnAggPaciente.UseCustomBackColor = true;
            this.btnAggPaciente.UseSelectable = true;
            this.btnAggPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnExped
            // 
            this.btnExped.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExped.Location = new System.Drawing.Point(387, 359);
            this.btnExped.Margin = new System.Windows.Forms.Padding(4);
            this.btnExped.Name = "btnExped";
            this.btnExped.Size = new System.Drawing.Size(293, 49);
            this.btnExped.TabIndex = 4;
            this.btnExped.Text = "Crear o Actualizar Expediente Médico";
            this.btnExped.UseCustomBackColor = true;
            this.btnExped.UseSelectable = true;
            this.btnExped.Click += new System.EventHandler(this.btnExpedMed_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(929, 495);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(107, 31);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseSelectable = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCerrSesion
            // 
            this.btnCerrSesion.Location = new System.Drawing.Point(815, 495);
            this.btnCerrSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrSesion.Name = "btnCerrSesion";
            this.btnCerrSesion.Size = new System.Drawing.Size(107, 31);
            this.btnCerrSesion.TabIndex = 10;
            this.btnCerrSesion.Text = "Cerrar Sesión";
            this.btnCerrSesion.UseSelectable = true;
            this.btnCerrSesion.Click += new System.EventHandler(this.btnCerrSesion_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCerrSesion);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnExped);
            this.Controls.Add(this.btnAggPaciente);
            this.Controls.Add(this.btnAggCita);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Menu";
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