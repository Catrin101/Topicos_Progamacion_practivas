using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pactica10{
    public partial class Login : Form{
        public Login(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            string usuarioCorrecto = "enrique";
            string passwordCorrecta = "0531";

            string usuarioIngresado = txt_Usuario.Text;
            string passwordIngresada = txt_Contraseña.Text;

            if (usuarioIngresado == usuarioCorrecto && passwordIngresada == passwordCorrecta){
                Form2 Contenido = new Form2();
                Contenido.Show();
                this.Hide();
            }else{
                if (usuarioIngresado != usuarioCorrecto && passwordIngresada != passwordCorrecta){
                    menError.Text = "Usuario y contraseña incorrectos";
                }else if (usuarioIngresado != usuarioCorrecto){
                    menError.Text = "Usuario incorrecto";
                }else{
                    menError.Text = "Contraseña incorrecta";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true){
                txt_Contraseña.UseSystemPasswordChar = false;
            }if (checkBox1.Checked == false){
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }
    }
}