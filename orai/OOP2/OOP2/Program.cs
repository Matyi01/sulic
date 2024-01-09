using OOP2;

ember e1 = new ember("Szakács", "Árpád");
Console.WriteLine(e1.teljesnev);

ember e2 = new ember("Nagy", "Árpi");
Console.WriteLine(e2.teljesnev);

udvariasember ue1 = new udvariasember("Horváth","Hugó");
Console.WriteLine(ue1.teljesnev);
ue1.koszon();
ue1.koszonnevvel();
ue1.koszon(e1);
ue1.koszonnevvel(e2);

diak d1 = new diak("Tálas", "Miklós", 12);
diak d2 = new diak("Verbulecz", "Bálint", 19);
diak d3 = new diak("Mibajodvan", "Alehandro", 26);

d1.koszon(ue1);
d1.koszon(d2);
