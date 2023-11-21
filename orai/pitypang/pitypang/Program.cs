StreamReader olvas  = new StreamReader("pitypang.txt");
olvas.ReadLine();
List<int> sorszam = new List<int>();
List<int> szobaszam = new List<int>();
List<int> erkezes = new List<int>();
List<int> tavozas = new List<int>();
List<int> vendegszam = new List<int>();
List<bool> reggeli = new List<bool>();
List<string> vendeg = new List<string>();
while (olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    //1 5 3 13 1 1 Huszar_Hajnalka
    string[] vag = sor.Split(" ");
    sorszam.Add(Convert.ToInt32(vag[0]));
    szobaszam.Add(Convert.ToInt32(vag[1]));
    erkezes.Add(Convert.ToInt32(vag[2]));
    tavozas.Add(Convert.ToInt32(vag[3]));
    vendegszam.Add(Convert.ToInt32(vag[4]));
    reggeli.Add(vag[5] == "1");
    vendeg.Add(vag[6]);
}
olvas.Close();

//2. feladat
int maxej = 0;
int maxid = 0;
for  (int i = 0; i < sorszam.Count; i++)
{
    int hossz = tavozas[i] - erkezes[i];
    if (hossz > maxej)
    {
        maxej = hossz;
        maxid = i;
    }
}

Console.WriteLine("{0} ({1}) - {2}", vendeg[maxid], erkezes[maxid], maxej);