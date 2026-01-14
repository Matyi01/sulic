/*
4 7_
3 1/6 1/1,
2 1/6 2/
1 1/6_2/
1(6_1(1/

==
    _______
   /      /,
  /      //
 /______//
(______(/
 */
static string atalakit(string sor)
{
    string vissza = "";
    for (int i = 0; i < sor.Length - 1; i += 2)
    {
        vissza += new string(sor[i + 1], int.Parse(sor[i].ToString()));
    }
    return vissza;
}


Console.WriteLine("1. feladat");

List<string> konyv = new List<string>(File.ReadLines("konyv.txt"));

foreach (string sor in konyv)
{
    Console.WriteLine(sor);
}


Console.WriteLine("2. feladat");

Console.Write("Kérem adja meg az ismétlések számát: ");
int n = int.Parse(Console.ReadLine()!);

string elvalaszto = " | ";

foreach (string sor in konyv)
{
    string temp = sor;
    for (int i = 0; i < n; i++)
    {
        while (temp.Length < 12)
        {
            temp += " ";
        }
        Console.Write(temp + elvalaszto);
    }
    Console.WriteLine();
}


Console.WriteLine("4. feladat");

List<string> szg_t = new List<string>(File.ReadLines("szg_t.txt"));

foreach (string sor in szg_t)
{
    Console.WriteLine(atalakit(sor));
}

File.WriteAllLines("szg.txt", szg_t.Select(sor => atalakit(sor)));

