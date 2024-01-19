using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952
{
    internal class adatok
    {
        public int helyezes;
        public int fo;
        public string sportag;
        public string versenyszam;
        public adatok(string sor)
        {
            string[] vag = sor.Split(" ");
            helyezes = Convert.ToInt32(vag[0]);
            fo = Convert.ToInt32(vag[1]);
            sportag = vag[2];
            versenyszam = vag[3];
        }
    }
}
