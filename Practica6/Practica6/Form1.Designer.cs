namespace Practica6
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
            this.L_texto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Bold = new System.Windows.Forms.CheckBox();
            this.CB_Italic = new System.Windows.Forms.CheckBox();
            this.CB_Strickout = new System.Windows.Forms.CheckBox();
            this.CB_Underline = new System.Windows.Forms.CheckBox();
            this.CB_Consolas = new System.Windows.Forms.CheckBox();
            this.CB_ColonnaMT = new System.Windows.Forms.CheckBox();
            this.CB_Brcadway = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.CB_8 = new System.Windows.Forms.CheckBox();
            this.CB_12 = new System.Windows.Forms.CheckBox();
            this.CB_16 = new System.Windows.Forms.CheckBox();
            this.CB_20 = new System.Windows.Forms.CheckBox();
            this.BT_Salir = new System.Windows.Forms.Button();
            this.BT_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_texto
            // 
            this.L_texto.AutoSize = true;
            this.L_texto.Location = new System.Drawing.Point(12, 45);
            this.L_texto.Name = "L_texto";
            this.L_texto.Size = new System.Drawing.Size(173, 16);
            this.L_texto.TabIndex = 0;
            this.L_texto.Text = "Esto es una prueba de texto";
            this.L_texto.Click += new System.EventHandler(this.L_texto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estilo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tamano";
            // 
            // CB_Bold
            // 
            this.CB_Bold.AutoSize = true;
            this.CB_Bold.Location = new System.Drawing.Point(15, 167);
            this.CB_Bold.Name = "CB_Bold";
            this.CB_Bold.Size = new System.Drawing.Size(57, 20);
            this.CB_Bold.TabIndex = 4;
            this.CB_Bold.Text = "Bold";
            this.CB_Bold.UseVisualStyleBackColor = true;
            this.CB_Bold.CheckedChanged += new System.EventHandler(this.CB_Bold_CheckedChanged);
            // 
            // CB_Italic
            // 
            this.CB_Italic.AutoSize = true;
            this.CB_Italic.Location = new System.Drawing.Point(15, 194);
            this.CB_Italic.Name = "CB_Italic";
            this.CB_Italic.Size = new System.Drawing.Size(56, 20);
            this.CB_Italic.TabIndex = 5;
            this.CB_Italic.Text = "Italic";
            this.CB_Italic.UseVisualStyleBackColor = true;
            this.CB_Italic.CheckedChanged += new System.EventHandler(this.CB_Italic_CheckedChanged);
            // 
            // CB_Strickout
            // 
            this.CB_Strickout.AutoSize = true;
            this.CB_Strickout.Location = new System.Drawing.Point(15, 221);
            this.CB_Strickout.Name = "CB_Strickout";
            this.CB_Strickout.Size = new System.Drawing.Size(80, 20);
            this.CB_Strickout.TabIndex = 6;
            this.CB_Strickout.Text = "Strickout";
            this.CB_Strickout.UseVisualStyleBackColor = true;
            this.CB_Strickout.CheckedChanged += new System.EventHandler(this.CB_Strickout_CheckedChanged);
            // 
            // CB_Underline
            // 
            this.CB_Underline.AutoSize = true;
            this.CB_Underline.Location = new System.Drawing.Point(15, 248);
            this.CB_Underline.Name = "CB_Underline";
            this.CB_Underline.Size = new System.Drawing.Size(87, 20);
            this.CB_Underline.TabIndex = 7;
            this.CB_Underline.Text = "Underline";
            this.CB_Underline.UseVisualStyleBackColor = true;
            this.CB_Underline.CheckedChanged += new System.EventHandler(this.CB_Underline_CheckedChanged);
            // 
            // CB_Consolas
            // 
            this.CB_Consolas.AutoSize = true;
            this.CB_Consolas.Location = new System.Drawing.Point(172, 167);
            this.CB_Consolas.Name = "CB_Consolas";
            this.CB_Consolas.Size = new System.Drawing.Size(86, 20);
            this.CB_Consolas.TabIndex = 8;
            this.CB_Consolas.Text = "Consolas";
            this.CB_Consolas.UseVisualStyleBackColor = true;
            this.CB_Consolas.CheckedChanged += new System.EventHandler(this.CB_Consolas_CheckedChanged);
            // 
            // CB_ColonnaMT
            // 
            this.CB_ColonnaMT.AutoSize = true;
            this.CB_ColonnaMT.Location = new System.Drawing.Point(172, 194);
            this.CB_ColonnaMT.Name = "CB_ColonnaMT";
            this.CB_ColonnaMT.Size = new System.Drawing.Size(102, 20);
            this.CB_ColonnaMT.TabIndex = 9;
            this.CB_ColonnaMT.Text = "Colonna MT";
            this.CB_ColonnaMT.UseVisualStyleBackColor = true;
            this.CB_ColonnaMT.CheckedChanged += new System.EventHandler(this.CB_ColonnaMT_CheckedChanged);
            // 
            // CB_Brcadway
            // 
            this.CB_Brcadway.AutoSize = true;
            this.CB_Brcadway.Location = new System.Drawing.Point(172, 220);
            this.CB_Brcadway.Name = "CB_Brcadway";
            this.CB_Brcadway.Size = new System.Drawing.Size(81, 20);
            this.CB_Brcadway.TabIndex = 10;
            this.CB_Brcadway.Text = "Verdana";
            this.CB_Brcadway.UseVisualStyleBackColor = true;
            this.CB_Brcadway.CheckedChanged += new System.EventHandler(this.CB_Brcadway_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(172, 248);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(67, 20);
            this.checkBox8.TabIndex = 11;
            this.checkBox8.Text = "Calibri";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // CB_8
            // 
            this.CB_8.AutoSize = true;
            this.CB_8.Location = new System.Drawing.Point(346, 166);
            this.CB_8.Name = "CB_8";
            this.CB_8.Size = new System.Drawing.Size(36, 20);
            this.CB_8.TabIndex = 12;
            this.CB_8.Text = "8";
            this.CB_8.UseVisualStyleBackColor = true;
            this.CB_8.CheckedChanged += new System.EventHandler(this.CB_8_CheckedChanged);
            // 
            // CB_12
            // 
            this.CB_12.AutoSize = true;
            this.CB_12.Location = new System.Drawing.Point(346, 194);
            this.CB_12.Name = "CB_12";
            this.CB_12.Size = new System.Drawing.Size(43, 20);
            this.CB_12.TabIndex = 13;
            this.CB_12.Text = "12";
            this.CB_12.UseVisualStyleBackColor = true;
            this.CB_12.CheckedChanged += new System.EventHandler(this.CB_12_CheckedChanged);
            // 
            // CB_16
            // 
            this.CB_16.AutoSize = true;
            this.CB_16.Location = new System.Drawing.Point(346, 221);
            this.CB_16.Name = "CB_16";
            this.CB_16.Size = new System.Drawing.Size(43, 20);
            this.CB_16.TabIndex = 14;
            this.CB_16.Text = "16";
            this.CB_16.UseVisualStyleBackColor = true;
            this.CB_16.CheckedChanged += new System.EventHandler(this.CB_16_CheckedChanged);
            // 
            // CB_20
            // 
            this.CB_20.AutoSize = true;
            this.CB_20.Location = new System.Drawing.Point(346, 248);
            this.CB_20.Name = "CB_20";
            this.CB_20.Size = new System.Drawing.Size(43, 20);
            this.CB_20.TabIndex = 15;
            this.CB_20.Text = "20";
            this.CB_20.UseVisualStyleBackColor = true;
            this.CB_20.CheckedChanged += new System.EventHandler(this.CB_20_CheckedChanged);
            // 
            // BT_Salir
            // 
            this.BT_Salir.Location = new System.Drawing.Point(15, 302);
            this.BT_Salir.Name = "BT_Salir";
            this.BT_Salir.Size = new System.Drawing.Size(75, 23);
            this.BT_Salir.TabIndex = 16;
            this.BT_Salir.Text = "Salir";
            this.BT_Salir.UseVisualStyleBackColor = true;
            this.BT_Salir.Click += new System.EventHandler(this.BT_Salir_Click);
            // 
            // BT_Limpiar
            // 
            this.BT_Limpiar.Location = new System.Drawing.Point(125, 302);
            this.BT_Limpiar.Name = "BT_Limpiar";
            this.BT_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.BT_Limpiar.TabIndex = 17;
            this.BT_Limpiar.Text = "Limpiar";
            this.BT_Limpiar.UseVisualStyleBackColor = true;
            this.BT_Limpiar.Click += new System.EventHandler(this.BT_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 345);
            this.Controls.Add(this.BT_Limpiar);
            this.Controls.Add(this.BT_Salir);
            this.Controls.Add(this.CB_20);
            this.Controls.Add(this.CB_16);
            this.Controls.Add(this.CB_12);
            this.Controls.Add(this.CB_8);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.CB_Brcadway);
            this.Controls.Add(this.CB_ColonnaMT);
            this.Controls.Add(this.CB_Consolas);
            this.Controls.Add(this.CB_Underline);
            this.Controls.Add(this.CB_Strickout);
            this.Controls.Add(this.CB_Italic);
            this.Controls.Add(this.CB_Bold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_texto);
            this.Name = "Form1";
            this.Text = "Caja de Seleccion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_texto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CB_Italic;
        private System.Windows.Forms.CheckBox CB_Strickout;
        private System.Windows.Forms.CheckBox CB_Underline;
        private System.Windows.Forms.CheckBox CB_Consolas;
        private System.Windows.Forms.CheckBox CB_ColonnaMT;
        private System.Windows.Forms.CheckBox CB_Brcadway;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox CB_8;
        private System.Windows.Forms.CheckBox CB_12;
        private System.Windows.Forms.CheckBox CB_16;
        private System.Windows.Forms.CheckBox CB_20;
        private System.Windows.Forms.Button BT_Salir;
        private System.Windows.Forms.Button BT_Limpiar;
        private System.Windows.Forms.CheckBox CB_Bold;
    }
}

