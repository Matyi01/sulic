using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("autok.csv");
            List<Auto> autok = new List<Auto>();
            foreach (string sor in sorok.Skip(1))
            {
                autok.Add(new Auto(sor));
            }

            Console.WriteLine("5. feladat: {0} autó található a listában", autok.Count);

            List<double> darabok = new List<double>();
            foreach (Auto e in autok)
            {
                darabok.Add(e.db);
            }

            Console.WriteLine("6. feldadat: Az autók esetében az átlagosan eladott darabszám {0}", (darabok.Sum() / darabok.Count()).ToString("0.0"));

            Console.WriteLine("7. feladat: Az elmúlt 5 évben gyártott autók:");

            foreach (Auto e in autok)
            {
                if (e.ev > 2018 && e.ev < 2024)
                {
                    Console.WriteLine("- {0} {1}: {2}", e.marka, e.modell, e.ev);
                }
            }

            Console.WriteLine("8. feladat: Legsikeresebb márkák listája az eladott darabszám alapján:");

            Dictionary<string, int> adatok = new Dictionary<string, int>();

            foreach (Auto e in autok)
            {
                if (adatok.Keys.Contains(e.marka))
                {
                    adatok[e.marka] += e.db;
                }
                else
                {
                    adatok[e.marka] = e.db;
                }
            }

            foreach (KeyValuePair<string, int> e in adatok)
            {
                Console.WriteLine("- {0}: {1} darab", e.Key, e.Value);
            }





        }
    }
}
