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
    Console.Write("A legnagyobb növekvő számsorozat {0} elemű: ", maxveg - maxkezd + 1);
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
        if (szamtomb[i - 1] >= szamtomb[i])
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
    Console.Write("A legnagyobb csökkenő számsorozat {0} elemű: ", maxveg - maxkezd + 1);
    for (int i = maxkezd; i < maxveg + 1; i++)
    {
        Console.Write("{0}, ", szamtomb[i]);
    }
    Console.WriteLine();
}

int[] negyjegyuek()
{
    int[] szamok = new int[10000];
    Random rand = new Random();
    for (int i = 0; i < szamok.Length; i++)
    {
        szamok[i] = rand.Next(1000, 10000);
    }
    return szamok;
}

int[,] szakaszkeres(int[] tomb)
{
    int[,] szakaszok = new int[tomb.Length, 3];
    int szakaszokindex = 0;
    for (int i = 2; i < tomb.GetLength(0); i++)
    {
        if (tomb[i] - tomb[i - 1] >= -100 && tomb[i] - tomb[i - 1] <= 100
            && tomb[i] - tomb[i - 2] >= -100 && tomb[i] - tomb[i - 2] <= 100)
        {
            szakaszok[szakaszokindex, 0] = tomb[i - 2];
            szakaszok[szakaszokindex, 1] = tomb[i - 1];
            szakaszok[szakaszokindex++, 2] = tomb[i];
        }
    }
    return szakaszok;
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
szakasz3(szamok);
int[,] szakaszok = szakaszkeres(negyjegyuek());
for  (int i = 0; i  < szakaszok.GetLength(0); i++)
{
    for (int j = 0; j < szakaszok.GetLength(1); j++)
    {
        if (szakaszok[i, j] != 0)
        {
            Console.Write($"{szakaszok[i, j]}, ");
            if (j == 2)
            {
                Console.WriteLine();
            }
        }
    }
}