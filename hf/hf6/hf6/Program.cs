static string szogeneralas(int hanybetus)
{
    string betuk = "qwertzuiopőúasdfghjkléáűíyxcvbnmöüó-";

    string szo = "";
    var rand = new Random();
    for (int i = 0; i < hanybetus; i++)
    {
        szo += betuk[rand.Next(betuk.Length)];
    }

    return szo;
}

var rand = new Random();
string[] szavak = new string[10000];
for (int i = 0; i < 10000; i++)
{
    szavak[i] = szogeneralas(rand.Next(4, 7));
}

File.WriteAllLines("szavak.txt", szavak);

string[] szavak2 = File.ReadAllLines("szavak.txt");

string ugyanazok = "";
for (int i = 0; i < szavak2.Length; i++)
{
    for (int j = 0; j < szavak2.Length; j++)
    {
        if (szavak2[i] == szavak2[j] && i < j)
        {
            ugyanazok += szavak2[i] + " ";
        }
    }
}
string[] ugyanazok2 = ugyanazok.Trim().Split(" ");
foreach (string s in ugyanazok2)
{
    Console.WriteLine(s);
}

for (int i = 0;i < szavak2.Length; i++)
{
    if (szavak2[i].Length == 4)
    {
        szavak2[i] = szavak2[i].Substring(0, 1).ToUpper() + szavak2[i].Substring(1);
    }
}

for (int i = 0; i < szavak2.Length; i++)
{
    for (int j = 0;j < szavak2.Length; j++)
    {
        if (szavak2[i].Length == 4 && szavak2[j].Length == 6 && szavak2[j].IndexOf(szavak2[i]) != -1)
        {
            Console.WriteLine($"{szavak2[j]} eleme {szavak2[i]}");
        }
    }
}

for (int i = 0; i < szavak2.Length; i++)
{
    if (szavak2[i].Length == 5)
    {
        szavak2[i] = szavak2[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
    }
}


string negy = "";
string ot = "";
string hat = "";
for (int i = 0;i < szavak2.Length; i++)
{
    if (szavak2[i].Length == 4)
    {
        negy += szavak2[i] + " ";
    }
    if (szavak2[i].Length == 5)
    {
        ot += szavak2[i] + " ";
    }
    if (szavak2[i].Length == 6)
    {
        hat += szavak2[i] + " ";
    }
}
string[] negy2 = negy.Trim().Split(" ");
string[] ot2 = ot.Trim().Split(" ");
string[] hat2 = hat.Trim().Split(" ");
Array.Sort(negy2);
Array.Sort(ot2);
Array.Sort(hat2);
File.WriteAllLines("negy.txt", negy2);
File.WriteAllLines("ot.txt", ot2);
File.WriteAllLines("hat.txt", hat2);