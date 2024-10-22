using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9{
    public partial class Form1 : Form{
        List<consola> list = new List<consola>();
        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            Main();
        }

        public async Task Main() {
            string apiUrl = "https://jsonplaceholder.typicode.com/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage respone = await client.GetAsync(apiUrl);
                    if (respone.IsSuccessStatusCode)
                    {
                        string jsonContent = await respone.Content.ReadAsStringAsync();
                        list = JsonConvert.DeserializeObject<List<consola>>(jsonContent);
                        dataGridView1.DataSource = list;
                    }
                    else
                    {
                        Console.WriteLine("error al realizar la solicitud. codigo de stado:" + respone.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("erro:" + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
