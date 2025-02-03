using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link1
{
    internal class Adatok
    {
        public int kezd;
        public int veg;
        public string szin;
        public int sorszam;
        public Adatok(string sor)
        {
            string[] vag = sor.Split(' ');
            this.kezd = int.Parse(vag[0]);
            this.veg = int.Parse(vag[1]);
            this.szin = vag[2];
        }
        public bool kapubentvan
        {
            get { return kezd > veg; }
        }
    }
}
