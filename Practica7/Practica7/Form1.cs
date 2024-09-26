using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7{
    public partial class Form1 : Form{
        private Dictionary<string, string> Sonidos;
        private Dictionary<Keys, string> MapeoTeclas;
        public Form1(){
            InitializeComponent();
            Sonidos = new Dictionary<string, string>{
                {"Do#",@"Sonidos\DO#.wav"},
                {"Do",@"Sonidos\DO.wav"},
                {"DoUltimo",@"Sonidos\DoUltimo.wav"},
                {"Fa#",@"Sonidos\FA#.wav"},
                {"Fa",@"Sonidos\FA.wav"},
                {"La#",@"Sonidos\LA#.wav"},
                {"La",@"Sonidos\LA.wav"},
                {"Mi",@"Sonidos\MI.wav"},
                {"Re#",@"Sonidos\RE#.wav"},
                {"Re",@"Sonidos\RE.wav"},
                {"Si",@"Sonidos\SI.wav"},
                {"Sol#",@"Sonidos\SOL#.wav"},
                {"Sol",@"Sonidos\SOL.wav"}
            };
            MapeoTeclas = new Dictionary<Keys, string> {
                { Keys.A, "Do" },
                { Keys.W, "Do#" },
                { Keys.S, "Re" },
                { Keys.E, "Re#" },
                { Keys.D, "Mi" },
                { Keys.F, "Fa" },
                { Keys.T, "Fa#" },
                { Keys.G, "Sol" },
                { Keys.Y, "Sol#" },
                { Keys.H, "La" },
                { Keys.U, "La#" },
                { Keys.J, "Si" },
                { Keys.K, "DoUltimo"}
            };
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (MapeoTeclas.ContainsKey(e.KeyCode)) {
                string nota = MapeoTeclas[e.KeyCode];
                label1.Text = nota;
                ReproducirSonidos (nota);
            }
        }

        public void ReproducirSonidos(string sonido) {
            if (Sonidos.ContainsKey(sonido)) { 
                SoundPlayer player = new SoundPlayer(Sonidos[sonido]);
                label1.Text = sonido;
                player.Play();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Sol");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Si");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("La");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Fa");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("DoUltimo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Mi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Re");
        }

        private void button1_Click(object sender, EventArgs e){
            ReproducirSonidos("Do");
        }

        private void doo_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Do#");
        }

        private void ree_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Re#");
        }

        private void faa_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Fa#");
        }

        private void soll_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("Sol#");
        }

        private void LAA_Click(object sender, EventArgs e)
        {
            ReproducirSonidos("La#");
        }
    }
}
