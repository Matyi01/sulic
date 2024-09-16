using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classerika
{
    internal class Class1
    {
        public int szam;
        public Random random = new Random();
        public Class1()
        {
            szam = random.Next(-100, 100);
        }
        static public bool parose()
        {
            if (szam % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
