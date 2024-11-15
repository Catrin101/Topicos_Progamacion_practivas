namespace practica13
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mostrar = new System.Windows.Forms.CheckBox();
            this.iniciarSecion = new System.Windows.Forms.Button();
            this.menError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Secion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(90, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 22);
            this.txtUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(90, 162);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(200, 22);
            this.txtContrasena.TabIndex = 7;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Location = new System.Drawing.Point(138, 190);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(74, 20);
            this.mostrar.TabIndex = 9;
            this.mostrar.Text = "Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.CheckedChanged += new System.EventHandler(this.mostrar_CheckedChanged);
            // 
            // iniciarSecion
            // 
            this.iniciarSecion.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarSecion.Location = new System.Drawing.Point(70, 281);
            this.iniciarSecion.Name = "iniciarSecion";
            this.iniciarSecion.Size = new System.Drawing.Size(183, 41);
            this.iniciarSecion.TabIndex = 10;
            this.iniciarSecion.Text = "Iniciar Secion";
            this.iniciarSecion.UseVisualStyleBackColor = true;
            this.iniciarSecion.Click += new System.EventHandler(this.iniciarSecion_Click);
            // 
            // menError
            // 
            this.menError.AutoSize = true;
            this.menError.Location = new System.Drawing.Point(135, 234);
            this.menError.Name = "menError";
            this.menError.Size = new System.Drawing.Size(0, 16);
            this.menError.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 334);
            this.Controls.Add(this.menError);
            this.Controls.Add(this.iniciarSecion);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inicio de Secion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox mostrar;
        private System.Windows.Forms.Button iniciarSecion;
        private System.Windows.Forms.Label menError;
    }
}

