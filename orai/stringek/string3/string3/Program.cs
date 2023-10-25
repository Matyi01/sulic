string betuk = "qwertzuiopőúasdfghjkléáűíyxcvbnmöüó-";

string beszo = " ";
string gyujto = "";
while (beszo != "") 
{
    bool joszo = true;

    Console.Write("Kérek egy szót: ");
    beszo = Console.ReadLine();

    for  (int i = 0; i < beszo.Length; i++)
    {
        if (betuk.IndexOf(beszo[i]) == -1)
        {
            joszo = false;
            Console.WriteLine("Ez nem jó szó! ");
            break;
        }
    }
    if (joszo)
    {
        gyujto += beszo + " ";
    }
}

string[] szavak = gyujto.Trim().Split(" ");

StreamWriter ir = new StreamWriter("szavak.txt");
foreach (string s in szavak)
{
    ir.WriteLine(s);
}
ir.Close();

File.WriteAllLines("szavak2.txt", szavak);