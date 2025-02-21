using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace tanciskola
{
    internal class Par
    {
        public string tanc;
        public string lany;
        public string fiu;
        public Par(string tanc, string lany, string fiu)
        {
            this.tanc = tanc;
            this.lany = lany;
            this.fiu = fiu;
        }
        public override string ToString()
        {
            return tanc + ": " + lany + ", " + fiu;
        }
    }
}
