static int szambeker(int min, int max)
{
    if (min > max)
    {
        throw new ArgumentException("min nem lehet nagyobb mint max!");
    }
    int szam = 0;
    while(szam <= min || szam >= max)
    {
        try
        {
            Console.Write("Kérek egy egész számot {0} és {1} között: ", min, max);
            szam = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ez nem szám!");
        }
    }
    return szam;
}
static string szogen(int hossz)
{
    string szo = "";
    Random random = new Random();
    /*
    string[] mgh = ["a", "á", "e", "é", "i", "í", "o", "ó", "ö", "ő", "u", "ú", "ü", "ű"];
    string[] msh = ["b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v", "z", "cs", "dz", "gy", "ly", "ny", "sz", "ty", "zs", "dzs"];
    for (int i = 0; i < hossz; i++)
    {
        if (i % 2 == 0)
        {
            szo += mgh[random.Next(0, mgh.Length)];
        }
        else
        {
            szo += msh[random.Next(0, msh.Length)];
        }
    }
    */
    string[] betuk = ["aáeéiíoóöőuúüű", "bcdfghjklmnprstvzcsdzgylynysztyzsdzs"];
    int melyik = random.Next(2);
    for (int i = 0; i < hossz; i++)
    {
        szo += betuk[melyik][random.Next(betuk[melyik].Length)];
        melyik = 1 - melyik;
    }
    return szo;
}
static List<string> sokszo()
{
    int szam = szambeker(3, 110);
    int db = 0;
    while (db == 0)
    {
        try
        {
            Console.Write("Hány szó legyen? ");
            db = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ez nem szám!");
        }
    }
    List<string> szavak = new List<string>();
    for (int i = 0; i < db; i++)
    {
        szavak.Add(szogen(szam));
    }
    return szavak;
}
static void fajlbair(List<string> szavak)
{
    StreamWriter ir = new StreamWriter("szavak.txt");
    for (int i = 0;i < szavak.Count; i++)
    {
        ir.WriteLine(szavak[i]);
    }
    ir.Close();
}
static List<string> mondatgen(List<string> szavak){
    Random random = new Random();
    List<string> mondatok = new List<string>();
    for(int i = 0; i < 100; i++)
    {
        int k = random.Next(3, 11);
        string mondat = "s";
        for (int j = 0; j < k; j++)
        {
            mondat += szavak[random.Next(szavak.Count)];
        }
        mondatok.Add(mondat);
    }
    return mondatok;
}


List<string> szavak = sokszo();
fajlbair(szavak);



