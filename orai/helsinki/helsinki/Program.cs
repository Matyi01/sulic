using helsinki1952;

List<adatok> eredmnenyek = new List<adatok>();
StreamReader olvas = new StreamReader("helsinki.txt");
while (!olvas.EndOfStream)
{
    eredmnenyek.Add(new adatok(olvas.ReadLine()));
}
olvas.Close();

Console.WriteLine("3. feladat:");
Console.WriteLine("Pontszerző helyezések száma: {0}", eredmnenyek.Count);

int[] pontok = new int[7];
for (int i = 0; i < eredmnenyek.Count; i++)
{
    pontok[eredmnenyek[i].helyezes]++;
}
Console.WriteLine("4. feladat");
Console.WriteLine("Arany: {0}", pontok[1]);
Console.WriteLine("Ezüst: {0}", pontok[2]);
Console.WriteLine("Bronz: {0}", pontok[3]);
Console.WriteLine("Összesen: {0}", pontok[1] + pontok[2] + pontok[3]);

Console.WriteLine("5.fealdat");
Console.WriteLine("Olimpiai pontok száma: {0}", pontok[1]*7 + pontok[2] * 5 + pontok[3] * 4 + pontok[4] * 3 + pontok[5] * 2 + pontok[6] * 1);

