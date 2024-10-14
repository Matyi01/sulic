using LezerLoveszet;

List<JatekosLovese> lista = new List<JatekosLovese>();

StreamReader olvas = new StreamReader("lovesek.txt");

string tablakordi = olvas.ReadLine();
int i = 1;
while (!olvas.EndOfStream)
{
    JatekosLovese temp = new JatekosLovese(olvas.ReadLine(), i++);
    lista.Add(temp);
}

olvas.Close();

Console.WriteLine("5. feladat: Lövések száma: {0} db", lista.Count);

Console.WriteLine("7. feladat: Legpontosabb lövés:");
