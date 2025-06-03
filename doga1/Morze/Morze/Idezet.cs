using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    internal class Idezet
    {
        public string szerzo;
        public string szoveg;
        public Idezet(string sor)
        {
            szerzo = sor.Split(";")[0];
            szoveg = sor.Split(";")[1];
        }
    }
}
