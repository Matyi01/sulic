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
            int it = 0;
            it ++;
            it --;
            Console.WriteLine(it++);
            Console.WriteLine(++it);
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
            double tort = 1;
            while (tort < 5)
            {
                Console.WriteLine(tort);
                tort += .1;
            }
            do
            {
                tort -= .2;
                Console.WriteLine(tort);
            }
            while (tort > 2);
            char s = 'a';
            while (s <= 'z')
            {
                Console.Write(s);
                s = (char)(s + 1);
            }
            Console.WriteLine();
            int n = 32;
            while (n <= 255)
            {
                Console.Write((char)n+"  ");
                n += 1;
                if (n % 8 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            int ossz = 0;
            for (int i = 1; i <= 15; i++)
                ossz += i;
            Console.WriteLine(ossz);
            for (int i = 9; i >= 0; i--)
                Console.WriteLine(i);
            for (int i = 0; i < 10; i++)
                Console.WriteLine(9-i);
        }
    }
}
