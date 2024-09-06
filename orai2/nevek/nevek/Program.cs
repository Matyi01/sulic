using System.Text;

StreamReader olvas = new StreamReader("nevek.txt");

StreamWriter ir = new StreamWriter("nevek2.txt");

while (!olvas.EndOfStream)
{
    string nev = olvas.ReadLine();
    byte[] bytes = Encoding.Default.GetBytes(nev);
    nev = Encoding.UTF8.GetString(bytes);
    ir.WriteLine(String.Concat(nev.OrderBy(c => c)));
}

olvas.Close();

ir.Close();