
StreamReader olvas = new StreamReader("nevek.txt");
List<string> nevek = new List<string>();
while (!olvas.EndOfStream)
{
    nevek.Add(olvas.ReadLine().Trim());
}
olvas.Close();

olvas = new StreamReader("vezeteknevek.txt");
List<string> vezeteknevek = new List<string>();
while (!olvas.EndOfStream)
{
    vezeteknevek.Add(olvas.ReadLine().Trim());
}
olvas.Close();

StreamWriter ir = new StreamWriter("nevek2.txt");
Random random = new Random();
for (int i = 0; i < 200; i++)
{
    int esely = random.Next(1,5);
    if (esely == 1)
    {
        ir.WriteLine(vezeteknevek[random.Next(1, vezeteknevek.Count)] + " " + nevek[random.Next(1, nevek.Count)] + " " + nevek[random.Next(1, nevek.Count)]);
    }
    else
    {
        ir.WriteLine(vezeteknevek[random.Next(1, vezeteknevek.Count)] + " " + nevek[random.Next(1, nevek.Count)]);
    }
}
ir.Close();