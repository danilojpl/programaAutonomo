using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", " ");
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                cmbPartidas.Items.Add(partidas[i]);
            }

            
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Partida partida;
            partida = new Partida();
            partida.id =Convert.ToInt32(partida.getAtributo(cmbPartidas.SelectedItem.ToString(), 0));
            string login = txtNomeJ.Text;
            string senha = txtSenhaJ.Text;
            Jogo.EntrarPartida(partida.id, login, senha);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nome = txtNomeP.Text;
            string senha = txtSenhaP.Text;
            Jogo.CriarPartida(nome, senha);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            Partida partida;
            partida = new Partida();
            partida.id =Convert.ToInt32 (partida.getAtributo(cmbPartidas.SelectedItem.ToString(), 0));
            txtListarJ.Text = Jogo.ListarJogadores(partida.id);
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
