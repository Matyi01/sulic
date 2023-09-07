using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf1
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 99;
            string elso;
            string masodik;
            Console.WriteLine(szam);
            if (szam / 90 == 1)
            {
                elso = "kilencven";
                Console.Write(elso);
                szam -= 90;
            }
            else if (szam / 80 == 1)
            {
                elso = "nyolcvan";
                Console.Write(elso);
                szam -= 80;
            }
            else if (szam / 70 == 1)
            {
                elso = "hetven";
                Console.Write(elso);
                szam -= 70;
            }
            else if (szam / 60 == 1)
            {
                elso = "hatvan";
                Console.Write(elso);
                szam -= 60;
            }
            else if (szam / 50 == 1)
            {
                elso = "ötven";
                Console.Write(elso);
                szam -= 50;
            }
            else if (szam / 40 == 1)
            {
                elso = "negyven";
                Console.Write(elso);
                szam -= 40;
            }
            else if (szam / 30 == 1)
            {
                elso = "harminc";
                Console.Write(elso);
                szam -= 30;
            }
            else if (szam == 20)
            {
                elso = "husz";
                Console.WriteLine(elso);
            }
            else if (szam / 20 == 1)
            {
                elso = "huszon";
                Console.Write(elso);
                szam -= 20;
            }
            else if (szam == 10)
            {
                elso = "tiz";
                Console.WriteLine(elso);
            }
            else if (szam / 10 == 1)
            {
                elso = "tizen";
                Console.Write(elso);
                szam -= 10;
            }
            if (szam == 9)
            {
                masodik = "kilenc";
                Console.WriteLine(masodik);
            }
            else if (szam == 8)
            {
                masodik = "nyolc";
                Console.WriteLine(masodik);
            }
            else if (szam == 7)
            {
                masodik = "hét";
                Console.WriteLine(masodik);
            }
            else if (szam == 6)
            {
                masodik = "hat";
                Console.WriteLine(masodik);
            }
            else if (szam == 5)
            {
                masodik = "öt";
                Console.WriteLine(masodik);
            }
            else if (szam == 4)
            {
                masodik = "négy";
                Console.WriteLine(masodik);
            }
            else if (szam == 3)
            {
                masodik = "három";
                Console.WriteLine(masodik);
            }
            else if (szam == 2)
            {
                masodik = "kettő";
                Console.WriteLine(masodik);
            }

            else if (szam == 1)
            {
                masodik = "egy";
                Console.WriteLine(masodik);
            }
        }
    }
}
