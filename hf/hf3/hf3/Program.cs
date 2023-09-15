using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int elso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy nagyobb számot: ");
            int masodik = Convert.ToInt32(Console.ReadLine());
            for (int i = elso; i <= masodik; i++)
            {
                double sqr = Math.Pow(i, 2);
                Console.WriteLine(sqr);
            }


            string szavak = "";
            while (true)
            {
                Console.Write("Kérek egy szót: ");
                string szo = Convert.ToString(Console.ReadLine());
                if (szo == "")
                {
                    Console.WriteLine(szavak);
                    break;
                }
                else
                {
                    szavak += szo+", ";
                }

            }
        }
    }
}
