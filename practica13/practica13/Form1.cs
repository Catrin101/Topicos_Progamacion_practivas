using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace practica13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciarSecion_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "enrique";
            string passwordCorrecta = "0531";

            string usuarioIngresado = txtUsuario.Text;
            string passwordIngresada = txtContrasena.Text;

            if (usuarioIngresado == usuarioCorrecto && passwordIngresada == passwordCorrecta)
            {
                Tabla Contenido = new Tabla();
                Contenido.Show();
                this.Hide();
            }
            else
            {
                if (usuarioIngresado != usuarioCorrecto && passwordIngresada != passwordCorrecta)
                {
                    menError.Text = "Usuario y contraseña incorrectos";
                }
                else if (usuarioIngresado != usuarioCorrecto)
                {
                    menError.Text = "Usuario incorrecto";
                }
                else
                {
                    menError.Text = "Contraseña incorrecta";
                }
            }
        }

        private void mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar.Checked == true)
            {
                txtContrasena.UseSystemPasswordChar = false;
            }
            if (mostrar.Checked == false)
            {
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
    }
}
