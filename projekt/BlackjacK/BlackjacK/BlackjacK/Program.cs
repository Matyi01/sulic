//kártyák ósszerakása
List<string> kartyak = new List<string>();
List<string> szinek = new List<string>() { "Treff", "Pikk", "Káró", "Kőr" };
List<string> szamok = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jumbo", "dáma", "király", "ász" };
Random rand = new Random();
for (int j = 0; j < szinek.Count; j++)
{
    for (int k = 0; k < szamok.Count; k++)
    {
        kartyak.Add($"{szinek[j]} {szamok[k]}");
    }
}

//értékadás a kártyáknak
Dictionary<string, int> ertekek = new Dictionary<string, int>();

for (int i = 0; i < kartyak.Count; i++)
{
    if (kartyak[i].IndexOf("jumbo") != -1 || kartyak[i].IndexOf("dáma") != -1 || kartyak[i].IndexOf("király") != -1)
    {
        ertekek.Add(kartyak[i], 10);
    }
    else if (kartyak[i].IndexOf("ász") != -1)
    {
        ertekek.Add(kartyak[i], 11);
    }
    else
    {
        ertekek.Add(kartyak[i], Convert.ToInt32(kartyak[i].Split(" ")[1]));
    }
}

//pakli keverés
for (int k = 0; k < 100; k++)
{
    for (int i = 0; i < ertekek.Count; i++)
    {
        int temprand = rand.Next(0, ertekek.Count);
        string temp = kartyak[i];
        kartyak[i] = kartyak[temprand];
        kartyak[temprand] = temp;
    }
}


//kártyaosztás