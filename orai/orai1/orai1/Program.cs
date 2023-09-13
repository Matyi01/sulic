using System.ComponentModel;

Console.Write("Kérek egy egész számot 0 és 999999 között: ");
int szam = Convert.ToInt32(Console.ReadLine());

if (szam >= 0 && szam <= 999999)
{
    for (int i = 1000000; i >= 0; i /= 10)
    {
        Console.WriteLine("A szám"+i+"számjegyű");
    }
}
else
{
    Console.Write("Ez a szám nem helyes, kérek egy egész számot 0 és 999999 között: ");
    szam = Convert.ToInt32(Console.ReadLine());
}


/*
while (szam >= 0 && szam <= 999999)
{
    Console.WriteLine(Math.Floor(Math.Log10(szam) + 1));
    Console.Write("Kérek egy egész számot 0 és 999999 között: ");
    szam = Convert.ToInt32(Console.ReadLine());
}
*/
