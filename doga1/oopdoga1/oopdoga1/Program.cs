using oopdoga1;

penztarca Jurgen = new penztarca(1700);
penztarca Frau = new penztarca(900);
penztarca fizetes = new penztarca(400);
penztarca tomott = new penztarca(400);
int ajandekok = 800;
int adossag = 5500;

Console.WriteLine(Jurgen);

Jurgen -= 100; //fia zsebpénze | class - int
Console.WriteLine(Jurgen);

Jurgen -= Frau; //frau fizet | class - class
Console.WriteLine(Jurgen);

Jurgen += 400; //kp fizetés | class + int
Console.WriteLine(Jurgen);

Jurgen += fizetes; //pénztárcás fizetés | class + class
Console.WriteLine(Jurgen);
Console.WriteLine(fizetes);

ajandekok += tomott; //lakodalomban ajándék | int + class
Console.WriteLine(ajandekok);

adossag -= Jurgen; //adósság csökkentése | int - class
Console.WriteLine(adossag);
