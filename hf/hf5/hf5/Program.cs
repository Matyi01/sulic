Console.Write("Kérek egy több szavas szöveget: ");
string szo = Console.ReadLine();

string[] kiir = szo.Split(" ");
for  (int i = 0; i < kiir.Length; i++)
{
    if (kiir[i] != "")
    {
        Console.Write(kiir[i].Substring(0, 1).ToUpper() + kiir[i].Substring(1).ToLower() + " ");
    }
}