using tanciskola;

List<Par> parok = new List<Par>();

StreamReader olvas = new StreamReader("tancrend.txt");

while (!olvas.EndOfStream)
{
    parok.Add(new Par(olvas.ReadLine(), olvas.ReadLine(), olvas.ReadLine()));
}

olvas.Close();

Console.WriteLine("2. feladat:");
Console.WriteLine("Az elsőként bemutatott tánc neve: {0}, az utolsóként: {1}", parok.First().tanc, parok.Last().tanc);

Console.WriteLine("3. feladat:");
Console.WriteLine("A sambát {0} pár muatta be.", parok.Where(e => e.tanc == "samba").Count());

Console.WriteLine("4. feladat:");
Console.WriteLine("Vilma ezekben a táncokban szerepelt: {0}", string.Join(", ", parok.Where(e => e.lany == "Vilma").Select(e => e.tanc)));

Console.WriteLine("5. feladat:");
Console.Write("Kérem egy tánc nevét: ");
string tancbe = Console.ReadLine();
if (parok.Where(e => e.lany == "Vilma" && e.tanc == tancbe).Count() != 0)
{
    Console.WriteLine("A {0} bemutatóján Vilma párja {1} volt.", tancbe, parok.Where(e => e.lany == "Vilma" && e.tanc == tancbe).Select(e => e.fiu).ToArray()[0]);
}
else
{
    Console.WriteLine("Vilma nem táncolt {0}-t.", tancbe);
}


StreamWriter ir = new StreamWriter("szereplok.txt");
ir.WriteLine("Lányok: {0}", string.Join(", ", parok.Select(e => e.lany).Distinct()));
ir.WriteLine("Fiúk: {0}", string.Join(", ", parok.Select(e => e.fiu).Distinct()));
ir.Close();


Console.WriteLine("7. feladat:");
var fiucsoportok = parok.GroupBy(e => e.fiu).Select(csoport => new { nev = csoport.Key, db = csoport.Count() });
var lanycsoportok = parok.GroupBy(e => e.lany).Select(csoport => new { nev = csoport.Key, db = csoport.Count() });
Console.WriteLine("A fiúk közül a legtöbbször szerepelt: {0}, a lányok közül a legtöbbször szerepelt: {1}", string.Join(", ", fiucsoportok.Where(e => e.db == fiucsoportok.Select(e => e.db).ToArray().Max()).Select(e => e.nev)), string.Join(", ", lanycsoportok.Where(e => e.db == lanycsoportok.Select(e => e.db).ToArray().Max()).Select(e => e.nev)));
