List<int> szamok = new List<int>();
Random rand = new Random();
int darab = rand.Next(10000, 100000);
for (int i = 0; i < darab; i++)
{
    szamok.Add(rand.Next(10,100));
}

Console.WriteLine($"{szamok.Count()} darab szám van");

Dictionary<int, int> darabszam = new Dictionary<int, int>();
for (int i = 0;i < darab; i++)
{
    if (darabszam.ContainsKey(i))
    {
        darabszam[i]++;
    }
    else
    {
        darabszam.Add(i, 0);
    }
}
foreach (KeyValuePair<int, int> kvp in darabszam)
{
    Console.WriteLine(kvp.Key, kvp.Value);
}