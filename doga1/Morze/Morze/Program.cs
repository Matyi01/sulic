using Morze;

static string Morze2Szoveg(string kod, List<Betu> abc)
{
    string vissza = "";
    string[] vag = kod.Split("/");
    foreach (string adat in vag)
    {
        foreach (Betu e in abc)
        {
            if (adat == e.morzeKarakter)
            {
                vissza += e.karakter;
            }
            if (adat == " ")
            {
                vissza += " ";
                break;
            }
        }
    }
    return vissza;
}

List<Betu> abc = new List<Betu>();
string[] sorok = File.ReadAllLines("morzeabc.txt");
foreach (string sor in sorok.Skip(1))
{
    abc.Add(new Betu(sor));
}
Console.WriteLine("3. feladat: A morze abc {0} db karakter kódját tartalmazza.", abc.Count);

Console.Write("4. feladat: Kérek egy karaktert: ");
string be = Console.ReadLine();
string ki = "";
foreach (Betu e in abc)
{
    if (be == e.karakter)
    {
        ki = e.morzeKarakter;
        break;
    }
}
if (ki != "")
{
    Console.WriteLine("A {0} karakter morze kódja: {1}", be, ki);
}
else
{
    Console.WriteLine("Nem található a kódtárban ilyen karakter!");
}

List<Idezet> idezetek = new List<Idezet>();
string[] sorok2 = File.ReadAllLines("morze.txt");
foreach (string sor in sorok2)
{
    string sor2 = String.Join("/", sor.Replace("       ", "/ /").Replace("   ;", "   ;   ").Split("   "));
    idezetek.Add(new Idezet(sor2));
}

Console.WriteLine("7. feladat: Az első idézuet szerzője: {0}", Morze2Szoveg(idezetek[0].szerzo, abc));

Idezet leghosszabb = idezetek[0];
foreach (Idezet e in idezetek)
{
    if (Morze2Szoveg(e.szoveg, abc).Length > Morze2Szoveg(leghosszabb.szoveg, abc).Length)
    {
        leghosszabb = e;
    }
}
Console.WriteLine("8. feladat: Az leghosszabb idézet szerzője és az idézet: {0}: {1}", Morze2Szoveg(leghosszabb.szerzo, abc), Morze2Szoveg(leghosszabb.szoveg, abc));

Console.WriteLine("9.feladat: Arisztotelész idézetei:");
foreach (Idezet e in idezetek)
{
    if (e.szerzo == ".-/.-./../.../--../-/---/-/./.-../..-../.../--../")
    {
        Console.WriteLine("- " + Morze2Szoveg(e.szoveg, abc));
    }
}

