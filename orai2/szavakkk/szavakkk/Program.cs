string[] forras = File.ReadAllLines("szoveg.txt");

List<string> szoveg = new List<string>();
for (int i = 0; i < forras.Length; i += 2)
{
    szoveg.Add(forras[i]);
}

for(int i = 0; i > szoveg.Count; i++)
{
    szoveg[i].Replace("...", "");
}