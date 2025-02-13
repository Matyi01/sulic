using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb
{
    internal class Szin
    {
        public byte r;
        public byte g;
        public byte b;
        public Szin(int r, int g, int b)
        {
            this.r = (byte)r;
            this.g = (byte)g;
            this.b = (byte)b;
        }
        public override string ToString()
        {
            return "RGB(" + r + "," + g + "," + b + ")";
        }
        public bool Vilagos()
        {
            if (r + g + b > 600) { return true; }
            else { return false; }
        }
        public int Fenyero()
        {
            return r + g + b;
        }
    }
}
