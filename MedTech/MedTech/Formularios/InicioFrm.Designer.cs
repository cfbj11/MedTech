namespace MedTech.Formularios
{
    partial class InicioFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new MetroFramework.Controls.MetroButton();
            this.tbContraseña = new MetroFramework.Controls.MetroTextBox();
            this.lblContraseña = new MetroFramework.Controls.MetroLabel();
            this.tbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblBienvenida = new MetroFramework.Controls.MetroLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 420);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pbContraseña);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.tbContraseña);
            this.panel2.Controls.Add(this.lblContraseña);
            this.panel2.Controls.Add(this.tbUsuario);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblBienvenida);
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Location = new System.Drawing.Point(23, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 341);
            this.panel2.TabIndex = 0;
            // 
            // pbContraseña
            // 
            this.pbContraseña.Image = global::MedTech.Properties.Resources.show;
            this.pbContraseña.Location = new System.Drawing.Point(471, 217);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(23, 23);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContraseña.TabIndex = 9;
            this.pbContraseña.TabStop = false;
            this.pbContraseña.Click += new System.EventHandler(this.pbContraseña_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(651, 293);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(80, 25);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseSelectable = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // tbContraseña
            // 
            // 
            // 
            // 
            this.tbContraseña.CustomButton.Image = null;
            this.tbContraseña.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.tbContraseña.CustomButton.Name = "";
            this.tbContraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbContraseña.CustomButton.TabIndex = 1;
            this.tbContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbContraseña.CustomButton.UseSelectable = true;
            this.tbContraseña.CustomButton.Visible = false;
            this.tbContraseña.Lines = new string[0];
            this.tbContraseña.Location = new System.Drawing.Point(260, 217);
            this.tbContraseña.MaxLength = 32767;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContraseña.SelectedText = "";
            this.tbContraseña.SelectionLength = 0;
            this.tbContraseña.SelectionStart = 0;
            this.tbContraseña.ShortcutsEnabled = true;
            this.tbContraseña.Size = new System.Drawing.Size(205, 23);
            this.tbContraseña.TabIndex = 6;
            this.tbContraseña.UseSelectable = true;
            this.tbContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContraseña_KeyPress);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(325, 195);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(75, 19);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            // 
            // 
            // 
            this.tbUsuario.CustomButton.Image = null;
            this.tbUsuario.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.tbUsuario.CustomButton.Name = "";
            this.tbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsuario.CustomButton.TabIndex = 1;
            this.tbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsuario.CustomButton.UseSelectable = true;
            this.tbUsuario.CustomButton.Visible = false;
            this.tbUsuario.Lines = new string[0];
            this.tbUsuario.Location = new System.Drawing.Point(260, 147);
            this.tbUsuario.MaxLength = 32767;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.SelectionLength = 0;
            this.tbUsuario.SelectionStart = 0;
            this.tbUsuario.ShortcutsEnabled = true;
            this.tbUsuario.Size = new System.Drawing.Size(205, 23);
            this.tbUsuario.TabIndex = 4;
            this.tbUsuario.UseSelectable = true;
            this.tbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(335, 125);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDescripcion.Location = new System.Drawing.Point(196, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(335, 25);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Aplicación para gestión de cita para clínica";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBienvenida.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBienvenida.Location = new System.Drawing.Point(260, 35);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(205, 25);
            this.lblBienvenida.Style = MetroFramework.MetroColorStyle.Black;
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido a MedTech";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MedTech.Properties.Resources.Logotipo_medtech;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // InicioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InicioFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InSesForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroLabel lblBienvenida;
        private MetroFramework.Controls.MetroTextBox tbContraseña;
        private MetroFramework.Controls.MetroLabel lblContraseña;
        private MetroFramework.Controls.MetroTextBox tbUsuario;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroButton btnSiguiente;
        private System.Windows.Forms.PictureBox pbContraseña;
    }
}