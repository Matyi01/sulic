static double atlag(List<int> e)
{
    return e.Sum() / e.Count;
}
static int legjobb(List<int> e)
{
    return e.Max();
}
static int legrosszabb(List<int> e)
{
    return e.Min();
}
static int osztalyzat(int e)
{
    if (e < 40)
    {
        return 1;
    }
    else if (e < 55)
    {
        return 2;
    }
    else if (e < 70)
    {
        return 3;
    }
    else if (e < 85)
    {
        return 4;
    }
    else
    {
        return 5;
    }
}

string[] txt = File.ReadAllLines("atvaltoztatastan.txt");

List<int> eredmenyek = new List<int>();
foreach (string line in txt)
{
    eredmenyek.Add(int.Parse(line));
}

Console.WriteLine(atlag(eredmenyek));
Console.WriteLine(legjobb(eredmenyek));
Console.WriteLine(legrosszabb(eredmenyek));

List<int> osztalyzatok = new List<int>();
foreach (int e in eredmenyek)
{
    osztalyzatok.Add(osztalyzat(e));
}

Dictionary<int, int> db = new Dictionary<int, int>();
foreach (int e in osztalyzatok)
{
    if (db.ContainsKey(e))
    {
        db[e]++;
    }
    else
    {
        db.Add(e, 1);
    }
}
foreach (KeyValuePair<int, int> e in db)
{
    Console.WriteLine(e.Key + ": " + e.Value);
}