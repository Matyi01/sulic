int[,] tabla = new int[10, 10];

for  (int i = 0; i < tabla.GetLength(0); i++)
{
    for (int j = 0; j < tabla.GetLength(1); j++)
    {
        tabla[i, j] = (i+1)*(j+1);
    }
}

for (int i = 0;i < tabla.GetLength(0); i++)
{
    for(int j = 0;j < tabla.GetLength(1); j++)
    {
        Console.Write($"{tabla[i, j]} ");
        if (j == 9)
        {
            Console.WriteLine();
        }
    }
}