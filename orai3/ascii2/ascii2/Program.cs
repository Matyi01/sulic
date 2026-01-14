static string atalakit(string sor)
{
    string vissza = "";
    for (int i = 0; i < sor.Length - 1; i += 2)
    {
        vissza += new string(sor[i + 1], int.Parse(sor[i].ToString()));
    }
    return vissza;
}


Console.WriteLine("1. feladat");

List<string> konyv = new List<string>(File.ReadLines("konyv.txt"));

foreach (string sor in konyv)
{
    Console.WriteLine(sor);
}


Console.WriteLine("2. feladat");

Console.Write("Kérem adja meg az ismétlések számát: ");
int n = int.Parse(Console.ReadLine()!);

string elvalaszto = " | ";

foreach (string sor in konyv)
{
    string temp = sor;
    for (int i = 0; i < n; i++)
    {
        while (temp.Length < 12)
        {
            temp += " ";
        }
        Console.Write(temp + elvalaszto);
    }
    Console.WriteLine();
}


Console.WriteLine("4. feladat");

List<string> szg_t = new List<string>(File.ReadLines("szg_t.txt"));

foreach (string sor in szg_t)
{
    Console.WriteLine(atalakit(sor));
}

File.WriteAllLines("szg.txt", szg_t.Select(sor => atalakit(sor)));


Console.WriteLine("5. feladat");

Console.Write("Kérem adja meg a tömörített ábra fájlnevét: ");
string tomoritettFajlNev = Console.ReadLine()!;
Console.Write("Kérem adja meg a tömörítettlen ábra fájlnevét: ");
string tomoritettlenFajlNev = Console.ReadLine()!;

List<string> tomoritett = new List<string>(File.ReadLines(tomoritettFajlNev));
List<string> tomoritettlen = new List<string>(File.ReadLines(tomoritettlenFajlNev));

int tomoritettDb = 0;
int tomoritettlenDb = 0;

foreach (string sor in tomoritett)
{
    tomoritettDb += sor.TrimEnd().Length;
}

foreach (string sor in tomoritettlen)
{
    tomoritettlenDb += sor.TrimEnd().Length;
}

Console.WriteLine("A karakterek száma a tömörített állományban: " + tomoritettDb);
Console.WriteLine("A karakterek száma a tömörítetlen állományban: " + tomoritettlenDb);
Console.WriteLine("A tömörítési arány: " + ((double)tomoritettDb / tomoritettlenDb).ToString("0.##"));


Console.WriteLine("6. feladat");

List<string> konyv_t = new List<string>(File.ReadLines("konyv_t.txt"));

Console.WriteLine("Az ábra magassága sorokban: " + konyv_t.Count);

int leghosszabb = 0;
foreach (string sor in konyv_t)
{
    if (atalakit(sor).Length > leghosszabb)
    {
        leghosszabb = atalakit(sor).Length;
    }
}
Console.WriteLine("Az ábra szélessége karakterekben: " + leghosszabb);

int blokkDb = 0;
foreach (string sor in konyv_t)
{
    blokkDb += sor.Length / 2;
}
Console.WriteLine("A blokkok száma: " + blokkDb);
