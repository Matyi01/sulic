using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            int szam = 6;
            int szam2 = -6;
            double szam3 = 6.6;
            Console.WriteLine(szam);
            Console.WriteLine(szam2);
            Console.WriteLine(szam3);
            char betu = 'a';
            Console.WriteLine(betu);
            Console.WriteLine((char)(betu+2));
            Console.WriteLine((char)1);
            Console.WriteLine(Convert.ToInt32(betu));
            Console.WriteLine(10/(double)3);
            int i = 0;
            i ++;
            i --;
            Console.WriteLine(i++);
            Console.WriteLine(++i);
            int a;
            a = 5;
            if (a > 2)
            {
                Console.WriteLine("Nagyobb");
            }
            else if (a < 2)
            {
                Console.WriteLine("Kisebb");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Egyenlő");
            }
            switch (a)
            {
                case 1:
                    Console.WriteLine("Egy");
                    break;
                case 2:
                    Console.WriteLine("Kettő");
                    break;
                case 3:
                    Console.WriteLine("Három");
                    break;
                case 4:
                    Console.WriteLine("Négy");
                    break;
                default:
                    Console.WriteLine("Valami más");
                    break;
            }
        }
    }
}
