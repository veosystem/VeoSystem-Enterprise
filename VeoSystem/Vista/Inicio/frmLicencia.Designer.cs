namespace VeoSystem.Vista.Inicio
{
    partial class frmLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicencia));
            this.lblLicencia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLlave1 = new System.Windows.Forms.TextBox();
            this.txtLlave2 = new System.Windows.Forms.TextBox();
            this.txtLlave3 = new System.Windows.Forms.TextBox();
            this.txtLlave4 = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencia.Location = new System.Drawing.Point(70, 16);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(64, 18);
            this.lblLicencia.TabIndex = 0;
            this.lblLicencia.Text = "Licencia:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtLlave1
            // 
            this.txtLlave1.Location = new System.Drawing.Point(140, 16);
            this.txtLlave1.Name = "txtLlave1";
            this.txtLlave1.Size = new System.Drawing.Size(45, 20);
            this.txtLlave1.TabIndex = 2;
            this.txtLlave1.TextChanged += new System.EventHandler(this.txtLlave1_TextChanged);
            // 
            // txtLlave2
            // 
            this.txtLlave2.Location = new System.Drawing.Point(191, 16);
            this.txtLlave2.Name = "txtLlave2";
            this.txtLlave2.Size = new System.Drawing.Size(45, 20);
            this.txtLlave2.TabIndex = 3;
            this.txtLlave2.TextChanged += new System.EventHandler(this.txtLlave2_TextChanged);
            this.txtLlave2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLlave2_KeyDown);
            // 
            // txtLlave3
            // 
            this.txtLlave3.Location = new System.Drawing.Point(242, 16);
            this.txtLlave3.Name = "txtLlave3";
            this.txtLlave3.Size = new System.Drawing.Size(45, 20);
            this.txtLlave3.TabIndex = 4;
            this.txtLlave3.TextChanged += new System.EventHandler(this.txtLlave3_TextChanged);
            this.txtLlave3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLlave3_KeyDown);
            // 
            // txtLlave4
            // 
            this.txtLlave4.Location = new System.Drawing.Point(293, 16);
            this.txtLlave4.Name = "txtLlave4";
            this.txtLlave4.Size = new System.Drawing.Size(45, 20);
            this.txtLlave4.TabIndex = 5;
            this.txtLlave4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLlave4_KeyDown);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(283, 42);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(55, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 70);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtLlave4);
            this.Controls.Add(this.txtLlave3);
            this.Controls.Add(this.txtLlave2);
            this.Controls.Add(this.txtLlave1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLicencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencia del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLlave1;
        private System.Windows.Forms.TextBox txtLlave2;
        private System.Windows.Forms.TextBox txtLlave3;
        private System.Windows.Forms.TextBox txtLlave4;
        private System.Windows.Forms.Button btnIngresar;
    }
}