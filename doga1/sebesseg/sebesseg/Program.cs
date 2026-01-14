using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Adat> adatok = new List<Adat>();

            StreamReader olvas = new StreamReader("ut.txt");

            int teljesHossz = int.Parse(olvas.ReadLine());

            while (!olvas.EndOfStream)
            {
                string[] sor = olvas.ReadLine().Split(' ');
                adatok.Add(new Adat(int.Parse(sor[0]), sor[1]));
            }

            olvas.Close();

            Console.WriteLine("2. feladat");
            foreach (var adat in adatok)
            {
                if (adat.jelzes.StartsWith("Varos"))
                {
                    Console.WriteLine(adat.jelzes);
                }
            }
            Console.WriteLine();

            Console.WriteLine("3. feladat");
            Console.Write("Adja meg a vizsgált szakasz hosszát km-ben! ");
            double szakaszHosszKm = double.Parse(Console.ReadLine());
            double szakaszHosszM = szakaszHosszKm * 1000;
            int minSebesseg = 90;
            int aktuálisSebesseg = 90;
            foreach (var adat in adatok)
            {
                if (adat.meter > szakaszHosszM)
                {
                    break;
                }
                if (int.TryParse(adat.jelzes, out int sebessegTabla))
                {
                    aktuálisSebesseg = sebessegTabla;
                }
                else
                {
                    switch (adat.jelzes)
                    {
                        case "%":
                            aktuálisSebesseg = 90;
                            break;
                    }
                }
                if (aktuálisSebesseg < minSebesseg)
                {
                    minSebesseg = aktuálisSebesseg;
                }
            }
            Console.WriteLine("Az els {0} km-en {1} km/h volt a legalacsonyabb megengedett sebesseg.", szakaszHosszKm, minSebesseg);
            Console.WriteLine();

            Console.WriteLine("4. feladat");
            int telepulesenBelulHossz = 0;
            bool telepulesenBelul = false;
            int elozoMeter = 0;
            foreach (var adat in adatok)
            {
                if (adat.jelzes.StartsWith("Varos"))
                {
                    telepulesenBelul = true;
                }
                else if (adat.jelzes == "]")
                {
                    telepulesenBelul = false;
                }
                if (telepulesenBelul)
                {
                    telepulesenBelulHossz += (adat.meter - elozoMeter);
                }
                elozoMeter = adat.meter;
            }

            double szazalek = (double)telepulesenBelulHossz / teljesHossz * 100;

            Console.WriteLine("Az út {0:F2} százaléka vezet településen belül.", szazalek);
            Console.WriteLine();

            Console.WriteLine("5. feladat");
            Console.Write("Adja meg egy település nevét! ");
            string telepulesNev = Console.ReadLine();
            int tablaSzam = 0;
            int telepulesenBelulHossz2 = 0;
            bool telepulesenBelul2 = false;
            int elozoMeter2 = 0;
            foreach (var adat in adatok)
            {
                if (adat.jelzes == telepulesNev)
                {
                    telepulesenBelul2 = true;
                }
                else if (adat.jelzes == "]" && telepulesenBelul2)
                {
                    telepulesenBelul2 = false;
                }
                if (telepulesenBelul2)
                {
                    telepulesenBelulHossz2 += (adat.meter - elozoMeter2);
                    if (int.TryParse(adat.jelzes, out int sebessegTabla))
                    {
                        tablaSzam++;
                    }
                }
                elozoMeter2 = adat.meter;
            }

            Console.WriteLine("A sebességkorlátozó táblák száma: {0}", tablaSzam);
            Console.WriteLine("Az út hossza a településen belül {0} méter.", telepulesenBelulHossz2);
            Console.WriteLine();

            Console.WriteLine("6. feladat");
            int keresettTelepulesKezdete = -1;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].jelzes == telepulesNev)
                {
                    keresettTelepulesKezdete = adatok[i].meter;
                    break;
                }
            }
            string legkozelebbiTelepules = "";
            int minTavolsag = int.MaxValue;
            int elozoTelepulesVege = -1;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].jelzes.StartsWith("Varos"))
                {
                    if (elozoTelepulesVege != -1)
                    {
                        int tavolsag = adatok[i].meter - elozoTelepulesVege;
                        if (tavolsag < minTavolsag && adatok[i].jelzes != telepulesNev)
                        {
                            minTavolsag = tavolsag;
                            legkozelebbiTelepules = adatok[i].jelzes;
                        }
                    }
                }
                else if (adatok[i].jelzes == "]")
                {
                    if (keresettTelepulesKezdete != -1 && adatok[i].meter < keresettTelepulesKezdete)
                    {
                        elozoTelepulesVege = adatok[i].meter;
                    }
                }
            }
            Console.WriteLine("A legközelebbi település: {0}", legkozelebbiTelepules);
        }
    }
}
