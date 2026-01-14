using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebesseg
{
    internal class Adat
    {
        public int meter;
        public string jelzes;
        
        public Adat(int meter, string jelzes)
        {
            this.meter = meter;
            this.jelzes = jelzes;
        }

        public override string ToString()
        {
            return meter + " m, " + jelzes;
        }
    }
}
