using System.Numerics;

static BigInteger fakt(BigInteger szam)
{
    BigInteger eredmeny = 1;
    if (szam == 1)
    {
        return 1;
    }
    else if (szam > 1)
    {
        eredmeny = fakt(szam - 1);
    }
    return szam * eredmeny;
}

static BigInteger fakt2(BigInteger szam, BigInteger elozo)
{
    BigInteger eredmeny = 1;
    if (szam == 1)
    {
        return 1;
    }
    else if (szam > 1)
    {
        eredmeny = fakt2(szam - 1, elozo * szam);
    }
    return eredmeny;
}

Console.WriteLine(fakt(5));
Console.WriteLine(fakt(3000));
Console.WriteLine(fakt2(5, 0));
