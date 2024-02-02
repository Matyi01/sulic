using tarsalgo;

List<adatok> elemek = new List<adatok>();
StreamReader olvas = new StreamReader("ajto.txt");
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    elemek.Add(new adatok(sor));
}
olvas.Close();

Console.WriteLine("2. feladat");
Console.WriteLine("Az első belépő: {0}", elemek[0].id);
for (int i = elemek.Count - 1; i >= 0; i--)
{
    if (!elemek[i].benntvan)
    {
        Console.WriteLine("Az utolsó kilépő: {0}", elemek[i].id);
        break;
    }
}

/*
Dictionary<int, int> athaladasok = new Dictionary<int, int>();
for  (int i = 0; i < elemek.Count; i++)
{
    if (athaladasok.ContainsKey(elemek[i].id))
    {
        athaladasok[elemek[i].id] += 1;
    }
    else
    {
        athaladasok.Add(elemek[i].id, 1);
    }
}
*/

int[] athaladasok = new int[42];
for (int i = 0; i < elemek.Count; i++)
{
    athaladasok[elemek[i].id] += 1;
}

StreamWriter ir = new StreamWriter("athaladas.txt");
for (int i = 1; i < athaladasok.Length; i++)
{
    ir.WriteLine(i + " " + athaladasok[i]);
}
ir.Close();

List<int> benntmaradtak = new List<int>();
for (int i = 0; i < athaladasok.Length; i++)
{
    if (athaladasok[i] % 2 == 1)
    {
        benntmaradtak.Add(i);
    }
}
Console.WriteLine("4. feladat");
Console.WriteLine("A végén a társalgóban voltak: {0}", String.Join(" ", benntmaradtak.ToArray()));

int hanyanvannakbennt = 0;
int hanyanvannakbenntmax = 0;
string orapercmax = "";
for (int i = 0; i < elemek.Count; i++)
{
    if (elemek[i].benntvan)
    {
        hanyanvannakbennt++;
    }
    else
    {
        hanyanvannakbennt--;
    }
    if (hanyanvannakbennt > hanyanvannakbenntmax)
    {
        orapercmax = elemek[i].oraperc;
    }
}

Console.WriteLine("5. feladat");
Console.WriteLine("Például {0}-kor voltak a legtöbben a társalgóban.", orapercmax);


Console.WriteLine("6. feladat");
Console.Write("Adja meg a személy azonosítóját! ");
int be = Convert.ToInt32(Console.ReadLine());

List<string> idok = new List<string>();
for (int i = 0; i < elemek.Count; i++)
{
    if (elemek[i].id == be)
    {
        idok.Add(elemek[i].oraperc);
    }
}

Console.WriteLine("7. feldadat");
for (int i = 0; i < idok.Count; i += 2)
{
    Console.Write(idok[i] + "-");
    if (i + 1 < idok.Count)
    {
        Console.WriteLine(idok[i + 1]);
    }
}