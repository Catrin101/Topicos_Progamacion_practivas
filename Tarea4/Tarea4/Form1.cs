using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4{
    public partial class Form1 : Form{
        private Dictionary<string, string> sonidos;
        public Form1(){
            InitializeComponent();
            sonidos = new Dictionary<string, string> {
                {"Boo", @"Sonidos\boo.wav"},
                {"Cat", @"Sonidos\cat.wav"},
                {"Drums", @"Sonidos\drums.wav"},
                {"Laugh", @"Sonidos\laugh.wav"}
            };
        }

        public void ReproducirSonido(string sonido) {
            if (sonidos.ContainsKey(sonido)) { 
                SoundPlayer player = new SoundPlayer(sonidos[sonido]);
                player.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e){
            ReproducirSonido("Boo");
        }

        private void button3_Click(object sender, EventArgs e){
            ReproducirSonido("Cat");
        }

        private void button4_Click(object sender, EventArgs e){
            ReproducirSonido("Drums");
        }

        private void button2_Click(object sender, EventArgs e){
            ReproducirSonido("Laugh");
        }
    }
}