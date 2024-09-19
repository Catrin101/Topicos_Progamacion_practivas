using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
        }

        private void CB_Bold_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily,
            this.L_texto.Font.Size, this.L_texto.Font.Style ^ FontStyle.Bold);
        }

        private void CB_Italic_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily,
            this.L_texto.Font.Size, this.L_texto.Font.Style ^ FontStyle.Italic);
        }

        private void CB_Strickout_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily,
            this.L_texto.Font.Size, this.L_texto.Font.Style ^ FontStyle.Strikeout);
        }

        private void CB_Underline_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily,
            this.L_texto.Font.Size, this.L_texto.Font.Style ^ FontStyle.Underline);
        }

        private void CB_Consolas_CheckedChanged(object sender, EventArgs e){
            FontFamily csl = new FontFamily("Consolas");
            this.L_texto.Font = new Font(csl, this.L_texto.Font.Size,
            this.L_texto.Font.Style);
        }

        private void CB_ColonnaMT_CheckedChanged(object sender, EventArgs e){
            FontFamily csl = new FontFamily("Colonna MT");
            this.L_texto.Font = new Font(csl, this.L_texto.Font.Size,
            this.L_texto.Font.Style);
        }

        private void CB_Brcadway_CheckedChanged(object sender, EventArgs e){
            FontFamily csl = new FontFamily("Verdana");
            this.L_texto.Font = new Font(csl, this.L_texto.Font.Size,
            this.L_texto.Font.Style);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e){
            FontFamily csl = new FontFamily("Calibri");
            this.L_texto.Font = new Font(csl, this.L_texto.Font.Size,
            this.L_texto.Font.Style);
        }

        private void CB_8_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily, 8,
            this.L_texto.Font.Style);
        }

        private void CB_12_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily, 12,
            this.L_texto.Font.Style);
        }

        private void CB_16_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily, 16,
            this.L_texto.Font.Style);
        }

        private void CB_20_CheckedChanged(object sender, EventArgs e){
            this.L_texto.Font = new Font(this.L_texto.Font.FontFamily, 20,
            this.L_texto.Font.Style);
        }

        private void BT_Salir_Click(object sender, EventArgs e){
            Close();
        }

        private void BT_Limpiar_Click(object sender, EventArgs e){
            FontFamily mss = new FontFamily("Microsoft Sans Serif"); this.L_texto.Font = new
            Font(mss, 12, FontStyle.Regular);
        }

        private void L_texto_Click(object sender, EventArgs e)
        {

        }
    }
}