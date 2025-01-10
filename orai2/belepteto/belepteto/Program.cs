using belepteto;

string[] sorok = File.ReadAllLines("bedat.txt");
List<adatok> esemenyek = new List<adatok>();
foreach (string sor in sorok)
{
    esemenyek.Add(new adatok(sor));
}

Console.WriteLine(esemenyek[0].ido);
Console.WriteLine(esemenyek[esemenyek.Count - 1].ido);

StreamWriter ir = new StreamWriter("kesok.txt");
foreach (adatok e in esemenyek)
{
    if ((e.ora == 7 && e.perc >= 50) || (e.ora == 8 && e.perc <= 15) && e.esemeny == 1){
        ir.WriteLine(e.ido+" "+e.kod);
    }
}
ir.Close();

int db = 0;
foreach (adatok e in esemenyek)
{
    if (e.esemeny == 3)
    {
        db++;
    }
}
Console.WriteLine(db);

HashSet<string> db2 = new HashSet<string>();
foreach (adatok e in esemenyek)
{
    if (e.esemeny == 4)
    {
        db2.Add(e.kod);
    }
}
Console.WriteLine(db2.Count);