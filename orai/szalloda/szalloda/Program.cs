static int fizetendo(int erkezes, int tavozas, int szemely, bool etkezes)
{
    int szobaar = 0;
    if (erkezes < 121) szobaar = 9000;
    else if (erkezes < 244) szobaar = 10000;
    else szobaar = 8000;

    int ejdb = tavozas - erkezes;
    if (szemely > 2) szobaar += 2000;
    if (etkezes) szobaar += szemely * 1100;
    return szobaar * ejdb;
}



StreamReader olvas = new StreamReader("pitypang.txt");
olvas.ReadLine();
List<int> sorszam = new List<int>();
List<int> szobaszam = new List<int>();
List<int> erkezes = new List<int>();
List<int> tavozas = new List<int>();
List<int> vendegszam = new List<int>();
List<bool> etkezes = new List<bool>();
List<string> vendeg = new List<string>();
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    //1 5 3 13 1 1 Huszar_Hajnalka
    string[] vag = sor.Split(" ");
    sorszam.Add(Convert.ToInt32(vag[0]));
    szobaszam.Add(Convert.ToInt32(vag[1]));
    erkezes.Add(Convert.ToInt32(vag[2]));
    tavozas.Add(Convert.ToInt32(vag[3]));
    vendegszam.Add(Convert.ToInt32(vag[4]));
    etkezes.Add(vag[5] == "1");
    vendeg.Add(vag[6]);
}
olvas.Close();

//2. feladat
int maxej = 0;
int maxid = 0;
for (int i = 0; i < sorszam.Count; i++)
{
    int hossz = tavozas[i] - erkezes[i];
    if (hossz > maxej)
    {
        maxej = hossz;
        maxid = i;
    }

}

Console.WriteLine("{0} ({1}) - {2}", vendeg[maxid], erkezes[maxid], maxej);

StreamWriter ir = new StreamWriter("bevetel.txt");
for  (int i = 0; i < sorszam.Count; i++)
{
    ir.WriteLine("{0}:{1}", sorszam[i], fizetendo(erkezes[i], tavozas[i], vendegszam[i], etkezes[i]));
}
ir.Close();