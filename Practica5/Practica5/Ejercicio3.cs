using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5{
    public partial class Ejercicio3 : Form{
        public Ejercicio3(){
            InitializeComponent();
        }

        private void ButtonProsesar_Click(object sender, EventArgs e){
            string inputString = BoxCadena.Text;
            BoxLongitud.Text = $"{inputString.Length}";
            BoxUltimoCaracter.Text = $"{inputString}";
            BoxPrimerCaracter.Text = $"{inputString[0]}";
            if (inputString.Length >= 6){
               Box2al6.Text = $"{inputString.Substring(1, 5)}";
            }else{
                Box2al6.Text = "demasiado corto";
            }
            int posicionA = inputString.IndexOf('A');
            BoxPrimeraA.Text = posicionA >= 0 ? $"{posicionA}" : "No se encontró la A";
            BoxMayusculas.Text = inputString.ToUpper();
            BoxMinusculas.Text = inputString.ToLower();
            BoxBorrarEspacios.Text = inputString.Replace(" ", "");
        }
    }
}