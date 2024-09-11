using System.Diagnostics;

static List<string> f1(string file)
{
    List<string> mondatok = new List<string>();
    StreamReader olvas = new StreamReader(file);
    while (!olvas.EndOfStream)
    {
        mondatok.Add(olvas.ReadLine());
    }
    olvas.Close();
    return mondatok;
}

static List<string> f2(List<string> mondatok)
{
    Random random = new Random();
    List<string> szavak = new List<string>();
    for (int i = 0; i < mondatok.Count; i++)
    {
        szavak.Add(f3(mondatok[i], random.Next(1, mondatok[i].Split(" ").Length)).Replace(",", "").Replace(".", "").Trim());
    }
    return szavak;
}

static string f3(string sor, int szam)
{
    return sor.Split(" ")[szam];
}


List<string> mondatok = f1("szoveg.txt");
List<string> szavak = f2(mondatok);
for (int i = 0;i < szavak.Count; i++)
{
    Console.WriteLine(szavak[i]);
}

