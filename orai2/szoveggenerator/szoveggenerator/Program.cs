List<string> alany = new List<string>();
List<string> allitmany = new List<string>();
List<string> targy = new List<string>();
List<string> jelzo = new List<string>();
List<string> hely = new List<string>();

StreamReader olvas = new StreamReader("alany.txt");
while (!olvas.EndOfStream)
{
    alany.Add(olvas.ReadLine());
}
olvas.Close();

olvas = new StreamReader("allitmany.txt");
while (!olvas.EndOfStream)
{
    allitmany.Add(olvas.ReadLine());
}
olvas.Close();

olvas = new StreamReader("targy.txt");
while (!olvas.EndOfStream)
{
    targy.Add(olvas.ReadLine());
}
olvas.Close();

olvas = new StreamReader("jelzo.txt");
while (!olvas.EndOfStream)
{
    jelzo.Add(olvas.ReadLine());
}
olvas.Close();
olvas = new StreamReader("hely.txt");
while (!olvas.EndOfStream)
{
    hely.Add(olvas.ReadLine());
}
olvas.Close();

Random rand = new Random();

StreamWriter ir = new StreamWriter("mondatok.txt");
for (int i = 0; i < 100; i++)
{
    string temp = "";
    temp += alany[rand.Next(0, alany.Count)] + " ";
    temp += jelzo[rand.Next(0, jelzo.Count)] + " ";
    temp += targy[rand.Next(0, targy.Count)] + " ";
    temp += allitmany[rand.Next(0, allitmany.Count)] + " ";
    temp += hely[rand.Next(0, hely.Count)] + ".";


    ir.WriteLine(temp);
}
ir.Close();
