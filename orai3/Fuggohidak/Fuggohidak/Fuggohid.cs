using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggohidak
{
    internal class Fuggohid
    {
        //Helyezés	Híd	Hely	Ország	Hossz	Év
        public int helyezes;
        public string hely;
        public string orszag;
        public int hossz;
        public int ev;
        public Fuggohid(string sor)
        {
            string[] vag = sor.Split("\t");
            this.helyezes = int.Parse(vag[0]);
            this.hely = vag[1];
            this.orszag = vag[2];
            this.hossz = int.Parse(vag[3]);
            this.ev = int.Parse(vag[4]);

        }
    }
}
