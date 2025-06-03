using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    internal class Jatekos
    {
        public string nev;
        public DateOnly eloszor;
        public DateOnly utoljara;
        public int suly;
        public int magassag;
        public Jatekos(string nev, DateOnly eloszor, DateOnly utoljara, int suly, int magassag)
        {
            this.nev = nev;
            this.eloszor = eloszor;
            this.utoljara = utoljara;
            this.suly = suly;
            this.magassag = magassag;
        }
        public double magassagCm()
        {

            return Math.Round(magassag * 2.54, 1);
        }
        public bool jatszotte(int ev)
        {
           return eloszor.Year <= ev && utoljara.Year >= ev;
        }
        public int[] dekadok()
        {
            List<int> list = new List<int>();
            for (int i = (int)Math.Floor(eloszor.Year / 10.0) * 10; i <= utoljara.Year; i += 10)
            {
                list.Add(i);
            }
            return list.ToArray();
        }
    }
}