/*
Console.Write("Kérek egy számot: ");
int szambe = Convert.ToInt32(Console.ReadLine());

string[] szavak = new string[szambe];

for (int i = 0; i < szambe; i++)
{
    Console.Write("Kérek egy szót: ");
    szavak[i] = Console.ReadLine();
}

string max = "";
for (int i = 0; i < szambe; i++)
{
    if (szavak[i].Length > max.Length)
    {
        max = szavak[i];
    }
}
Console.WriteLine(max);

int maxindex = 0;
for (int i = 0;i < szambe; i++)
{
    if (szavak[i] == max) 
    { 
        maxindex = i;
    }
}

//Console.WriteLine(szavak.OrderByDescending(s => s.Length).First());


max = "";
maxindex = 0;
for (int i = 0; i < szambe; i++)
{
    if (szavak[i].Length > max.Length)
    {
        max = szavak[i];
        maxindex = i;
    }
}

maxindex = 0;
for (int i = 0; i < szambe; i++)
{
    if (szavak[i].Length > szavak[maxindex].Length)
    {
        maxindex = i;
    }
}
*/


string[] szavak = new string[] { "alma", "körte", "narancs", "mandarin", "ananász", "banán"};

string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];

int rovidindex = 0;
int hosszuindex = 0;

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length <= 5)
    {
        rovid[rovidindex] = szavak[i];
        rovidindex++;
    }
    else
    {
        hosszu[hosszuindex++] = szavak[i];
    }
}
foreach (string s in rovid)
{
    Console.WriteLine(s);
}
foreach (string s in hosszu)
{
    Console.WriteLine(s);
}