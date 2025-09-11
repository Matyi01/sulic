using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoapp
{
    internal class Auto
    {
        public int sorszam;
        public string marka;
        public string modell;
        public int ev;
        public string szin;
        public int db;
        public int ar;

        public Auto(string sor)
        {
            string[] vag = sor.Split(';');
            this.sorszam = int.Parse(vag[0]);
            this.marka = vag[1];
            this.modell = vag[2];
            this.ev = int.Parse(vag[3]);
            this.szin = vag[4];
            this.db = int.Parse(vag[5]);
            this.ar = int.Parse(vag[6]);
        }
    }
}
