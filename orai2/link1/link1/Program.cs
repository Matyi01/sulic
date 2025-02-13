using link1;

string[] text = File.ReadAllLines("felajanlas.txt");

List<Adatok> viragok = new List<Adatok>();

/*
foreach (string line in text.Skip(1))
{
    viragok.Add(new Adatok(line));
}
int agyasdb = int.Parse(text[0]);
*/

viragok = text.Skip(1).Select(sor => new Adatok(sor)).ToList();

for (int i = 0; i < viragok.Count; i++)
{
    viragok[i].sorszam = i + 1;
}

Console.WriteLine("2.: A felajánlások száma: {0}", viragok.Count);

/*
List<int> kapudb = new List<int>();
foreach (Adatok e in viragok)
{
    if (e.kapubentvan) {  kapudb.Add(e.sorszam); }
}
Console.WriteLine("3.: A bejárat mindkét oldalán ültetők: {0}", string.Join(" ", kapudb));
*/
Console.WriteLine("3.: A bejárat mindkét oldalán ültetők: {0}", string.Join(" ", viragok.Where(e => e.kapubentvan).Select(e => e.sorszam)));


Console.Write("Ágyás száma: ");
int be = int.Parse(Console.ReadLine());
int db = 0;
string szin = "";
HashSet<string> szinek = new HashSet<string>();
foreach (Adatok e in viragok)
{
    if (e.bennevanez(be))
    {
        db++;
        if (szin == "")
        {
            szin = e.szin;
        }
        szinek.Add(e.szin);
    }
}
Console.WriteLine(db);
if  (db == 0)
{
    Console.WriteLine("Ezt az ágyást nem ültetik be.");
}
else
{
    Console.WriteLine("Ha csak az első ültet: {0}", szin);
    Console.WriteLine("Ha az összes: {0}", string.Join(" ", szinek));
}

List<Adatok> szurt = viragok.Where(e => e.bennevanez(be)).ToList();
Console.WriteLine(szurt.Count);
Console.WriteLine(szurt.Select(e => e.szin).First());
Console.WriteLine(string.Join(" ", szurt.Select(e => e.szin).Distinct()));


List<Adatok>[] agyasok = new List<Adatok>[db + 1];
for (int i = 1; i < db + 1; i++)
{
    foreach (Adatok e in viragok)
    {
        if (e.bennevanez(i))
        {
            agyasok[i].Add(e);
        }
    }
}