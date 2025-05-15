using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jackie_console
{
    internal class VersenyEv
    {
        public int ev;
        public int versenydb;
        public int nyert;
        public int dobogos;
        public int pole;
        public int leggyorsabbkordb;
        public int evtized;

        public VersenyEv(int ev, int versenydb, int nyert, int dobogos, int pole, int leggyorsabbkordb)
        {
            this.ev = ev;
            this.versenydb = versenydb;
            this.nyert = nyert;
            this.dobogos = dobogos;
            this.pole = pole;
            this.leggyorsabbkordb = leggyorsabbkordb;

            evtized = (this.ev - 1900) / 10;
            //evtized = this.ev % 100 / 10;
            evtized *= 10;
        }
    }
}
