using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace rgb
{
    internal class Pixel
    {
        public int x;
        public int y;
        public Szin rgb;
        public Pixel(int x, int y, Szin rgb)
        {
            this.x = x;
            this.y = y;
            this.rgb = rgb;
        }
        public override string ToString()
        {
            return x +", "+ y +" - "+ rgb;
        }
    }
}
