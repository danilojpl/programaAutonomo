using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace WindowsFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
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

        private void btnListarJ_Click(object sender, EventArgs e)
        {
            Partida partida;
            partida = new Partida();
            partida.id = Convert.ToInt32(partida.getAtributo(cmbPartidas.SelectedItem.ToString(), 0));
            txtListarJ.Text = Jogo.ListarJogadores(partida.id);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string atJog;
            Partida partida;
            partida = new Partida();
            partida.id = Convert.ToInt32(partida.getAtributo(cmbPartidas.SelectedItem.ToString(), 0));
            string login = txtNomeJ.Text;
            string senha = txtSenhaJ.Text;
            atJog = Jogo.EntrarPartida(partida.id, login, senha);
            string[] atributos = atJog.Split(',');
            txtIdJogador.Text = atributos[0];
            txtSenhaJogador.Text = atributos[1];
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Form1 form11;
            form11 = new Form1();
            Partida partida;
            partida = new Partida();
            int idJog = Convert.ToInt32(txtIdJogador.Text);
            string senJ = txtSenhaJogador.Text;
            form11.senha = txtSenhaJogador.Text;
            form11.id = idJog;
            form11.idPart = Convert.ToInt32(partida.getAtributo(cmbPartidas.SelectedItem.ToString(), 0));
            txtListarJ.Text = Jogo.IniciarPartida(idJog, senJ);
            form11.Show();
        }
    }
}
