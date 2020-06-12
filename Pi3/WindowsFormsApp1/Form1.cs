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
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblVer.Text = "Versão: " + Jogo.Versao;
            popPicture();

        }
        //propriedade publica 
        public string senha { get; set; }
        public int id { get; set; }
        public int idPart { get; set; }
        public int numF { get; set; }
        public int modelo { get; set; }
        public PictureBox[] fabrica1 { get; set; }
        public PictureBox[] fabrica2 { get; set; }
        public PictureBox[] fabrica3 { get; set; }
        public PictureBox[] fabrica4 { get; set; }
        public PictureBox[] fabrica5 { get; set; }
        public PictureBox[] fabrica6 { get; set; }
        public PictureBox[] fabrica7 { get; set; }
        public PictureBox[] fabrica8 { get; set; }
        public PictureBox[] fabrica9 { get; set; }



        string[] paredeS;
        string[] fabricaS = new string[12];
        string[] modeloS = new string[5];
        PictureBox[,] Tabuleiro = new PictureBox[5, 5];
        PictureBox[,] parede = new PictureBox[5, 5];
        delegate void ProcessadorCores();

        public void atualizarCentro()
        {
            int qnt = 0, j = 0, i;
            string[] aux2 = new string[5];
            PictureBox[] centro = new PictureBox[27];
            centro[0] = ptbCen1;
            centro[1] = ptbCen2;
            centro[2] = ptbCen3;
            centro[3] = ptbCen4;
            centro[4] = ptbCen5;
            centro[5] = ptbCen6;
            centro[6] = ptbCen7;
            centro[7] = ptbCen8;
            centro[8] = ptbCen9;
            centro[9] = ptbCen10;
            centro[10] = ptbCen11;
            centro[11] = ptbCen12;
            centro[12] = ptbCen13;
            centro[13] = ptbCen14;
            centro[14] = ptbCen15;
            centro[15] = ptbCen16;
            centro[16] = ptbCen17;
            centro[17] = ptbCen18;
            centro[18] = ptbCen19;
            centro[19] = ptbCen20;
            centro[20] = ptbCen21;
            centro[21] = ptbCen22;
            centro[22] = ptbCen23;
            centro[23] = ptbCen24;
            centro[24] = ptbCen25;
            centro[25] = ptbCen26;
            centro[26] = ptbCen27;

            string retorno = Jogo.LerCentro(id, senha);
            retorno = retorno.Replace("\r", "");
            string[] Centros = retorno.Split('\n');
            i = 0;
            foreach (string aux in Centros)
            {
                if (!aux.Equals(""))
                {
                    aux2 = aux.Split(',');
                    qnt = Convert.ToInt32(aux2[2]);

                    switch (aux2[1])
                    {
                        case "Azul":

                            for (i = i; i < centro.Length; i++)
                            {
                                if (qnt == 0 )
                                {
                                    for (int k = 0; k < centro.Length; k++)
                                    {
                                        centro[k].Image = null;
                                    }
                                    Update();
                                    break;
                                }

                                for (j = 0; j < qnt; j++)
                                {

                                    centro[i].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    i++;
                                }
                                Update();
                                break;

                            }


                            break;
                        case "Amarelo":



                            for (i = i; i < centro.Length; i++)
                            {
                                if (qnt == 0 )
                                {
                                    for (int k = 0; k < centro.Length; k++)
                                    {
                                        centro[k].Image = null;
                                        Update();
                                    }
                                    Update();
                                    break;
                                }

                                for (j = 0; j < qnt; j++)
                                {

                                    centro[i].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    i++;
                                }
                                Update();
                                break;

                            }
                            break;
                        case "Vermelho":
                            for (i = i; i < centro.Length; i++)
                            {
                                if (qnt == 0 )
                                {
                                    for (int k = 0; k < centro.Length; k++)
                                    {
                                        centro[k].Image = null;
                                    }
                                    Update();
                                    break;
                                }

                                for (j = 0; j < qnt; j++)
                                {

                                    centro[i].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    i++;
                                }
                                Update();
                                break;

                            }


                            break;
                        case "Preto":



                            for (i = i; i < centro.Length; i++)
                            {
                                if (qnt == 0 )
                                {
                                    for (int k = 0; k < centro.Length; k++)
                                    {
                                        centro[k].Image = null;
                                    }
                                    Update();
                                    break;
                                }

                                for (j = 0; j < qnt; j++)
                                {

                                    centro[i].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    i++;
                                }
                                Update();
                                break;

                            }


                            break;
                        case "Branco":

                            for (i = i; i < centro.Length; i++)
                            {
                                if (qnt == 0 )
                                {
                                    for (int k = 0; k < centro.Length; k++)
                                    {
                                        centro[k].Image = null;
                                    }
                                    Update();
                                    break;
                                }

                                for (j = 0; j < qnt; j++)
                                {

                                    centro[i].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    i++;
                                }
                                Update();
                                break;

                            }


                            break;

                    }
                }


            }



        }
        private void zerarFabricas()
        {
            string[] fabricasc = new string[9];
            string statusJog;
            statusJog = Jogo.LerFabricas(id, senha);
            statusJog = statusJog.Replace("\r", "");
            string[] tabuleiroS = statusJog.Split('\n');


            foreach (string aux in tabuleiroS)
            {
                if (aux != null && !aux.Equals(""))
                {
                    switch (aux[0])
                    {
                        case '1':
                            fabricasc[0] = aux;
                            break;
                        case '2':
                            fabricasc[1] = aux;
                            break;
                        case '3':
                            fabricasc[2] = aux;
                            break;
                        case '4':
                            fabricasc[3] = aux;
                            break;
                        case '5':
                            fabricasc[4] = aux;
                            break;
                        case '6':
                            fabricasc[5] = aux;
                            break;
                        case '7':
                            fabricasc[6] = aux;
                            break;
                        case '8':
                            fabricasc[7] = aux;
                            break;
                        case '9':
                            fabricasc[8] = aux;
                            break;

                    }
                }
            }

            if (fabricasc[0]==null)
            for (int i = 0; i < fabrica1.Length; i++)
            {
                fabrica1[i].Image = null;

            }
            if (fabricasc[1] == null)
                for (int i = 0; i < fabrica2.Length; i++)
            {
                fabrica2[i].Image = null;
            }
            if (fabricasc[2] == null)
                for (int i = 0; i < fabrica3.Length; i++)
                fabrica3[i].Image = null;
            if (fabricasc[3] == null)
                for (int i = 0; i < fabrica4.Length; i++)
                fabrica4[i].Image = null;
            if (fabricasc[4] == null)
                for (int i = 0; i < fabrica5.Length; i++)
                fabrica5[i].Image = null;
            if (fabricasc[5] == null)
                for (int i = 0; i < fabrica6.Length; i++)
                fabrica6[i].Image = null;
            if (fabricasc[6] == null)
                for (int i = 0; i < fabrica7.Length; i++)
                fabrica7[i].Image = null;
            if (fabricasc[7] == null)
                for (int i = 0; i < fabrica8.Length; i++)
                fabrica8[i].Image = null;
            if (fabricasc[8] == null)
                for (int i = 0; i < fabrica9.Length; i++)
                fabrica9[i].Image = null;
            Update();
        }
        private void atualizarFabricas()
        {
            int ii = 0, j = 0, k = 0, ll = 0, m = 0, n = 0, o = 0, p = 0, q = 0, qnt = 0;
            string[] aux2 = new string[5];
            string retorno = Jogo.LerFabricas(id, senha);
            retorno = retorno.Replace("\r", "");
            string[] fabricas = retorno.Split('\n');

            foreach (string aux in fabricas)
            {
                if (!aux.Equals(""))
                {
                    aux2 = aux.Split(',');
                    qnt = Convert.ToInt32(aux2[3]);


                    if (aux2[0].Equals("1"))
                    {
                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ii == 4)
                                        break;

                                    fabrica1[ii].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    ii++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ii == 4)
                                        break;
                                    fabrica1[ii].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    ii++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ii == 4)
                                        break;
                                    fabrica1[ii].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    ii++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ii == 4)
                                        break;
                                    fabrica1[ii].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    ii++;
                                }
                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ii == 4)
                                        break;
                                    fabrica1[ii].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    ii++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("2"))
                    {
                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (j == 4)
                                        break;
                                    fabrica2[j].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    j++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (j == 4)
                                        break;
                                    fabrica2[j].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    j++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (j == 4)
                                        break;
                                    fabrica2[j].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    j++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (j == 4)
                                        break;
                                    fabrica2[j].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    j++;
                                }
                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (j == 4)
                                        break;
                                    fabrica2[j].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    j++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("3"))
                    {

                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (k == 4)
                                        break;
                                    fabrica3[k].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    k++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (k == 4)
                                        break;
                                    fabrica3[k].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    k++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (k == 4)
                                        break;
                                    fabrica3[k].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    k++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (k == 4)
                                        break;
                                    fabrica3[k].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    k++;
                                }

                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (k == 4)
                                        break;
                                    fabrica3[k].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    k++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("4"))
                    {

                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ll == 4)
                                        break;
                                    fabrica4[ll].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    ll++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ll == 4)
                                        break;
                                    fabrica4[ll].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    ll++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ll == 4)
                                        break;
                                    fabrica4[ll].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    ll++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ll == 4)
                                        break;
                                    fabrica4[ll].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    ll++;
                                }

                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ll == 4)
                                        break;
                                    fabrica4[ll].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    ll++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("5"))
                    {

                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (m == 4)
                                        break;
                                    fabrica5[m].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    m++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (m == 4)
                                        break;
                                    fabrica5[m].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    m++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (m == 4)
                                        break;
                                    fabrica5[m].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    m++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (m == 4)
                                        break;
                                    fabrica5[m].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    m++;
                                }

                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (m == 4)
                                        break;
                                    fabrica5[m].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    m++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("6"))
                    {

                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (n == 4)
                                        break;
                                    fabrica6[n].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    n++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (n == 4)
                                        break;
                                    fabrica6[n].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    n++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (n == 4)
                                        break;
                                    fabrica6[n].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    n++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (n == 4)
                                        break;
                                    fabrica6[n].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    n++;
                                }

                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (n == 4)
                                        break;
                                    fabrica6[n].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    n++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("7"))
                    {

                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (o == 4)
                                        break;
                                    fabrica7[o].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    o++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (o == 4)
                                        break;
                                    fabrica7[o].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    o++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (o == 4)
                                        break;
                                    fabrica7[o].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    o++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (o == 4)
                                        break;
                                    fabrica7[o].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    o++;
                                }

                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (o == 4)
                                        break;
                                    fabrica7[o].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    o++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("8"))
                    {

                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (p == 4)
                                        break;
                                    fabrica8[p].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    p++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (p == 4)
                                        break;
                                    fabrica8[p].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    p++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (p == 4)
                                        break;
                                    fabrica8[p].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    p++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (p == 4)
                                        break;
                                    fabrica8[p].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    p++;
                                }

                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (p == 4)
                                        break;
                                    fabrica8[p].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    p++;
                                }
                                break;
                        }
                        Update();
                    }
                    else if (aux2[0].Equals("9"))
                    {

                        switch (aux2[2])
                        {
                            case "Azul":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (ii == 4)
                                        break;
                                    fabrica9[q].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    q++;
                                }
                                break;
                            case "Amarelo":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (q == 4)
                                        break;
                                    fabrica9[q].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    q++;
                                }
                                break;
                            case "Vermelho":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (q == 4)
                                        break;
                                    fabrica9[q].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    q++;
                                }
                                break;
                            case "Preto":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (q == 4)
                                        break;
                                    fabrica9[q].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    q++;
                                }

                                break;
                            case "Branco":
                                for (int l = 0; l < qnt; l++)
                                {
                                    if (q == 4)
                                        break;
                                    fabrica9[q].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    q++;
                                }
                                break;
                        }
                        Update();
                    }

                }
            }
        }


        private void getStringChao()
        {

            string statusJogador = Jogo.LerTabuleiro(id, senha, id);
            statusJogador = statusJogador.Replace("\r", "");
            string chao = statusJogador.Substring(statusJogador.IndexOf("c") + 4);

            string[] chaoS = chao.Split('\n');

            PictureBox[] chaos = new PictureBox[7];
            chaos[0] = ptbChao1;
            chaos[1] = ptbChao2;
            chaos[2] = ptbChao3;
            chaos[3] = ptbChao4;
            chaos[4] = ptbChao5;
            chaos[5] = ptbChao6;
            chaos[6] = ptbChao7;

            chaos[0].Image = null;
            chaos[1].Image = null;
            chaos[2].Image = null;
            chaos[3].Image = null;
            chaos[4].Image = null;
            chaos[5].Image = null;
            chaos[6].Image = null;


            foreach (string aux in chaoS)
            {
                if (!aux.Equals("") && !aux.Equals("hão") && !aux.Equals("chão"))
                {
                    string[] aux2 = aux.Split(',');
                        if (!aux2[0].Equals(""))
                        if (Convert.ToInt32(aux2[0])<= 6)
                        {
                            switch (aux2[1])
                            {
                                case "1":
                                    chaos[Convert.ToInt32(aux2[0])].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                    break;
                                case "2":
                                    chaos[Convert.ToInt32(aux2[0])].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                    break;
                                case "3":
                                    chaos[Convert.ToInt32(aux2[0])].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                    break;
                                case "4":
                                    chaos[Convert.ToInt32(aux2[0])].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                    break;
                                case "5":
                                    chaos[Convert.ToInt32(aux2[0])].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                    break;

                            }
                            Update();
                        }

                    

                }
            }



        }



        public void popPicture()
        {
            Tabuleiro[0, 0] = ptbModel1;
            Tabuleiro[1, 0] = ptbModel21;
            Tabuleiro[1, 1] = ptbModel22;
            Tabuleiro[2, 0] = ptbModel31;
            Tabuleiro[2, 1] = ptbModel32;
            Tabuleiro[2, 2] = ptbModel33;
            Tabuleiro[3, 0] = ptbModel41;
            Tabuleiro[3, 1] = ptbModel42;
            Tabuleiro[3, 2] = ptbModel43;
            Tabuleiro[3, 3] = ptbModel44;
            Tabuleiro[4, 0] = ptbModel51;
            Tabuleiro[4, 1] = ptbModel52;
            Tabuleiro[4, 2] = ptbModel53;
            Tabuleiro[4, 3] = ptbModel54;
            Tabuleiro[4, 4] = ptbModel55;

            fabrica1 = new PictureBox[4];
            fabrica1[0] = ptbFab11;
            fabrica1[1] = ptbFab12;
            fabrica1[2] = ptbFab13;
            fabrica1[3] = ptbFab14;

            fabrica2 = new PictureBox[4];
            fabrica2[0] = ptbFab21;
            fabrica2[1] = ptbFab22;
            fabrica2[2] = ptbFab23;
            fabrica2[3] = ptbFab24;

            fabrica3 = new PictureBox[4];
            fabrica3[0] = ptbFab31;
            fabrica3[1] = ptbFab32;
            fabrica3[2] = ptbFab33;
            fabrica3[3] = ptbFab34;

            fabrica4 = new PictureBox[4];
            fabrica4[0] = ptbFab41;
            fabrica4[1] = ptbFab42;
            fabrica4[2] = ptbFab43;
            fabrica4[3] = ptbFab44;

            fabrica5 = new PictureBox[4];
            fabrica5[0] = ptbFab51;
            fabrica5[1] = ptbFab52;
            fabrica5[2] = ptbFab53;
            fabrica5[3] = ptbFab54;

            fabrica6 = new PictureBox[4];
            fabrica6[0] = ptbFab61;
            fabrica6[1] = ptbFab62;
            fabrica6[2] = ptbFab63;
            fabrica6[3] = ptbFab64;

            fabrica7 = new PictureBox[4];
            fabrica7[0] = ptbFab71;
            fabrica7[1] = ptbFab72;
            fabrica7[2] = ptbFab73;
            fabrica7[3] = ptbFab74;

            fabrica8 = new PictureBox[4];
            fabrica8[0] = ptbFab81;
            fabrica8[1] = ptbFab82;
            fabrica8[2] = ptbFab83;
            fabrica8[3] = ptbFab84;

            fabrica9 = new PictureBox[4];
            fabrica9[0] = ptbFab91;
            fabrica9[1] = ptbFab92;
            fabrica9[2] = ptbFab93;
            fabrica9[3] = ptbFab94;


        }
        public void azul()
        {
            int qnt;

            foreach (string aux2 in modeloS)
            {
                if (aux2 != null)
                {
                    string[] aux3 = aux2.Split(',');
                    if (aux3[1] == "1")
                    {
                        qnt = Convert.ToInt32(aux3[2]);
                        switch (aux3[0])
                        {
                            case "1":
                                ptbModel1.Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                Update();
                                break;
                            case "2":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[1, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                }
                                Update();
                                break;
                            case "3":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[2, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                }
                                Update();
                                break;
                            case "4":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[3, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                }
                                Update();
                                break;
                            case "5":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[4, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                                }
                                Update();
                                break;
                        }
                    }
                }
            }
        }

        public void amarelo()
        {
            int qnt;

            foreach (string aux2 in modeloS)
            {
                if (aux2 != null)
                {
                    string[] aux3 = aux2.Split(',');
                    if (aux3[1] == "2")
                    {
                        qnt = Convert.ToInt32(aux3[2]);
                        switch (aux3[0])
                        {
                            case "1":
                                ptbModel1.Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                Update();
                                break;
                            case "2":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[1, i].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                }
                                Update();
                                break;
                            case "3":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[2, i].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                }
                                Update();
                                break;
                            case "4":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[3, i].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                }
                                Update();
                                break;
                            case "5":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[4, i].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                                }
                                Update();
                                break;
                        }
                    }
                }
            }
        }
        public void vermelho()
        {
            int qnt;

            foreach (string aux2 in modeloS)
            {
                if (aux2 != null)
                {
                    string[] aux3 = aux2.Split(',');
                    if (aux3[1] == "3")
                    {
                        qnt = Convert.ToInt32(aux3[2]);
                        switch (aux3[0])
                        {
                            case "1":
                                ptbModel1.Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                Update();
                                break;
                            case "2":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[1, i].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                }
                                Update();
                                break;
                            case "3":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[2, i].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                }
                                Update();
                                break;
                            case "4":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[3, i].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                }
                                Update();
                                break;
                            case "5":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[4, i].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                                }
                                Update();
                                break;
                        }
                    }
                }
            }
        }

        public void preto()
        {
            int qnt;
            foreach (string aux2 in modeloS)
            {
                if (aux2 != null)
                {
                    string[] aux3 = aux2.Split(',');
                    if (aux3[1] == "4")
                    {
                        qnt = Convert.ToInt32(aux3[2]);
                        switch (aux3[0])
                        {
                            case "1":
                                ptbModel1.Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                Update();
                                break;
                            case "2":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[1, i].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                }
                                Update();
                                break;
                            case "3":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[2, i].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                }
                                Update();
                                break;
                            case "4":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[3, i].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                }
                                Update();
                                break;
                            case "5":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[4, i].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                                }
                                Update();
                                break;
                        }
                    }
                }
            }
        }

        public void branco()
        {
            int qnt;
            foreach (string aux2 in modeloS)
            {
                if (aux2 != null)
                {
                    string[] aux3 = aux2.Split(',');
                    if (aux3[1] == "5")
                    {
                        qnt = Convert.ToInt32(aux3[2]);
                        switch (aux3[0])
                        {
                            case "1":

                                ptbModel1.Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                Update();
                                break;
                            case "2":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[1, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                }
                                Update();
                                break;
                            case "3":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[2, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                }
                                Update();
                                break;
                            case "4":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[3, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                }
                                Update();
                                break;
                            case "5":
                                for (int i = 0; i < qnt; i++)
                                {
                                    Tabuleiro[4, i].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                                }
                                Update();
                                break;
                        }
                    }
                }
            }
        }

        private void atualizarParede()
        {
            parede[0, 0] = ptbPared1;
            parede[0, 1] = ptbPared2;
            parede[0, 2] = ptbPared3;
            parede[0, 3] = ptbPared4;
            parede[0, 4] = ptbPared5;
            parede[1, 0] = ptbPared6;
            parede[1, 1] = ptbPared7;
            parede[1, 2] = ptbPared8;
            parede[1, 3] = ptbPared9;
            parede[1, 4] = ptbPared10;
            parede[2, 0] = ptbPared11;
            parede[2, 1] = ptbPared12;
            parede[2, 2] = ptbPared13;
            parede[2, 3] = ptbPared14;
            parede[2, 4] = ptbPared15;
            parede[3, 0] = ptbPared16;
            parede[3, 1] = ptbPared17;
            parede[3, 2] = ptbPared18;
            parede[3, 3] = ptbPared19;
            parede[3, 4] = ptbPared20;
            parede[4, 0] = ptbPared21;
            parede[4, 1] = ptbPared22;
            parede[4, 2] = ptbPared23;
            parede[4, 3] = ptbPared24;
            parede[4, 4] = ptbPared25;


            string statusParede = Jogo.LerTabuleiro(id, senha, id);
            statusParede = statusParede.Replace("\r", "");
            string strparede = statusParede.Substring(statusParede.IndexOf("p"), statusParede.IndexOf("c") - statusParede.IndexOf("p"));

            paredeS = strparede.Split('\n');

            foreach (string aux in paredeS)
            {
                if (!aux.Equals("parede") && !aux.Equals(""))
                {
                    string[] aux2 = aux.Split(',');
                    int x = Convert.ToInt32(aux2[0]);
                    int y = Convert.ToInt32(aux2[1]);
                    string aux3 = aux2[2];



                    switch (aux3[0])
                    {
                        case '1':
                            parede[x - 1, y - 1].Image = WindowsFormsApp1.Properties.Resources.botaoAzul;
                            break;
                        case '2':
                            parede[x - 1, y - 1].Image = WindowsFormsApp1.Properties.Resources.botaoAmarelo;
                            break;
                        case '3':
                            parede[x - 1, y - 1].Image = WindowsFormsApp1.Properties.Resources.botaoVermelho;
                            break;
                        case '4':
                            parede[x - 1, y - 1].Image = WindowsFormsApp1.Properties.Resources.botaoPreto;
                            break;
                        case '5':
                            parede[x - 1, y - 1].Image = WindowsFormsApp1.Properties.Resources.botaoAzuleBranco;
                            break;


                    }
                    Update();
                }


            }




        }


        private void atualizarModeloS()
        {
            var processadorModelo = new Dictionary<string, ProcessadorCores>();

            for (int i = 0; i < modeloS.Length; i++)
            {
                
                if (modeloS[i]!= null)
                  
                {
                    string[] aux = modeloS[i].Split(',');
                    processadorModelo["1"] = azul;
                    processadorModelo["2"] = amarelo;
                    processadorModelo["3"] = vermelho;
                    processadorModelo["4"] = preto;
                    processadorModelo["5"] = branco;
                    processadorModelo[aux[1]]();
                }else
                    for (int j = 0; j < 5; j++)
                    {
                        if (Tabuleiro[i,j] != null)
                        {
                            Tabuleiro[i, j].Image = null;
                        }
                    }
                Update();

            }

        }
        private void atualizarModeloC()
        {
            modeloS[0] = null;
            modeloS[1] = null;
            modeloS[2] = null;
            modeloS[3] = null;
            modeloS[4] = null;

            string statusJog;
            statusJog = Jogo.LerTabuleiro(id, senha, id);
            statusJog = statusJog.Replace("\r", "");
            string[] tabuleiroS = statusJog.Split('\n');


            foreach (string aux in tabuleiroS)
            {
                if (!aux.Equals("modelo") && !aux.Equals("parede") && !aux.Equals("chão"))
                    switch (aux[0])
                    {
                        case '1':
                            modeloS[0] = aux;
                            break;
                        case '2':
                            modeloS[1] = aux;
                            break;
                        case '3':
                            modeloS[2] = aux;
                            break;
                        case '4':
                            modeloS[3] = aux;
                            break;
                        case '5':
                            modeloS[4] = aux;
                            break;

                    }


                else if (aux.Equals("parede"))
                    break;
            }


        }
  
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerProcces();
        }


        private void Pontos()
        {
            string jogador = Jogo.ListarJogadores(idPart);
            jogador = jogador.Replace("\r","");
            string [] point = jogador.Split('\n');
            foreach(string aux in point)
            {
                if (!aux.Equals(""))
                {
                    string[] aux2 = aux.Split(',');
                    if (Convert.ToInt32(aux2[0]) == id)
                    {
                        txtPontos.Text = aux2[2];
                    }
                }
                    
            }
        }

        private void TimerProcces()
        {
            Bot bot = new Bot();
            string statusFab;
            statusFab = Jogo.LerFabricas(id, senha);
            statusFab = statusFab.Replace("\r", "");
            string[] fabricas = statusFab.Split('\n');
            bot.modeloS = modeloS;
            bot.paredeS = paredeS;

            if (id != 0)
            {

                string vez = Jogo.VerificarVez(id, senha);
                string[] vezJog = vez.Split(',');
                string ids = Convert.ToString(id);
                if (ids.Equals(vezJog[1]))
                {
                    atualizarFabricas();
                    Update();
                    string retorno = Jogo.LerCentro(id, senha);
                    retorno = retorno.Replace("\r", "");
                    string[] centros = retorno.Split('\n');
                    string statComp = bot.verificarFabricas(fabricas, id, senha, centros);
                    Pontos();
                    atualizarModeloC();
                    zerarFabricas();
                    atualizarModeloS();
                    atualizarCentro();
                    getStringChao();
                    Refresh();
                    atualizarParede();
                    Refresh();
                    
                }
            }


        }

    }
}

     