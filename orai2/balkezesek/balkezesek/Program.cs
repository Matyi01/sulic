using balkezesek;
using System.Linq;

List<Jatekos> jatekosok = new List<Jatekos>();

string[] sorok = File.ReadAllLines("balkezesek.csv");
foreach (string sor in sorok.Skip(1))
{
    string[] vag = sor.Split(';');
    jatekosok.Add(new Jatekos(vag[0], DateOnly.Parse(vag[1]), DateOnly.Parse(vag[2]), int.Parse(vag[3]), int.Parse(vag[4])));
}

Console.WriteLine($"3. feladat: {0}", jatekosok.Count);

var utoljara = jatekosok.Where(e => e.utoljara.Year == 1999 && e.utoljara.Month == 10);
Console.WriteLine("4.feladat:");
foreach (var jatekos in utoljara)
{
    Console.WriteLine($"\t{jatekos.nev}, {jatekos.magassagCm()} cm");
}

Console.WriteLine("5. feladat:");
int be = 0;
while (be < 1990 || be > 1999)
{
    Console.Write("Kérem adja meg a keresett évszámot (1990-1999): ");
    if (!int.TryParse(Console.ReadLine(), out be) || be < 1990 || be > 1999)
    {
        Console.Write("Hibás adat! ");
    }
}

Console.WriteLine("6. feladat: {1} font", be, Math.Round(jatekosok.Where(e => e.jatszotte(be)).Select(e => e.suly).Average(), 2));


Console.WriteLine(string.Join(", ", jatekosok[0].dekadok()));



