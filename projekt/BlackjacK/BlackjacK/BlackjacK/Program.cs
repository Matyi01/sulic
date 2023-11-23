//kártyák összerakása
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
List<string> jatekos = new List<string>();
List<string> oszto = new List<string>();
int jatekosertek = 0;
int osztoertek = 0;

for (int i = 0; i < 2; i++)
{
    int tempjatekos = rand.Next(kartyak.Count);
    jatekos.Add(kartyak[tempjatekos]);
    kartyak.RemoveAt(tempjatekos);
    if (jatekos.Count > 0)
    {
        if (jatekos[i].Split(" ")[1] == "ász")
        {
            jatekosertek += 1;
        }
        else
        {
            jatekosertek += ertekek[jatekos[i]];
        }
    }
    Console.WriteLine("A játékos megkapta a {0} kártyát, össz érték: {1}", jatekos[i], jatekosertek);
    int temposzto = rand.Next(kartyak.Count);
    oszto.Add(kartyak[temposzto]);
    kartyak.RemoveAt(temposzto);
    osztoertek += ertekek[oszto[i]];
    if (i == 0)
    {
        Console.WriteLine("Az osztó megkapta a {0} kártyát, össz érték: {1}", oszto[i], osztoertek);
    }
    else
    {
        Console.WriteLine("Az osztó megkapta a második kártyáját. ");
    }
}

int osztodarab = 2;
while (true)
{
    if (osztoertek < 17)
    {
        osztodarab += 1;
        int temposzto = rand.Next(kartyak.Count);
        oszto.Add(kartyak[temposzto]);
        kartyak.RemoveAt(temposzto);
        osztoertek += ertekek[oszto[oszto.Count - 1]];
        Console.WriteLine("Az osztó megkapta a(z) {0}. kártyáját. ", osztodarab);
    }
    else if (osztoertek > 21)
    {
        Console.WriteLine("A játékos nyert. ");
        Console.WriteLine("Játékos: {0}, osztó: {1}", jatekosertek, osztoertek);
        break;
    }
    if (jatekosertek < 21)
    {
        Console.Write("Kérsz még kártyát? (igen/nem) ");
        string valasz = Console.ReadLine();
        if (valasz == "igen")
        {
            int tempjatekos = rand.Next(kartyak.Count);
            jatekos.Add(kartyak[tempjatekos]);
            kartyak.RemoveAt(tempjatekos);
            if (jatekos[jatekos.Count - 1].Split(" ")[1] == "ász")
            {
                jatekosertek += 1;
            }
            else
            {
                jatekosertek += ertekek[jatekos[jatekos.Count - 1]];
            }
            Console.WriteLine("A játékos megkapta a {0} kártyát, össz érték: {1}", jatekos[jatekos.Count - 1], jatekosertek);
        }
        else if (valasz == "nem")
        {
            if (jatekosertek > osztoertek)
            {
                Console.WriteLine("A játékos nyert. ");
                Console.WriteLine("Játékos: {0}, osztó: {1}", jatekosertek, osztoertek);
            }
            else if (jatekosertek < osztoertek)
            {
                Console.WriteLine("Az osztó nyert. ");
                Console.WriteLine("Játékos: {0}, osztó: {1}", jatekosertek, osztoertek);
            }
            else
            {
                Console.WriteLine("Döntetlen. ");
                Console.WriteLine("Játékos: {0}, osztó: {1}", jatekosertek, osztoertek);
            }
            break;
        }
        else
        {
            Console.WriteLine("Ez nem jó válsz! ");
        }
    }

    else if (osztoertek > 21)
    {
        Console.WriteLine("Az osztó nyert. ");
        Console.WriteLine("Játékos: {0}, osztó: {1}", jatekosertek, osztoertek);
        break;
    }
}
