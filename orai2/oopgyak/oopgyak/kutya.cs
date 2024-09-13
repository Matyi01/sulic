using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgyak
{
    internal class kutya
    {
        public string nev;
        public kutya(string nev)
        {
            this.nev = nev;
            Console.WriteLine("kutya létrejött");
        }
        public void ugat()
        {
            Console.WriteLine("wauuu");
        }
        private float _suly;
        public float suly
        {
            get
            {
                return _suly;
            }
            set
            {
                _suly = Math.Abs(value);
            }
        }
        public override string ToString()
        {
            return "Wau "+nev+" wau wau!";
        }
        static public string ezmiez()
        {
            return "Ez egy kutya objektum";
        }
    }
}
