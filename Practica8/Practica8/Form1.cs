using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8{
    public partial class Form1 : Form
    {
        float num1, num2, res;
        string signo;
        public Form1(){
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e){

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text + "9";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            Text.Text = "";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Text.Text);
            signo = "suma";
            Text.Text = "";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Text.Text);
            signo = "resta";
            Text.Text = "";
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Text.Text);
            signo = "multi";
            Text.Text = "";
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Text.Text);
            signo = "divi";
            Text.Text = "";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Text.Text);
            res = (float)Math.Sin(num1);
            Text.Text = res.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Text.Text);
            res = (float)Math.Cos(num1);
            Text.Text = res.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Text.Text);
            res = (float)Math.Tan(num1);
            Text.Text = res.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Text.Text = Text.Text.Substring(0, Text.TextLength - 1);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(Text.Text);
            Text.Text = "";
            switch (signo) {
                case "suma":
                    res = num1 + num2;
                    break;
                case "resta":
                    res = num1 - num2;
                    break;
                case "multi":
                    res = num1 * num2;
                    break;
                case "divi":
                    res = num1 / num2;
                    break;
                default:
                    Text.Text = "Error";
                    break;
            }
            Text.Text = res.ToString();
        }

        private void btnpunto_Click(object sender, EventArgs e){
            Text.Text = Text.Text + ".";
        }

        private void button9_Click(object sender, EventArgs e){
            Text.Text = Text.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e){
            Text.Text = Text.Text + "0";
        }
    }
}