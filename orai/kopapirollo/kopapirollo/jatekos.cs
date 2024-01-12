using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopapirollo
{
    internal class jatekos
    {
        string[] lehetosegek = new string[] {"kő", "papír", "olló"};
        public string valasztas;
        public jatekos()
        {
            Random rand = new Random();
            valasztas = lehetosegek[rand.Next(0,lehetosegek.Length)];
        }
        public void kinyer(jatekos masik)
        {
            if (valasztas == masik.valasztas)
            {
                Console.WriteLine("Döntetlen");
            }
            else
            {
                if (valasztas == lehetosegek[0] && masik.valasztas == lehetosegek[1])
                {

                }
            }
        }
    }
}
