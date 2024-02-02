using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    internal class adatok
    {
        public int ora;
        public int perc;
        public int id;
        public bool benntvan;
        public string oraperc;
        public adatok(string sor)
        {
            string[] vag = sor.Split(" ");
            ora = Convert.ToInt32(vag[0]);
            perc = Convert.ToInt32(vag[1]);
            id = Convert.ToInt32(vag[2]);
            if (vag[3] == "be")
            { 
                benntvan = true;
            }
            else
            {
                benntvan = false;
            }
            oraperc = vag[0] + ":" + vag[1];
        }
    }
}
