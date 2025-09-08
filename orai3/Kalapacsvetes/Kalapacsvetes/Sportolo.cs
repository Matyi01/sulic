using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes2
{
    internal class Sportolo
    {
        public int helyezes;
        public double eredmeny;
        public string sportolo;
        public string orszagkod;
        public string helyszin;
        public string datum;

        public Sportolo(string sor)
        {
            string[] vag = sor.Split(";");
            this.helyezes = int.Parse(vag[0]);
            this.eredmeny = double.Parse(vag[1]);
            this.sportolo = vag[2];
            this.orszagkod = vag[3];
            this.helyszin = vag[4];
            this.datum = vag[5];
        }

        public override string ToString()
        {
            return helyezes + ", " + eredmeny + ", " + sportolo + ", " + orszagkod + ", " + helyszin + ", " + datum;
        }
    }
}
