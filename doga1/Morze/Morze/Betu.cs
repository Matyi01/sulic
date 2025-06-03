using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    internal class Betu
    {
        public string karakter;
        public string morzeKarakter;
        public Betu(string sor)
        {
            karakter = sor.Split("\t")[0];
            morzeKarakter = sor.Split("\t")[1];
        }
    }
}
