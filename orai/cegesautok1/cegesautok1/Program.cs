using cegesautok1;

List<adatok> autok = new List<adatok>();

StreamReader olvas = new StreamReader("autok.txt");

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    adatok a1 = new adatok(sor);
    autok.Add(a1);
}

olvas.Close();

Console.WriteLine("2. feladat");
for (int i = autok.Count-1; i > 0; i--)
{
    if (!autok[i].parkole())
    {
        Console.WriteLine("{0}. nap rendszám: {1}", autok[i].nap, autok[i].rendszam);
        break;
    }
}

Console.WriteLine("3. feladat");
Console.Write("Nap: ");
int nap = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Forgalom a(z) {0}. napon", nap);

for (int i = 0; i < autok.Count; i++)
{
    if (autok[i].nap == nap)
    {
        Console.Write("{0} {1} {2} ", autok[i].ido, autok[i].rendszam, autok[i].szemelyid);
        if (autok[i].parkole())
        {
            Console.WriteLine("be");
        }
        else
        {
            Console.WriteLine("ki");
        }
    }
}
for (int i = 0; i < autok.Count; i++)
{
    if (autok[i].nap == nap)
    {
        Console.WriteLine(autok[i].f3sor());
    }
}

int mennyivankinnt = 0;
for (int i = 0;i < autok.Count; i++)
{
    if (autok[i].parkole())
    {
        mennyivankinnt--;
    }
    else
    {
        mennyivankinnt++;
    }
}

Console.WriteLine("4. feladatok \nA hónap végén {0} autót nem hoztak vissza", mennyivankinnt);

Console.WriteLine("5.feladat");
Dictionary<string, int> kivittek = new Dictionary<string, int>();
Dictionary<string, int> visszahoztak = new Dictionary<string, int>();

for (int i = 0; i < autok.Count; i++)
{
    if (!kivittek.ContainsKey(autok[i].rendszam))
    {
        kivittek.Add(autok[i].rendszam, autok[i].km);
    }
    if (!visszahoztak.ContainsKey(autok[i].rendszam))
    {
        visszahoztak.Add(autok[i].rendszam, autok[i].km);
    }
    else
    {
        visszahoztak[autok[i].rendszam] = autok[i].km;
    }
}

foreach (string key in kivittek.Keys)
{
    Console.WriteLine("{0} {1} km", key, visszahoztak[key] - kivittek[key]);
}