Console.Write("Hány sor legyen?: ");
int sor = Convert.ToInt32(Console.ReadLine());

Console.Write("Hány oszlop legyen?: ");
int oszlop = Convert.ToInt32(Console.ReadLine());

string[,] tabla = new string[sor, oszlop];

for  (int i = 0; i < tabla.GetLength(0); i++)
{
    for (int j = 0; j < tabla.GetLength(1); j++)
    {
        tabla[i, j] = "";
        for (int k = 0; k < i+1; k++)
        {
            tabla[i, j] += "a";
        }
        for (int k = 0;k < j+1; k++)
        {
            tabla[i, j] += "b";
        }
    }
}

foreach (string i in tabla)
{
    Console.WriteLine(i);
}

for (int i = 0;i < tabla.GetLength(0); i++)
{
    for (int j = 0;j < tabla.GetLength(1); j++)
    {
        Console.Write($"{tabla[i, j]}\t");
    }
    Console.WriteLine();
}