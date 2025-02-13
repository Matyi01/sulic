using rgb;
using System.Drawing;

static bool hatar(int sor, int ertek, List<Pixel> pontok)
{
    bool vissza = false;
    var elozo = pontok[0];
    foreach (var p in pontok)
    {
        if (p.x == sor)
        {
            if (elozo.rgb.b - ertek > p.rgb.b || elozo.rgb.b + ertek < p.rgb.b)
            {
                vissza = true;
            }
            elozo = p;
        }
    }
    return vissza;
}

StreamReader olvas = new StreamReader("kep-1.txt");
List<Pixel> pontok = new List<Pixel>();
Pixel[,] yx = new Pixel[360, 640];
int y = 0;
while (!olvas.EndOfStream)
{
    int[] sor = Array.ConvertAll(olvas.ReadLine().Split(" "), int.Parse);
    for (int x = 0; x < sor.Length-2; x += 3)
    {
        Szin sz = new Szin(sor[x], sor[x + 1], sor[x + 2]);
        Pixel p = new Pixel(x/3 + 1, y + 1, sz);
        yx[y, x / 3] = p;
        pontok.Add(p);
    }
    y++;
}
olvas.Close();

Console.Write("Egy képpont színe (x): ");
int xbe = int.Parse(Console.ReadLine());
Console.Write("Egy képpont színe (y): ");
int ybe = int.Parse(Console.ReadLine());

Console.WriteLine(pontok.Where(p => p.x == xbe && p.y == ybe).ToArray()[0].rgb);
/*
foreach (Pixel p in pontok)
{
    if(p.x == xbe && p.y == ybe)
    {
        Console.WriteLine(p.rgb);
    }
}
Console.WriteLine(yx.Cast<Pixel>().Where(e => e.x == xbe && e.y == ybe).ToArray()[0].rgb);
foreach (Pixel p in yx)
{
    if (p.x == xbe && p.y == ybe)
    {
        Console.WriteLine(p.rgb);
    }
}
*/

Console.WriteLine("{0} vilásgos képpont van", pontok.Where(p => p.rgb.Vilagos()).Count());
//Console.WriteLine("{0} vilásgos képpont van", yx.Cast<Pixel>().Where(p => p.rgb.Vilagos()).Count());

var min = pontok.Select(p => p.rgb.Fenyero()).ToArray().Min();
Console.WriteLine("Legsötétebb pont RGB összege: {0}", min);
pontok.Where(p => p.rgb.Fenyero() == min).ToList().ForEach(p => Console.WriteLine(p.rgb));

for (int i = 0; i < pontok.Count; i++)
{
    Console.WriteLine(hatar(i+1, 10, pontok));
}