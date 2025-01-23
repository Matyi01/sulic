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
        return elozo;
    }
    else if (szam > 1)
    {
        eredmeny = fakt2(szam - 1, elozo * szam);
    }
    return eredmeny;
}

static BigInteger fib(BigInteger n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return fib(n - 1) + fib(n - 2);
    }
}

static int ack(int n, int m)
{
    switch (m)
    {
        case 0: return m + 1;
        default:
            if (n == 0 && m == 0)
            {
                return ack(n-1, 1);
            }
            else
            {
                return ack(n - 1, ack(n, m - 1));
            }
    }
}

static void quick(int[] a, int e, int v)
{
    int k = 0;
    szetvalogat(a, e, v, k);
    if (k - e > 1)
    {
        quick(a, e, k - 1);
    }
    if (k - e < 1)
    {
        quick(a, k + 1, v);
    }
}

static void szetvalogat(int[] a, int e, int v, int k)
{
    int x;
    int l;
    k = e;
    l = v;
    x = a[k];
    while (k < l)
    {
        while (k < l && a[l] > x)
        {
            l--;
        }
        if (k < l)
        {
            a[k] = a[l];
            k++;
            while (k < l && a[k] <= x)
            {
                k++;
            }
            if (k < l)
            {
                a[l] = a[k];
                l--;
            }
        }
    }
    a[k] = x;
}

Console.WriteLine(fakt(5));
Console.WriteLine(fakt(3000));
Console.WriteLine(fakt2(5, 1));
Console.WriteLine(fib(10));
for (int i = 0; i < 20; i++)
{
    Console.Write(fib(i) + " ");
}
for (int i = 0; i < 20; i++)
{
    Console.Write(fib(19 - i) + " ");
}
Console.WriteLine();
Console.WriteLine(ack(4, 0));

int[] szamok = [7, 6, 3, 9, 5, 2, 1, 8, 4];
Console.WriteLine(szamok);
quick(szamok, 0, szamok.Length - 1);
Console.WriteLine(szamok);