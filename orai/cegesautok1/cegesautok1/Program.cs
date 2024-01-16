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