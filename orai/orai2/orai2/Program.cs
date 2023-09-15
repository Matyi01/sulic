Console.Write("Kérek egy számot: ");
int szam = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= szam; i++)
{
    Console.WriteLine(i+" * 10 = "+i*10);
}

Console.WriteLine();

for (int i = 1; i <= 5; i++)
{
    for (int n = 1; n <= 5; n++)
    {
        Console.Write(i*n+"\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.Write("Szorzótábla mérete: ");
int szam2 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= szam2; i++)
{
    for (int k = 1; k <= szam2; k++)
    {
        Console.Write(i * k + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int hany = 0;
int ossze = 0;
for (int i = 1;i <= 999; i++)
{
    ossze += i;
    if (ossze >= 999)
    {
        Console.WriteLine(hany);
        break;
    }
    hany++;
}

Console.WriteLine();

for (int i = 1; i <= 5; i++)
{
    while (true)
    {
        Console.Write("Kérek egy két jegyű számot: ");
        int beker = Convert.ToInt32(Console.ReadLine());
        if (Math.Floor(Math.Log10(beker) + 1) != 2)
        {
            Console.WriteLine("Ez nem kétjegyű szám");
        }
        else
        {
            if (beker % 12 == 0)
            {
                Console.WriteLine("Osztható 12-vel");
                break;
            }
            else
            {
                Console.WriteLine("Nem osztható 12-vel");
                break;
            }
        }
    }
}


