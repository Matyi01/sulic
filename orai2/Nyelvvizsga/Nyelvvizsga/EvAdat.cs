using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class EvAdat
    {
        public int ev;
        public int db;
        public EvAdat(int ev, int db)
        {
            this.ev = ev;
            this.db = db;
        }
        public static int operator +(EvAdat a, EvAdat b)
        {
            return a.db + b.db;
        }
        public static int operator +(EvAdat a, int b)
        {
            return a.db + b;
        }
        public static int operator +(int a, EvAdat b)
        {
            return a + b.db;
        }
    }
}
