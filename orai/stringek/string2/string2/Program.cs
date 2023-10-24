string szo = "";
string betuk = "qwertzuiopasdfghjklyxcvbnm-";

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


