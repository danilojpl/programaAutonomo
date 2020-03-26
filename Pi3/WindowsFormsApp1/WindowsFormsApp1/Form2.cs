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
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Thread form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void txtNomeP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarP_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", " ");
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                cmbPartidas.Items.Add(partidas[i]);
            }
        }

        private void cmbPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarP_Click(object sender, EventArgs e)
        {
            string nome = txtNomeP.Text;
            string senha = txtSenhaP.Text;
            Jogo.CriarPartida(nome, senha);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Partida partida;
            partida = new Partida();
            partida.id = Convert.ToInt32(partida.getAtributo(cmbPartidas.SelectedItem.ToString(), 0));
            string login = txtNomeJ.Text;
            string senha = txtSenhaJ.Text;
            Jogo.EntrarPartida(partida.id, login, senha);
        }

        private void btnListarJ_Click(object sender, EventArgs e)
        {
            Partida partida;
            partida = new Partida();
            partida.id = Convert.ToInt32(partida.getAtributo(cmbPartidas.SelectedItem.ToString(), 0));
            txtListarJ.Text = Jogo.ListarJogadores(partida.id);
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            this.Close();
            form1 = new Thread(novoForm);
            form1.SetApartmentState(ApartmentState.STA);
            form1.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form1());
        }
    }
}
