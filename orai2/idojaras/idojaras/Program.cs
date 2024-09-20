Random random = new Random();
StreamWriter ir = new StreamWriter("ido.txt");

int fok = random.Next(10,20);
int ora = 0;
for (int i = 0; i < 14; i++)
{
    while(ora % 24 < 6 || ora % 24 > 18)
    {
        ora++;
        fok = random.Next(fok - 5, fok);
        if (fok < 10)
        {
            fok = 10;
        }
        ir.WriteLine(fok + " C° nap: " + ora / 24 + " óra: " + ora % 24);
    }
    while (ora % 24 <= 18 && ora % 24 >= 6)
    {
        ora++;
        fok = random.Next(fok, fok + 5);
        if (fok > 40)
        {
            fok = 40;
        }
        ir.WriteLine(fok + " C° nap: " + ora / 24 + " óra: " + ora % 24);
    }
}
ir.Close();
