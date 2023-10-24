string szo = "";
string betuk = "qwertzuiopasdfghjklyxcvbnmöüóőúéáű-";

while (szo == "")
{
    Console.Write("Kérek egy szót: ");
    szo = Console.ReadLine();
    for (int i = 0; i < szo.Length; i++)
    {
        bool temp = false;
        for (int j = 0; j < betuk.Length; j++)
        {
            if (szo[i].ToString().ToLower() == betuk[j].ToString())
            {
                temp = true;
                break;
            }
        }
        if (!temp)
        {
            Console.WriteLine("Ez nem egy szó");
            szo = "";
        }
    }
}
Console.WriteLine(szo);

string forditott = "";
for (int i = 0; i < szo.Length; i++)
{
    forditott += szo[szo.Length - 1 - i];
}
Console.WriteLine(forditott);

forditott = "";
for (int i = szo.Length - 1; i >= 0; i--)
{
    forditott += szo[i];
}
Console.WriteLine(forditott);

forditott = "";
for(int i = 0; i < szo.Length; i++)
{
    forditott = szo[i] + forditott; 
}
Console.WriteLine(forditott);

forditott = "";
for (int i = 0; i < szo.Length; i += 2)
{
    forditott += szo.Substring(szo.Length - 2 - i, 2);
}
Console.WriteLine(forditott);
