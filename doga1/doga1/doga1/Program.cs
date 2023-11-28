static string[,] beolvasas()
{
    string[,] sorok = new string[File.ReadLines("adathalmaz.csv").Count() - 1, 6];
    StreamReader olvas = new StreamReader("adathalmaz.csv");
    olvas.ReadLine();
    for (int i = 0; i < sorok.GetLength(0); i++)
    {
        string[] temp = new string[6];
        temp = olvas.ReadLine().Split(";");
        for (int j = 0; j < temp.Length; j++)
        {
            sorok[i, j] = temp[j];
        }
    }
    olvas.Close();
    return sorok;
}

static void hanyidopont(string[,] sorok)
{
    Console.WriteLine("2. feladat");
    Console.WriteLine("{0} időpont adata szerepel. ", sorok.GetLength(0));
}

static void darabperoraatlag(string[,] sorok)
{
    List<int> darab = new List<int>();
    for (int i = 11; i < 288; i += 12)
    {
        if (i > 11)
        {
            darab.Add(Convert.ToInt32(sorok[i, 5]) - Convert.ToInt32(sorok[i - 12, 5]));
        }
        else
        {
            darab.Add(Convert.ToInt32(sorok[i, 5]));
        }
    }
    Console.WriteLine("3. feladat");
    Console.WriteLine("Átlagosan {0} darab készül óránként. ", darab.Average());
}

static void minhomerseklet(string[,] sorok)
{
    List<double> temp1 = new List<double>();
    List<double> temp2 = new List<double>(); 
    List<double> temp3 = new List<double>();
    List<double> temp4 = new List<double>();
    for (int i = 0; i < sorok.GetLength(0); i++)
    {
        temp1.Add(Convert.ToDouble(sorok[i, 1]));
        temp2.Add(Convert.ToDouble(sorok[i, 2]));
        temp3.Add(Convert.ToDouble(sorok[i, 3]));
        temp4.Add(Convert.ToDouble(sorok[i, 4]));
    }
    Console.WriteLine("4. feladat");
    Console.WriteLine("Az 1. hőmérő által mért legkisebb hőmérséklet: {0}", temp1.Min());
    Console.WriteLine("A 2. hőmérő által mért legkisebb hőmérséklet: {0}", temp2.Min());
    Console.WriteLine("A 3. hőmérő által mért legkisebb hőmérséklet: {0}", temp3.Min());
    Console.WriteLine("A 4. hőmérő által mért legkisebb hőmérséklet: {0}", temp4.Min());
}

static void elsofazismax(string[,] sorok)
{
    List <double> temp1 = new List<double>();
    for (int i = 0; i < sorok.GetLength(0); i++)
    {
        temp1.Add(Convert.ToDouble(sorok[i, 1]));
    }
    double temp1max = temp1.Max();
    int temp1maxindex = 0;
    for (int i = 0; i < sorok.GetLength(0); i++)
    {
        if (temp1max == Convert.ToDouble(sorok[i, 1]))
        {
            temp1maxindex = i;
        }
    }
    Console.WriteLine("5. feladat");
    Console.WriteLine("Az egyes fázison a legnagyobb hőmérséklet {0} volt {1} percnél. ", temp1max, sorok[temp1maxindex, 0]);
}

static void maxtermeles(string[,] sorok)
{
    List<int> darab = new List<int>();
    for (int i = 0; i < sorok.GetLength(0); i++)
    {
        if (i > 0)
        {
            darab.Add(Convert.ToInt32(sorok[i, 5]) - Convert.ToInt32(sorok[i - 1, 5]));
        }
        else
        {
            darab.Add(Convert.ToInt32(sorok[i, 5]));
        }
    }
    int darabmax = darab.Max();
    int darabmaxindex = 0;
    for (int i = 0; i < darab.Count(); i++)
    {
        if (darabmax == darab[i])
        {
            darabmaxindex = i;
        }
    }
    int perc = Convert.ToInt32(sorok[darabmaxindex, 0]);
    string ido = perc / 60 + ":" + perc % 60;
    Console.WriteLine("6. feladat.");
    Console.WriteLine("{0}-kor volt a legnagyobb a termelés: {1}", ido, darabmax);
}

static void hanyfok(string[,] sorok)
{
    List<double> temp1 = new List<double>();
    List<double> temp2 = new List<double>();
    List<double> temp3 = new List<double>();
    List<double> temp4 = new List<double>();
    for (int i = 0; i < sorok.GetLength(0); i++)
    {
        temp1.Add(Convert.ToDouble(sorok[i, 1]));
        temp2.Add(Convert.ToDouble(sorok[i, 2]));
        temp3.Add(Convert.ToDouble(sorok[i, 3]));
        temp4.Add(Convert.ToDouble(sorok[i, 4]));
    }
    Console.WriteLine("7. feladat");
    Console.WriteLine("Az 1. hőmérő átlag hőmérséklete: {0}", temp1.Average());
    Console.WriteLine("A 2. hőmérő átlag hőmérséklete: {0}", temp2.Average());
    Console.WriteLine("A 3. hőmérő átlag hőmérséklete: {0}", temp3.Average());
    Console.WriteLine("A 4. hőmérő átlag hőmérséklete: {0}", temp4.Average());
}

static void darabperora(string[,] sorok)
{
    List<int> darab = new List<int>();
    for (int i = 11; i < 288; i += 12)
    {
        if (i > 11)
        {
            darab.Add(Convert.ToInt32(sorok[i, 5]) - Convert.ToInt32(sorok[i - 12, 5]));
        }
        else
        {
            darab.Add(Convert.ToInt32(sorok[i, 5]));
        }
    }

    StreamWriter ir = new StreamWriter("termeles.csv");
    for (int i = 0; i < darab.Count(); i++)
    {
        ir.WriteLine("A(z) {0}. órában {1} termék volt kész. ", i + 1, darab[i]);
    }
    ir.Close();
}

string[,] sorok = beolvasas();

hanyidopont(sorok);

darabperoraatlag(sorok);

minhomerseklet(sorok);

elsofazismax(sorok);

maxtermeles(sorok);

hanyfok(sorok);

darabperora(sorok);

