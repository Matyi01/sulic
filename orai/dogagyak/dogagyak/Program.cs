using System.Xml.Schema;

List<int> percek = new List<int>();
List<double> ho1 = new List<double>();
List<double> ho2 = new List<double>();
List<double> ho3 = new List<double>();
List<double> ho4 = new List<double>();
List<int> darab = new List<int>();

 void betolt()
{
    StreamReader olvas = new StreamReader("adathalmaz.csv");
    olvas.ReadLine();
    while (!olvas.EndOfStream)
    {
        string sor = olvas.ReadLine();
        string[] vag = sor.Split(";");
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
    olvas.Close();
}
void betolt2()
{
    string[] sorok = File.ReadAllLines("adathalmaz.csv");
    for (int i = 1; i < sorok.Length; i++)
    {
        string[] vag = sorok[i].Split(";");
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}

void betol32()
{
    string[] sorok = File.ReadAllLines("adathalmaz.csv").ToList().Skip(1).ToArray();
    foreach (string sor in sorok)
    {
        string[] vag = sor.Split(";");
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}

betolt();

Console.WriteLine("2. feladat:\nEnnyi adatsor van: {0}", percek.Count);

Console.WriteLine("3. feladat:\nÁtlagos termelés: {0} db/óra", darab[darab.Count - 1] / 24);
Console.WriteLine("4. feladat:\nMin1: {0},\nMin2: {1},\nMin3: {2},\nMin4: {3},", ho1.Min(), ho2.Min(), ho3.Min(), ho4.Min());
double minimum = ho1[0];
for  (int i = 0; i < ho2.Count; i++)
{
    if (ho1[i] < minimum)
    {
        minimum = ho2[i];
    }
}

double maximum = ho1[0];
int maxindex = 0;
for (int i = 0;i < ho1.Count; i++)
{
    if (ho1[i] > maximum)
    {
        maximum = ho1[i];
        maxindex = i;
    }
}
Console.WriteLine("5. feladat:\n{0} fok, {1} perc", maximum, maxindex);

Console.WriteLine("5. feladat:\n{0} fok, {1} perc", ho1.Max(), percek[ho1.IndexOf(ho1.Max())]);

List<int> darabotperc = new List<int>();
darabotperc.Add(darab[0]);
for (int i = 1; i < darab.Count; i++)
{
    darabotperc.Add(darab[i] - darab[i - 1]);
}