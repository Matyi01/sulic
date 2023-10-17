int[] tombkeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();
    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb, legnagyobb+1);
    }
    return tomb;
}

void szakasz2(int[] szamtomb)
{
    int kezd = 0;
    int veg = 0;
    int maxkezd = 0;
    int maxveg = 0;

    for (int i = 1; i < szamtomb.Length; i++)
    {
        if (szamtomb[i - 1] < szamtomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > maxveg - maxkezd + 1)
            {
                maxveg = veg;
                maxkezd = kezd;
            }
            kezd = i;
        }
    }
    Console.Write("A legnagyobb számsorozat {0} elemű: ", maxveg - maxkezd + 1);
    for (int i = maxkezd; i < maxveg + 1; i++)
    {
        Console.Write("{0}, ",szamtomb[i]);
    }
    Console.WriteLine();
}

void szakasz3(int[] szamtomb)
{
    int kezd = 0;
    int veg = 0;
    int maxkezd = 0;
    int maxveg = 0;

    for (int i = 1; i < szamtomb.Length; i++)
    {
        if (szamtomb[i - 1] < szamtomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > maxveg - maxkezd + 1)
            {
                maxveg = veg;
                maxkezd = kezd;
            }
            kezd = i;
        }
    }
    Console.Write("A legnagyobb számsorozat {0} elemű: ", maxveg - maxkezd + 1);
    for (int i = maxkezd; i < maxveg + 1; i++)
    {
        Console.Write("{0}, ", szamtomb[i]);
    }
    Console.WriteLine();
}



int[] szamok = tombkeszit(1000, 100, 999);
int paros = 0;
int paratlan  = 0;
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] % 2 == 0)
    {
        paros++;
    }
    else
    {
        paratlan++;
    }
}
Console.WriteLine($"{paros} páros szám van és {paratlan} páratlan. ");

bool vanegyenlopar = false;
for (int i = 1; i < szamok.Length; i++)
{
    if (szamok[i] == szamok[i - 1])
    {
        vanegyenlopar = true;
        Console.WriteLine("Egyenlő: {0} és {1}, {2} = {3}", i - 1, i, szamok[i-1], szamok[i]);
    }
}
if (vanegyenlopar)
{
    Console.WriteLine("Van egyenlő szomszédos elem. ");
}
else
{
    Console.WriteLine("Nincs egyenlő szomszédos elem. ");
}


szakasz2(szamok);