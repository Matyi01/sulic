using konyvek;

List<Konyv> konyvek = new List<Konyv>();

string[] sorok = File.ReadAllLines("kiadas.txt");
foreach (string sor in sorok)
{
    string[] vag = sor.Split(';');
    if (vag.Length == 5)
    {
        konyvek.Add(new Konyv(
            int.Parse(vag[0]),
            int.Parse(vag[1]),
            vag[2],
            vag[3],
            int.Parse(vag[4])
        ));
    }
}

Console.WriteLine("2. feladat:");
Console.Write("Szerző: ");
string be = Console.ReadLine();
int db = 0;
foreach (Konyv e in konyvek)
{
    if (e.leiras.Contains(be))
    {
        db++;
    }
}
if (db == 0)
{
    Console.WriteLine("Nem adtak ki");
}
else
{
    Console.WriteLine($"{db} könyvkiadás");
}

Dictionary<int, int> peldanySzam = new Dictionary<int, int>();
foreach (Konyv e in konyvek)
{
    if (peldanySzam.Keys.Contains(e.db))
    {
        peldanySzam[e.db]++;
    }
    else
    {
        peldanySzam[e.db] = 1;
    }
}
Console.WriteLine("3. feladat:");
Console.WriteLine("Legnagyobb példányszám: {0}, előfordult {1} alkalommal", peldanySzam.Keys.Max(), peldanySzam[peldanySzam.Keys.Max()]);

Console.WriteLine("4. feladat:");
foreach (Konyv e in konyvek)
{
    if (e.eredet == "kf" && e.db >= 40000)
    {
        Console.WriteLine("{0}/{1}. {2}", e.ev, e.negyedEv, e.leiras);
        break;
    }
}

Dictionary<int, int[]> stat = new Dictionary<int, int[]>();
foreach (Konyv e in konyvek)
{
    if (e.eredet == "ma")
    {
        if (stat.Keys.Contains(e.ev))
        {
            stat[e.ev][0]++;
            stat[e.ev][1] += e.db;
        }
        else
        {
            stat[e.ev] = [1, e.db, 0, 0];
        }
    }
    else
    {
        if (stat.Keys.Contains(e.ev))
        {
            stat[e.ev][2]++;
            stat[e.ev][3] += e.db;
        }
        else
        {
            stat[e.ev] = [0, 0, 1, e.db];
        }
    }
}

Console.WriteLine("5. feladat:");
Console.WriteLine("Év\tMagyar kiadás\tMagyar példányszám\tKülföldi kiadás\tKülföldi példányszám");
foreach (var e in stat)
{
    Console.WriteLine(e.Key+"\t"+e.Value[0]+ "\t\t" + e.Value[1] + "\t\t\t" + e.Value[2] + "\t\t" + e.Value[3]);
}

StreamWriter ir = new StreamWriter("tabla.html");
ir.WriteLine("<table>");
ir.WriteLine("<tr><th>Év</th><th>Magyar kiadás</th><th>Magyar példányszám</th><th>Külföldi\r\nkiadás</th><th>Külföldi példányszám</th></tr>");
foreach (var e in stat)
{
    ir.WriteLine($"<tr><td>{e.Key}</td><td>{e.Value[0]}</td><td>{e.Value[1]}</td><td>{e.Value[2]}</td><td>{e.Value[3]}</td></tr>");
}
ir.WriteLine("</table>");
ir.Close();

List<string> kiirando = new List<string>();
foreach (Konyv e in konyvek)
{
    db = 0;
    foreach (Konyv f in konyvek)
    {
        if (e.ev == f.ev)
        {
            if (e.leiras == f.leiras && e.db > f.db && e.negyedEv < f.negyedEv)
            {
                db++;
            }
        }
        else if (e.ev < f.ev)
        {
            if (e.leiras == f.leiras && e.db > f.db)
            {
                db++;
            }
        }
    }
    if (db > 1 && !kiirando.Contains(e.leiras))
    {
        kiirando.Add(e.leiras);
    }
}

Console.WriteLine("6. feladat:");
Console.WriteLine("Legalább kétszer, nagyobb példányszámban újra kiadott könyvek:");
foreach (string e in kiirando)
{
    Console.WriteLine(e);
}
