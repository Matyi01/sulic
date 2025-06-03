using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    internal class Konyv
    {
        public int ev;
        public int negyedEv;
        public string eredet;
        public string leiras;
        public int db;
        public Konyv(int ev, int negyedEv, string eredet, string leiras, int db)
        {
            this.ev = ev;
            this.negyedEv = negyedEv;
            this.eredet = eredet;
            this.leiras = leiras;
            this.db = db;
        }
    }
}
