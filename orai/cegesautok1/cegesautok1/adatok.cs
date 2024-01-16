using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cegesautok1
{
    internal class adatok
    {
        public int nap;
        public string ido;
        public string rendszam;
        public int szemelyid;
        public int km;
        bool parkol;

        public adatok(string sor)
        {
            string[] vag = sor.Split(" ");
            nap = Convert.ToInt32(vag[0]);
            ido = vag[1];
            rendszam = vag[2];
            szemelyid = Convert.ToInt32(vag[3]);
            km = Convert.ToInt32(vag[4]);
            parkol = vag[5] == "1";
        }
        public bool parkole()
        {
            return parkol;
        }
        public string f3sor() 
        {
            return ido+" "+rendszam+" "+szemelyid+(parkol?" be":" ki");
        }
    }
}
