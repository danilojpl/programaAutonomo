using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Partida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string data { get; set; }
        public string status { get; set; }

        public string getAtributo (string partida, int pos)
        {
            string [] atributos = partida.Split(',');
            return atributos[pos];
        }


    }
}
