using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP2
{
    internal class diak : udvariasember
    {
        private int kor;
        public diak(string vnev, string knev, int kor) : base(vnev, knev) 
        { 
            this.kor = kor;
        }
        public void iskola()
        {
            if (kor < 2) { Console.WriteLine("ÓóÓóÁáÁá"); }
            else if (kor < 3) { Console.WriteLine("Bölcsibe"); }
            else if (kor < 7) { Console.WriteLine("Ovis"); }
            else if (kor < 11) { Console.WriteLine("Alsós"); }
            else if (kor < 15) { Console.WriteLine("Felsős"); }
            else if (kor < 20) { Console.WriteLine("Technikum"); }
            else if (kor < 25) { Console.WriteLine("Egyetem"); }
            else { Console.WriteLine("Felsőoktatás"); }
        }
        public void koszon(diak diakvaltozo)
        {
            Random rand = new Random();
            int x = rand.Next(0, 3);
            if (x == 0)
            {
                Console.WriteLine("Csá {0}!", diakvaltozo.keresztnev);
            }
            else if (x == 1)
            {
                Console.WriteLine("Cső {0}!", diakvaltozo.keresztnev);
            }
            else
            {
                Console.WriteLine("Szevasz {0}!", diakvaltozo.keresztnev);
            }
        }
    }
}
