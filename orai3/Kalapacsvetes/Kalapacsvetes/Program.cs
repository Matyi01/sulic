
using Kalapacsvetes2;

string[] olvas = File.ReadAllLines("kalapacsvetes.txt");

List<Sportolo> sportolok = new List<Sportolo>();

foreach (string line in olvas.Skip(1))
{
    sportolok.Add(new Sportolo(line));
}

Console.WriteLine("4. feladat: {0} dobás eredménye található.", sportolok.Count);

double sum = 0;
int db = 0;

foreach (Sportolo e in sportolok)
{
    if (e.orszagkod == "HUN")
    {
        sum += e.eredmeny;
        db++;
    }
}

Console.WriteLine("5. feladat: A magyar sportolók átlagosan {0} métert dobtak.", sum / db);


Console.Write("6. feladat: Adjon meg egy évszámot: ");
int inputev = int.Parse(Console.ReadLine());
int db2 = 0;
List<string> azok = new List<string>();

foreach (Sportolo e in sportolok)
{
    if (int.Parse(e.datum.Substring(0,4)) == inputev)
    {
        db2++;
        azok.Add(e.sportolo);
    }
}
Console.WriteLine("{0} darab dobás került be ebben az évben.", db2);
azok.ForEach(e => Console.WriteLine(e));


Console.WriteLine("7. feladat: statisztika");

Dictionary<string, int> nemzetek = new Dictionary<string, int>();

foreach (Sportolo e in sportolok)
{
    if (nemzetek.Keys.Contains(e.orszagkod))
    {
        nemzetek[e.orszagkod]++;
    }
    else
    {
        nemzetek[e.orszagkod] = 1;
    }
}

foreach (KeyValuePair<string, int> e in nemzetek)
{
    Console.WriteLine("{0} - {1}", e.Key, e.Value);
}

StreamWriter ir = new StreamWriter("magyarok.txt");

foreach (Sportolo e in sportolok)
{
    if(e.orszagkod == "HUN")
    {
        ir.WriteLine(e);
    }
}

ir.Close();


