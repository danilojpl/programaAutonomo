using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace WindowsFormsApp1
{
    class Bot 
    {

        int fab, azul,i=0;
        string retorno=null;
        public string [] modeloS  { get; set; }
        public string[] paredeS { get; set; }
        public string [,] fabricaS { get; set; }
        public string verificarFabricas(string []fabricas,int id,string senha,string[] centro)
        {


            foreach (string aux in fabricas)
            {
                if (i > modeloS.Length)
                    i = 0;

                string[] aux2 = aux.Split(',');
                if (!aux.Equals(""))
                {
                    fab = Convert.ToInt32(aux2[0]);
                    azul = Convert.ToInt32(aux2[1]);

                    switch (aux2[3])
                    {

                        case "1":
                            if (modeloS[0] == null)
                            {
                                retorno = Jogo.Jogar(id, senha, "F", fab, azul, 1);
                                if (retorno.Equals(""))
                                    return retorno;
                               
                            }
                                for (int i = 0; i < modeloS.Length; i++)
                                {
                                    if (modeloS[i] != null)
                                    {
                                        string[] aux3 = modeloS[i].Split(',');
                                        if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 1)
                                        {
                                        if (Convert.ToInt32(aux3[1]) == azul)
                                        {
                                            retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }
                                    }
                                         if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 2)
                                        {
                                        if (Convert.ToInt32(aux3[1]) == azul)
                                        {
                                            retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }
                                        }
                                        if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 3)
                                        {
                                        if (Convert.ToInt32(aux3[1]) == azul)
                                        {
                                            retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }

                                        }
                                    if (Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]))
                                    {
                                        retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }

                                    else
                                    {
                                        bool chao = true;
                                        for (int k = 0; k < modeloS.Length; k++)
                                        {
                                            string[] aux4 = modeloS[i].Split(',');
                                            if (modeloS[i] == null || Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]) && Convert.ToInt32(aux4[1]) == azul)
                                            {
                                                chao = false;
                                                break;
                                            }
                                        }
                                        if (chao == true && aux2[0].Equals('5'))
                                        {
                                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }
                                    }

                                }
                                    else
                                    {
                                        retorno = Jogo.Jogar(id, senha, "F", fab, azul, i + 1);
                                    if (retorno.Equals(""))
                                        return retorno;
                                }

                                
                                }


                            break;
                        case "2":
                            if (modeloS[1] == null)
                            {
                                retorno = Jogo.Jogar(id, senha, "F", fab, azul, 2);
                                if (retorno.Equals(""))
                                    return retorno;
                            }
                            
                                for (int i = 0; i < modeloS.Length; i++)
                                {
                                if (modeloS[i] != null)
                                {
                                    string[] aux3 = modeloS[i].Split(',');
                                    if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 2)
                                    {
                                        if (Convert.ToInt32(aux3[1]) == azul)
                                        {
                                            retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[2]));
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }

                                    }
                                    if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 3)
                                    {
                                        if (Convert.ToInt32(aux3[1]) == azul)
                                        {
                                            retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[2]));
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }
                                    }

                                    if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 4)
                                    {
                                        retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[2]));
                                        if (retorno.Equals(""))
                                            return retorno;

                                    }

                                    if (Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]))
                                    {
                                        retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[2]));
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }
                                    else
                                    {
                                        bool chao = true;
                                        for (int k = 0; k < modeloS.Length; k++)
                                        {
                                            string[] aux4 = modeloS[i].Split(',');
                                            if (modeloS[i] == null || Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]) && Convert.ToInt32(aux4[1]) == azul)
                                            {
                                                chao = false;
                                                break;
                                            }
                                        }
                                        if (chao == true && aux2[0].Equals('5'))
                                        {
                                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }
                                    }
                                }
                                else
                                {
                                    retorno = Jogo.Jogar(id, senha, "F", fab, azul, i + 1);
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                            }
                            break;
                        case "3":
                            if (modeloS[2] == null)
                            {
                                retorno = Jogo.Jogar(id, senha, "F", fab, azul, 3);
                                if (retorno.Equals(""))
                                    return retorno;

                            }
                            
                                for (int i = 0; i < modeloS.Length; i++)
                                {
                                if (modeloS[i] != null)
                                {
                                    string[] aux3 = modeloS[i].Split(',');
                                    if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 3)
                                    {
                                        retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                        if (retorno.Equals(""))
                                            return retorno;

                                    }
                                    if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 4)
                                    {
                                        retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }

                                    if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 5)
                                    {
                                        retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }
                                    else
                                    {
                                        bool chao = true;
                                        for (int k = 0; k < modeloS.Length; k++)
                                        {
                                            string[] aux4 = modeloS[i].Split(',');
                                            if (modeloS[i] == null || Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]) && Convert.ToInt32(aux4[1]) == azul)
                                            {
                                                chao = false;
                                                break;
                                            }
                                        }
                                        if (chao == true && aux2[0].Equals('5'))
                                        {
                                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }
                                    }
                                }
                                else
                                {
                                    retorno = Jogo.Jogar(id, senha, "F", fab, azul, i + 1);
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                            }
                            break;
                        case "4":
                            if (modeloS[3] == null)
                            {
                                retorno = Jogo.Jogar(id, senha, "F", fab, azul, 4);
                                if (retorno.Equals(""))
                                    return retorno;
                            }
                            
                                for (int i = 0; i < modeloS.Length; i++)
                                {
                                if (modeloS[i] != null)
                                {
                                    string[] aux3 = modeloS[i].Split(',');
                                    if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 4)
                                    {
                                        if (Convert.ToInt32(aux3[1]) == azul)
                                        {
                                            retorno = Jogo.Jogar(id, senha, "F", fab, azul, Convert.ToInt32(aux3[0]));
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }

                                    }
                                    else
                                    {
                                        bool chao = true;
                                        for (int k = 0; k < modeloS.Length; k++)
                                        {
                                            string[] aux4 = modeloS[i].Split(',');
                                            if (modeloS[i] == null || Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]) && Convert.ToInt32(aux4[1]) == azul)
                                            {
                                                chao = false;
                                                break;
                                            }
                                        }
                                        if (chao == true && aux2[0].Equals('5'))
                                        {
                                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                            if (retorno.Equals(""))
                                                return retorno;
                                        }
                                    }
                                }
                                else
                                {
                                    retorno = Jogo.Jogar(id, senha, "F", fab, azul, i + 1);
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                }
                            break;
                    }

                }
            }
            string[] menor = centro[0].Split(',');
            for (int i = 0; i < centro.Length; i++)
            {
                if (!centro[i].Equals(""))
                {
                    string[] aux = centro[i].Split(',');
                    if (Convert.ToInt32(menor[2]) >= Convert.ToInt32(aux[2]) && Convert.ToInt32(aux[2])!=0 || menor[2].Equals("0"))
                        menor = aux;
                }

            }

            if (menor[2].Equals("1"))
                    for (int i = 0; i < modeloS.Length; i++)
                    {
                        string[] aux;
                        if (modeloS[i] != null)
                            if (!modeloS[i].Equals(""))
                            {
                                {
                                    aux = modeloS[i].Split(',');
                                if (aux[1].Equals(menor[0]) && Convert.ToInt32(aux[2]) < Convert.ToInt32(aux[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(menor[0]), Convert.ToInt32(aux[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }

                                else if (Convert.ToInt32(aux[2]) < Convert.ToInt32(aux[0]) && Convert.ToInt32(menor[2]) < 3)
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(menor[0]), Convert.ToInt32(aux[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                }
                            }
                    }

            foreach (string aux in centro)
            {
                if (!aux.Equals(""))
                {
                    string[] aux2 = aux.Split(',');

                    if (aux2[2].Equals("1"))
                    {
                        if (modeloS[0] == null)
                        {
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 1);
                            if (retorno.Equals(""))
                                return retorno;

                        }

                        for (int j = 0; j < modeloS.Length; j++)
                        {

                            if (modeloS[j] != null)
                            {

                                string[] aux3 = modeloS[j].Split(',');

                                if (aux2[1].Equals(aux3[1]) && Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]))

                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[1]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 1)
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                if (Convert.ToInt32(aux2[2]) < Convert.ToInt32(aux2[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }

                                else if (Convert.ToInt32(aux3[2]) + Convert.ToInt32(aux2[2]) < Convert.ToInt32(aux3[0]) + 2 && Convert.ToInt32(aux3[1]) == Convert.ToInt32(aux2[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                else if (Convert.ToInt32(aux2[2]) < Convert.ToInt32(aux3[0]) - Convert.ToInt32(aux3[2]) && Convert.ToInt32(aux3[1]) == Convert.ToInt32(aux2[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                //ultima condição comprar para o chão
                                else
                                {
                                    bool chao = true;
                                    for (int i = 0; i < modeloS.Length; i++)
                                    {
                                        if (modeloS[i] == null)
                                        {
                                            chao = false;
                                            break;
                                        }
                                    }
                                    if (chao == true)
                                    {
                                        retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }
                                }
                            }
                            else
                            {
                                retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), j + 1);
                                if (retorno.Equals(""))
                                    return retorno;
                            }
                        }
                    }


                    else if (aux2[2].Equals("2"))
                    {



                        if (modeloS[1] == null)
                        {
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 2);
                            if (retorno.Equals(""))
                                return retorno;

                        }

                        for (int j = 0; j < modeloS.Length; j++)
                        {
                            if (modeloS[j] != null)
                            {
                                string[] aux3 = modeloS[j].Split(',');

                                if (aux2[1].Equals(aux3[1]) && Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]))

                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[1]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }

                                if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 2)
                                {
                                    if (Convert.ToInt32(aux3[1]) == Convert.ToInt32(aux2[0]))
                                    {
                                        retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[1]));
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }
                                }
                                else if (Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux2[2]) && Convert.ToInt32(aux3[1]) == Convert.ToInt32(aux2[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[1]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                else if (Convert.ToInt32(aux2[2]) < Convert.ToInt32(aux3[0]) - Convert.ToInt32(aux3[2]) && Convert.ToInt32(aux3[1]) == Convert.ToInt32(aux2[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                //ultima condição comprar para o chão
                                else
                                {
                                    bool chao = true;
                                    for (int i = 0; i < modeloS.Length; i++)
                                    {
                                        if (modeloS[i] == null)
                                        {
                                            chao = false;
                                            break;
                                        }
                                    }
                                    if (chao == true)
                                    {
                                        retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }
                                }

                            }
                            else
                            {
                                retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), j + 1);
                                if (retorno.Equals(""))
                                    return retorno;
                            }

                        }
                    }
                    else if (aux2[2].Equals("3"))
                    {
                        if (modeloS[2] == null)
                        {
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 3);
                            if (retorno.Equals(""))
                                return retorno;
                        }

                        for (int j = 0; j < modeloS.Length; j++)
                        {
                            if (modeloS[j] != null)
                            {
                                string[] aux3 = modeloS[j].Split(',');

                                if (Convert.ToInt32(aux3[2]) == Convert.ToInt32(aux3[0]) - 3)
                                {
                                    if (Convert.ToInt32(aux3[1]) == Convert.ToInt32(aux2[0]))
                                    {
                                        retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[0]));
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }
                                }
                                if (aux2[1].Equals(aux3[1]) && Convert.ToInt32(aux3[2]) < Convert.ToInt32(aux3[0]))

                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[1]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                                else if (Convert.ToInt32(aux2[2]) < Convert.ToInt32(aux3[0]) - Convert.ToInt32(aux3[2]) && Convert.ToInt32(aux3[1]) == Convert.ToInt32(aux2[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(aux3[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }

                                //ultima condição comprar para o chão
                                else
                                {
                                    bool chao = true;
                                    for (int i = 0; i < modeloS.Length; i++)
                                    {
                                        if (modeloS[i] == null)
                                        {
                                            chao = false;
                                            break;
                                        }
                                    }
                                    if (chao == true)
                                    {
                                        retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                        if (retorno.Equals(""))
                                            return retorno;
                                    }
                                }

                            }
                            else
                            {
                                retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), j + 1);
                                if (retorno.Equals(""))
                                    return retorno;
                            }

                        }
                    }

                    else if (aux2[2].Equals("4"))
                    {
                        if (modeloS[3] == null)
                        {
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 4);
                            if (retorno.Equals(""))
                                return retorno;

                        }
                        if (modeloS[4] == null)
                        {
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 5);
                            if (retorno.Equals(""))
                                return retorno;
                        }

                        else
                        {
                            bool chao = true;
                            for (int i = 0; i < modeloS.Length; i++)
                            {
                                if (modeloS[i] == null)
                                {
                                    chao = false;
                                    break;
                                }
                            }
                            if (chao == true)
                            {
                                retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                                if (retorno.Equals(""))
                                    return retorno;
                            }
                        }
                    }
                      else if (aux2[2].Equals("5"))
                    {
                        if (modeloS[4] == null)
                        {
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 5);
                            if (retorno.Equals(""))
                                return retorno;

                        }
                        if (modeloS[3] == null)
                        {
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 4);
                            if (retorno.Equals(""))
                                return retorno;

                        }
                        else
                            for (int i = 0; i < modeloS.Length; i++)
                            {
                                if (modeloS[i] == null)
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), i + 1);
                                if (retorno.Equals(""))
                                    return retorno;
                            }
                    }
                    else if (Convert.ToInt32(aux2[2]) > 5)
                    {
                        bool novaEsc = false;
                        for (int i = 0; i < centro.Length; i++)
                        {
                            
                            string[] auxx = centro[i].Split(',');
                            if(!auxx[0].Equals(""))
                            if (Convert.ToInt32(auxx[2]) < 5 && auxx[0].Equals(aux2[0])) {

                                    novaEsc = true;
                            }

                                

                        }
                        if (novaEsc == true)
                        {
                            for (int i = 0; i < centro.Length; i++)
                            {
                                string[] auxx = modeloS[i].Split(',');
                                if (Convert.ToInt32(auxx[2]) < Convert.ToInt32(auxx[0]))
                                {
                                    retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), Convert.ToInt32(auxx[0]));
                                    if (retorno.Equals(""))
                                        return retorno;
                                }
                            }

                        }
                        else
                            retorno = Jogo.Jogar(id, senha, "C", 0, Convert.ToInt32(aux2[0]), 0);
                        if (retorno.Equals(""))
                            return retorno;
                    }

                }
            }
       
                    
            return retorno;

        }
    }
}
