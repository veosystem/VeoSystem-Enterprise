namespace VeoSystem.Vista.Inicio
{
    partial class frmCambiaPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiaPass));
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.Location = new System.Drawing.Point(97, 19);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(85, 18);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold);
            this.lblRepetir.Location = new System.Drawing.Point(97, 46);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(62, 18);
            this.lblRepetir.TabIndex = 1;
            this.lblRepetir.Text = "Repetir:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(185, 17);
            this.txtContraseña.MaxLength = 16;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(185, 44);
            this.txtRepetir.MaxLength = 16;
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(100, 20);
            this.txtRepetir.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(225, 70);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmCambiaPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 99);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.lblContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCambiaPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRepetir;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}