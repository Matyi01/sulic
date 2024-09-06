
using System.IO;

int be = 1;
while (be != 0)
{
    int szam = Convert.ToInt32(Console.ReadLine());
    File.WriteAllText("szamok.txt", Convert.ToString(szam));
}

