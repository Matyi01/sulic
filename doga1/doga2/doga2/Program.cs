static int paros(List<int> szamok)
{
    int parosdb = 0;
    for (int i = 0; i < szamok.Count; i++)
    {
        if (szamok[i] % 2 == 0)
        {
            parosdb++;
        }
    }
    return parosdb;
}

static int paratlan(List<int> szamok)
{
    int paratlanosszeg = 0;
    for (int i = 0;i < szamok.Count; i++)
    {
        if (szamok[i] % 2 == 1)
        {
            paratlanosszeg += szamok[i];
        }
    }
    return paratlanosszeg;
}

Random rand = new Random();
List<int> szamok = new List<int>();
for (int i = 0; i < 500; i++)
{
    szamok.Add(rand.Next(10000, 100000));
}
StreamWriter ir = new StreamWriter("szamok.csv");
for (int i = 0; i < szamok.Count; i++)
{
    ir.WriteLine(szamok[i]);
}
ir.Close();


Console.WriteLine(paros(szamok)+" db páros szám van.");

Console.WriteLine(paratlan(szamok)+" a páratlan számok összege.");

int elsofel = 0;
int masodikfel = 0;
for (int i = 0; i < 250; i++)
{
    elsofel += szamok[i];
}
for (int i = 250; i < 500; i++)
{
    masodikfel += szamok[i];
}

if (elsofel > masodikfel)
{
    Console.WriteLine("Az első fele nagyobb a listának.");
}
else if (elsofel < masodikfel)
{
    Console.WriteLine("Az második fele nagyobb a listának.");
}
else
{
    Console.WriteLine("A két fele egyenlő a listának.");
}

int haromakezdo1 = 0;
for (int i = 0; i < szamok.Count; i++)
{
    if (Convert.ToString(szamok[i])[0] == '3')
    {
        haromakezdo1++;
    }
}
Console.WriteLine(haromakezdo1+" db 3xxxx szerű szám van.");

/*
int[,] szamok2 = new int[10, szamok.Count];
int[] indexek = new int[10];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < szamok.Count; j++)
    {
        if (Convert.ToString(szamok[j])[0] == Convert.ToChar(Convert.ToString(i)));
        {
            szamok2[i, indexek[i]] = szamok[j];
            indexek[i]++;
        }
    }
}

for  (int i = 0;i < szamok2.GetLength(0); i++)
{
    for (int j = 0; j < szamok2.GetLength(1); j++)
    {
        Console.WriteLine(szamok2[i, j]);
    }
}
*/

List<int>[] szamok3 = new List<int>[10];
for(int i = 0; i < 10; i++)
{
    szamok3[i] = new List<int>();
}

for (int i = 1; i < 10; i++)
{
    for (int j = 0; j < szamok.Count; j++)
    {
        if (Convert.ToString(szamok[j])[0] == Convert.ToChar(Convert.ToString(i)))
        {
            szamok3[i].Add(szamok[j]);
        }
    }
}

for  (int i = 1;i < 10; i++)
{
    Console.WriteLine(szamok3[i].Count);


}