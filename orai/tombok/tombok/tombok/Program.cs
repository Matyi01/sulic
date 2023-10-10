void kiir(int[] tomb)
{
    foreach (int i in tomb)
    {
        Console.WriteLine("{0}. szam", i);
    }
}

int[] szamok = new int[100];

for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = i+1;
}

Console.WriteLine(szamok);
foreach (int i in szamok)
{
    Console.WriteLine("{0}. szam",i);
}
Console.WriteLine();

for (int i = 0;i < szamok.Length; i++)
{
    szamok[i] = szamok[i] * 2;
}

kiir(szamok);
