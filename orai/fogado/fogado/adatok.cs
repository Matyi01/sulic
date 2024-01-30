using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fogado
{
    internal class adatok
    {
        public string nev;
        public string idopont;
        public DateTime foglalas;
        public adatok(string sor)
        {
            string[] vag = sor.Split(" ");
            nev = vag[0] + " " + vag[1];
            idopont = vag[2];
            foglalas = Convert.ToDateTime(vag[3].Replace("-", " "));
        }

        public override string ToString()
        {
            return string.Format("Tanár neve: {0}\r\nFoglalt időpont: {1}\r\nFoglalás ideje: {2}", nev, idopont, foglalas);
        }
    }
}

