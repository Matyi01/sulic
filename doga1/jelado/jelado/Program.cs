using jelado;

static int eltelt(adat a1, adat a2)
{
    int mp1 = a1.mp;
    int mp2 = a1.perc * 60;
    int mp3 = a1.ora * 60 * 60;
    int mp4 = a2.mp;
    int mp5 = a2.perc * 60;
    int mp6 = a2.ora * 60 * 60;
    int mp = (mp1 + mp2 + mp3) - (mp4 + mp5 + mp6);
    return mp;
}

static double tav(adat a1, adat a2)
{
    return Math.Sqrt((a1.x - a2.x) * (a1.x - a2.x) + (a1.y - a2.y) * (a1.y - a2.y));
}

string[] text = File.ReadAllLines("jel.txt");

List<adat> jelek = new List<adat>();
foreach (string line in text)
{
    jelek.Add(new adat(line));
}

Console.WriteLine("2.feladat");
Console.Write("Adja meg a jel sorszámát! ");
int beszam = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("x={0} y={1}", jelek[beszam].x, jelek[beszam].y);

int ido = eltelt(jelek[jelek.Count - 1], jelek[0]);
int ora = ido / (60 * 60);
int perc = ido / 60 - ora * 60;
int mp = ido - perc * 60 - ora * 60 * 60;

Console.WriteLine();
Console.WriteLine("4.feladat");
Console.WriteLine("Időtartam: {0}:{1}:{2}", ora, perc, mp);

int minx = jelek[0].x;
int maxx = jelek[0].x;
int miny = jelek[0].y;
int maxy = jelek[0].y;

foreach (adat adat in jelek)
{
    if (adat.x < minx)
    {
    minx = adat.x; 
    }
    if (adat.x > maxx)
    {
        maxx = adat.x;
    }
    if (adat.y < miny)
    {
        miny = adat.y;
    }
    if (adat.y > maxy)
    {
        maxy = adat.y;
    }
}
Console.WriteLine();
Console.WriteLine("5.feladat");
Console.WriteLine("Bal alsó: {0} {1}, jobb felső: {2} {3}", minx, miny, maxx, maxy);

double elmozdulas = 0;
for (int i = 0; i < jelek.Count - 1; i++)
{
    elmozdulas += tav(jelek[i], jelek[i + 1]);
}

Console.WriteLine();
Console.WriteLine("6.feladat");
Console.WriteLine("Elmozdulás: {0} egység", elmozdulas.ToString("0.000"));

//5 percnél több idő telik el, vagy a koordináták változása 10 egységnél nagyobb.
StreamWriter ir = new StreamWriter("kimaradt.txt");
for (int i = 0; i < jelek.Count - 1; i++)
{
    if (eltelt(jelek[i + 1], jelek[i]) / 60 > 5)
    {
        ir.WriteLine("{0} {1} {2} időeltérés {3}", jelek[i + 1].ora, jelek[i + 1].perc, jelek[i + 1].mp, (eltelt(jelek[i + 1], jelek[i]) / 60 - 5) / 5 );
    }
    if (tav(jelek[i], jelek[i + 1]) > 20)
    {
        ir.WriteLine("{0} {1} {2} koordináta-eltérés", jelek[i + 1].ora, jelek[i + 1].perc, jelek[i + 1].mp);
    }
}
ir.Close();