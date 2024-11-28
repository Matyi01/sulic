using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopdoga1
{
    internal class penztarca
    {
        public int penz;
        public penztarca(int penz)
        {
            this.penz = penz;
        }
        public static penztarca operator -(penztarca p1, int p2)
        {
            penztarca tempp1 = new penztarca(p1.penz);

            if (tempp1.penz >= p2)
            {
                tempp1.penz -= p2;
                return tempp1;
            }
            else
            {
                return tempp1;
            }
        }
        public static penztarca operator -(penztarca p1, penztarca p2)
        {
            penztarca tempp1 = new penztarca(p1.penz);
            penztarca tempp2 = new penztarca(p2.penz);

            if (tempp1.penz >= tempp2.penz)
            {
                tempp1.penz -= tempp2.penz;
                tempp2.penz += tempp1.penz;
                return tempp1;
            }
            else
            {
                return tempp1;
            }
        }
        public static int operator -(int p1, penztarca p2)
        {
            penztarca tempp2 = new penztarca(p2.penz);

            if (p1 >= tempp2.penz)
            {
                p1 -= tempp2.penz;
                tempp2.penz += p1;
                return p1;
            }
            else
            {
                return p1;
            }
        }
        public static penztarca operator +(penztarca p1, int p2)
        {
            penztarca tempp1 = new penztarca(p1.penz);
            return tempp1;
        }
        public static penztarca operator +(penztarca p1, penztarca p2)
        {
            penztarca tempp1 = new penztarca(p1.penz);
            penztarca tempp2 = new penztarca(p2.penz);


                tempp1.penz += tempp2.penz;
                tempp2.penz -= tempp1.penz;
                return tempp1;

        }
        public static int operator +(int p1, penztarca p2)
        {
            penztarca tempp2 = new penztarca(p2.penz);


                p1 += tempp2.penz;
                tempp2.penz -= p1;
                return p1;

        }
        public override string ToString()
        {
            return $"Pénz: {penz} Eur";
        }
    }
}
