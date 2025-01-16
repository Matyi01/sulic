using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jelado
{
    internal class adat
    {
        public int ora;
        public int perc;
        public int mp;
        public int x;
        public int y;
        public adat(string sor)
        {
            string[] vag = sor.Split(" ");
            ora = Convert.ToInt32(vag[0]);
            perc = Convert.ToInt32(vag[1]);
            mp = Convert.ToInt32(vag[2]);
            x = Convert.ToInt32(vag[3]);
            y = Convert.ToInt32(vag[4]);
        }
    }
}
