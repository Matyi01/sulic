static string szo1(int darab)
{
    Random rand = new Random();
    string betuk = "qwertzuiopasdfghjklyxcvbnm";
    string szo = "";
    for (int i = 0; i < darab; i++)
    {
        int index = rand.Next(betuk.Length);
        szo += betuk[index];
    }
    return szo;
}

static string szo2(int darab)
{
    Random rand = new Random();
    string mgh = "aeiou";
    string msh = "qwrtzpsdfghjklyxcvbnm";
    string szo = "";
    int betufajta = rand.Next(1);
    for (int i = 0; i < darab; i++)
    {
        if (betufajta == 0)
        {
            szo += mgh[rand.Next(mgh.Length)];
        }
        else
        {
            szo += msh[rand.Next(msh.Length)];
        }
        betufajta = 1 - betufajta;
    }

    return szo;
}

static string szo(int darab)
{
    Random rand = new Random();
    string mgh = "aeiou";
    string msh = "qwrtzpsdfghjklyxcvbnm";
    string szo = "";
    int betufajta = rand.Next(1);
    for (int i = 0; i < darab; i++)
    {
        if (betufajta == 0)
        {
            szo += mgh[rand.Next(mgh.Length)];
        }
        else
        {
            int k = rand.Next(2);
            for (int j = 0; j < k + 1 && i + j < darab; j++)
            {
                szo += msh[rand.Next(msh.Length)];
            }
            i += k;
        }
        betufajta = 1 - betufajta;
    }

    return szo;
}

string[] sokszo = new string[10000];
Random rand = new Random();
for (int i = 0; i < sokszo.Length; i++)
{
    sokszo[i] = szo(rand.Next(2, 11));
}

File.WriteAllLines("szavak.txt", sokszo);

string[] szavak = File.ReadAllLines("szavak.txt");

string tobbszoros = "";
for (int i = 0; i < szavak.Length; i++)
{
    for (int j = i + 1 ; j < szavak.Length; j++)
    {
        if (szavak[i] == szavak[j])
        {
            tobbszoros += ";" + szavak[j];
            break;
        }
    }
}
if (tobbszoros != "")
{
    Console.WriteLine("Többször előforduló szavak: " + tobbszoros.Substring(1));
}

for  (int i = 0;i < szavak.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        szavak[i] = szavak[i].Substring(0, 1).ToUpper() + szavak[i].Substring(1);
    }
}

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        for (int j = 0 ;j < szavak.Length; j++)
        {
            if (szavak[j].Length == 6)
            {
                if (szavak[j].IndexOf(szavak[i].ToLower()) > -1)
                {
                    Console.WriteLine("{0} benne van ebben: {1}", szavak[i], szavak[j]);
                }
            }
        }
    }
}

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 5)
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
    }
}

string[] valogat =  new string[11];
for (int i = 0;i < szavak.Length; i++)
{
    valogat[szavak[i].Length] += szavak[i] + ";"; 
}

for (int i = 2; i < 11; i++)
{
    string[] darabolt = valogat[i].Substring(0, valogat[i].Length - 1).Split(";");
    Array.Sort(darabolt);
    File.WriteAllLines(i+"betus.txt", darabolt);
}
