class auto
{
    public int kerekszam = 4;

    public void dudal()
    {
        Console.WriteLine("tütü");
    }


    private string _tulaj;
    public string tulajdonos
    {
        get
        {
            return _tulaj;
        }
        set
        {
            if (value == "Bence")
            {
                Console.WriteLine("Nem!");
            }
            else
            {
                _tulaj = value;
            }
        }
    }
}

class program
{
    static void Main()
    {
        auto kocsi = new auto();
        Console.WriteLine(kocsi.kerekszam);
        kocsi.dudal();
        kocsi.tulajdonos = "Gabi";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "Bence";
        Console.WriteLine(kocsi.tulajdonos);
    }
}