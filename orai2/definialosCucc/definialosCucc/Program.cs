using definialosCucc;

Pont p1 = new Pont(1, 1);
Pont p2 = new Pont(2, 3);
Console.WriteLine(p1 + p2);
Console.WriteLine(p1 - p2);
Console.WriteLine(p1 * p2);
Console.WriteLine(p1 / p2);
Console.WriteLine(p2 + 2);
Console.WriteLine(p2 - 2);
Console.WriteLine(p2 * 2);
Console.WriteLine(p2 / 2);
Console.WriteLine(p2++);
Console.WriteLine(++p2);
Console.WriteLine(p1.Equals(p1));
Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p2.Equals(1));

Console.WriteLine(p1.Equals(new Pont(1, 1)));
Console.WriteLine(p1 == new Pont(1, 1));
Console.WriteLine(p1 != p2);