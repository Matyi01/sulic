
string[] hosszusag = { "mm", "cm", "dm", "m", "km"};
string[] tomeg = { "g", "dkg", "kg", "t", "kt", "Mt"};
string[] urmertek = { "ml", "cl", "dl", "l", "hl"};
string[] terfogat = { "mm3", "cm3", "dm3", "m3", "km3" };

bool jo = false;

while (!jo)
{
    jo = true;
    Console.Write("Mit váltsak át? (pl.: 12 kg) ");
    string be = Console.ReadLine();

    string[] darab = be.Split(" ");
    if (darab.Length != 2)
    {
        jo = false;
        continue;
    }

    double szam = 0;
    try
    {
        szam = Convert.ToDouble(darab[0]);
    }
    catch (Exception)
    {
        Console.WriteLine("Nem jó formátum! Legyen ilyen: 12,2 kg");
        jo = false;
        continue;
    }

    Console.WriteLine(szam);

    if (hosszusag.Contains(darab[1]))
    {
    }
    else
    {
        Console.WriteLine("Nem jó mértékegység!");
        jo = false;
        continue;
    }
}

Console.WriteLine("Mire szeretnéd átváltani?");
for (int i = 0; i < hosszusag.Length; i++)
{
    Console.WriteLine(hosszusag[i]);
}
Console.Write("Válassz: ");
string valasz = Console.ReadLine();