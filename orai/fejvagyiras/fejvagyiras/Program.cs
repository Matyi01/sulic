List<string> lista1 = new List<string>();
List<string> lista2 = new List<string>();

string[] filetomb = File.ReadAllLines("kiserlet.txt");
for (int i = 0; i < filetomb.Length; i++)
{
    lista1.Add(filetomb[i]);
}

StreamReader olvas = new StreamReader("kiserlet.txt");
while (!olvas.EndOfStream)
{
    lista2.Add(olvas.ReadLine());
}
olvas.Close();

for (int i = 0;i < lista1.Count; i++)
{
    Console.WriteLine("Első lista: {0}, második lista: {1}", lista1[i], lista2[i]);
}

Random rand = new Random();
string erme = "";
if (rand.Next(1) == 0)
{
    erme = "I";
}
else
{
    erme = "F";
}
Console.WriteLine("1. feladat");
Console.WriteLine("A pénzfeldobás eredménye: {0}",erme);