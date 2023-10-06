
string[] hosszusag = { "mm", "cm", "dm", "m", "km"};
int[] hosszusagvalto = { 10, 10, 10, 1000, 1};
string[] terulet = { "mm2", "cm2", "dm2", "m2", "km2"};
int[] teruletvalto = { 100, 100, 100, 1000000, 1};
string[] tomeg = { "mg", "g", "dkg", "kg", "t", "kt", "Mt"};
int[] tomegvalto = { 1000, 10, 100, 1000, 1000, 1000, 1};
string[] urmertek = { "ml", "cl", "dl", "l", "hl"};
int[] urmertekvalto = { 10, 10, 10, 100, 1};
string[] terfogat = { "mm3", "cm3", "dm3", "m3", "km3"};
int[] terfogatvalto = { 1000, 1000 ,1000, 1000000000, 1};

bool jo = false;

string forrasmertekegyeg = "";
double szam = 0;

string[] egyseg = { };
int[] valto = { };

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

    szam = 0;
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

    if (hosszusag.Contains(darab[1]))
    {
        forrasmertekegyeg = darab[1];
        egyseg = hosszusag;
        valto = hosszusagvalto;
    }
    else if (terulet.Contains(darab[1]))
    {
        forrasmertekegyeg = darab[1];
        egyseg = terulet;
        valto = teruletvalto;
    }
    else if (tomeg.Contains(darab[1]))
    {
        forrasmertekegyeg = darab[1];
        egyseg = tomeg;
        valto = tomegvalto;
    }
    else if (urmertek.Contains(darab[1]))
    {
        forrasmertekegyeg = darab[1];
        egyseg = urmertek;
        valto = urmertekvalto;
    }
    else if (terfogat.Contains(darab[1]))
    {
        forrasmertekegyeg = darab[1];
        egyseg = terfogat;
        valto = terfogatvalto;
    }
    else
    {
        Console.WriteLine("Nem jó mértékegység!");
        jo = false;
        continue;
    }
}

Console.WriteLine("Mire szeretnéd átváltani?");
for (int i = 0; i < egyseg.Length; i++)
{
    Console.WriteLine(egyseg[i]);
}

string valasz = "";
while(!egyseg.Contains(valasz))
{
    Console.Write("Válassz: ");
    valasz = Console.ReadLine();
}

int index1 = Array.IndexOf(egyseg, forrasmertekegyeg);
int index2 = Array.IndexOf(egyseg, valasz);

int szorzo  = 1;
double eredmeny = 0;
if (index1 < index2)
{
    for (int i = index1; i < index2; i++)
    {
        szorzo = szorzo * valto[i];
    }
    eredmeny = szam / szorzo;
}
else
{
    for (int i = index2; i < index1; i++)
    {
        szorzo = szorzo * valto[i];
    }
    eredmeny = szam * szorzo;
}

Console.WriteLine("{0} {1} = {2} {3}", szam, forrasmertekegyeg, eredmeny, valasz);