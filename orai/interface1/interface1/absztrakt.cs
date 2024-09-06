using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    internal abstract class absztrakt:Interface1
    {
        public int szam()
        {
            return 1000000;
        }
        public abstract void kiir();

        int privattuska = 0;
        public int tusko
        {
            get { return privattuska; }
            set { privattuska = value; }
        }
    }
}
