using operatorFeluliras1;

Allat a1 = new Allat("Bimbó", 300, 206700);

Csorda cs1 = new Csorda();
Csorda cs2 = new Csorda(a1);
Csorda cs3 = new Csorda(cs2);

Allat a2 = new Allat("Zsömle", 320, 257000);
Allat a3 = new Allat("Lajos", 400, 315000);
Csorda cs4 = cs2 + a1;
cs4 += a2;
cs4 += a3;
cs4 += a3;
cs4.kiir();
Console.WriteLine("-----------------------------");

cs4 -= a2;
cs4 -= a3;
cs4 -= a3;
cs2.kiir();
Console.WriteLine("-----------------------------");

cs4.kiir();
