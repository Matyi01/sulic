using operatorFeluliras1;

Allat a1 = new Allat("Bimbó", 300, 200000);
Console.WriteLine(a1);

Csorda cs1 = new Csorda();
Csorda cs2 = new Csorda(a1);
Csorda cs3 = new Csorda(cs2);

Csorda cs4 = cs2 + a1;

Console.WriteLine(cs4.tagok);