using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica12{
    public partial class Form1 : Form{
        string archivo="archovo.txt";
        FontStyle negritas = new FontStyle();
        FontStyle italica = new FontStyle();
        FontStyle subrayado = new FontStyle();
        FontStyle tachada = new FontStyle();

        public Form1(){
            InitializeComponent();
            richTextBox1.EnableAutoDragDrop = true;
        }
        private void Aabrir_Click(object sender, EventArgs e){
            OpenFileDialog openFiel = new OpenFileDialog();
            if (openFiel.ShowDialog() == DialogResult.OK) { 
                archivo = openFiel.FileName;
                using (StreamReader sr = new StreamReader(archivo)) {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }
        private void Aguardar_Click(object sender, EventArgs e){
            SaveFileDialog saveFiel = new SaveFileDialog();
            saveFiel.Filter = "Texto|*.txt";
            if (archivo != null){
                using (StreamWriter sw = new StreamWriter(archivo)){
                    sw.WriteLine(richTextBox1.Text);
                }
            }
            else {
                if (saveFiel.ShowDialog() == DialogResult.OK) { 
                    archivo=saveFiel.FileName;
                    using (StreamWriter sw = new StreamWriter(saveFiel.FileName)) { 
                        sw.Write(richTextBox1.Text);
                        MessageBox.Show("Archivo guardada");
                    }
                }
            }
        }
        private void Anuevo_Click(object sender, EventArgs e){
            richTextBox1.Clear();
        }
        private void Asalir_Click(object sender, EventArgs e){
            Environment.Exit(0);
        }
        private void EseleccionarTodo_Click(object sender, EventArgs e){
            richTextBox1.SelectAll();
        }
        private void Ecopiar_Click(object sender, EventArgs e){
            if (richTextBox1.SelectedText != "")
                Clipboard.SetDataObject(richTextBox1.SelectedText);
        }
        private void Epegar_Click(object sender, EventArgs e){
            IDataObject iData = Clipboard.GetDataObject();
            richTextBox1.Text = (string)iData.GetData(DataFormats.Text);
        }
        private void Ecortar_Click(object sender, EventArgs e){
            if (richTextBox1.SelectedText != "") {
                richTextBox1.Cut();
            } 
        }
        private void Form1_Load(object sender, EventArgs e){

        }
        private void FFnegritas_Click(object sender, EventArgs e){
            if (negritas == FontStyle.Bold){
                negritas = FontStyle.Regular;
            }
            else {
                negritas = FontStyle.Bold;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, negritas | subrayado | italica | tachada);
        }
        private void FFitalica_Click(object sender, EventArgs e){
            if (italica == FontStyle.Italic){
                italica = FontStyle.Regular;
            }else{
                italica = FontStyle.Italic;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, negritas | subrayado | italica | tachada);
        }
        private void FFsubrayadas_Click(object sender, EventArgs e){
            if (subrayado == FontStyle.Underline){
                subrayado = FontStyle.Regular;
            }else{
                subrayado = FontStyle.Underline;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, negritas | subrayado | italica | tachada);
        }
        private void FFtachado_Click(object sender, EventArgs e){
            if (tachada == FontStyle.Strikeout){
                tachada = FontStyle.Regular;
            }else{
                tachada = FontStyle.Strikeout;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, negritas | subrayado | italica | tachada);
        }
        private void Fcolor_Click(object sender, EventArgs e){
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
        private void Edeshacer_Click(object sender, EventArgs e){
            if (richTextBox1.CanUndo){
                richTextBox1.Undo();
            }
        }
        private void Erehacer_Click(object sender, EventArgs e){
            if (richTextBox1.CanRedo){
                richTextBox1.Redo();
            }
        }
        private void Ffuente_Click(object sender, EventArgs e){
            if (fontDialog1.ShowDialog() == DialogResult.OK){
                if (richTextBox1.SelectedText.Length > 0){
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }else{
                    richTextBox1.Font = fontDialog1.Font;
                }
            }
        }
        private void FAderecha_Click(object sender, EventArgs e){
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void FAcentrado_Click(object sender, EventArgs e){
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void FAizquierda_Click(object sender, EventArgs e){
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void Limpiar_Click(object sender, EventArgs e){
            richTextBox1.Clear();
        }
        private void Fmayusculas_Click(object sender, EventArgs e){
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            if (richTextBox1.SelectedText.Length > 0){
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
            }else{
                richTextBox1.Text = richTextBox1.Text.ToUpper();
            }

            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = selectionLength;
        }
        private void Fminusculas_Click(object sender, EventArgs e){
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            if (richTextBox1.SelectedText.Length > 0){
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
            }else{
                richTextBox1.Text = richTextBox1.Text.ToLower();
            }

            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = selectionLength;
        }
        private void Aimprimir_Click(object sender, EventArgs e){
            PrintDialog PrintDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            PrintDialog.Document = printDocument;

            if (PrintDialog.ShowDialog() == DialogResult.OK) {
                printDocument.PrintPage += imprimir;
                printDocument.Print();
            }
        }
        private void imprimir(object sender, PrintPageEventArgs e) {
            Font font = new Font(richTextBox1.Font, negritas | subrayado | italica | tachada);
            String texto = richTextBox1.Text;
            e.Graphics.DrawString(texto, font, Brushes.Black, new RectangleF(0, 10, 800, 400));
        }
    }
}