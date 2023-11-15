List<string> kartyak = new List<string>();
List<string> szinek = new List<string>() {"Treff", "Pikk", "Káró", "Kőr"};
List<string> szamok = new List<string>() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "jumbo", "dáma", "király", "ász"};
Random rand = new Random();
for (int j = 0; j < szinek.Count; j++)
{
    for (int k = 0; k < szamok.Count; k++)
    {
        kartyak.Add($"{szinek[j]} {szamok[k]}");
    }
}
for (int i = 0; i < kartyak.Count; i++)
{
    Console.WriteLine(kartyak[i]);
}


/*
string randszin = szinek[rand.Next(szinek.Count)];
string randszam = szamok[rand.Next(szamok.Count)];
*/