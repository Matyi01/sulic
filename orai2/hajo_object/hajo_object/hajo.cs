using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajo_object
{
    internal class hajo : hajo1
    {
        public void fordul()
        {
            Console.WriteLine("fordulok");
        }
        public void megy()
        {
            Console.WriteLine("megyek");
        }
        public void duda()
        {
            Console.WriteLine("BUUUUU");
        }
        public void sullyed()
        {
            Console.WriteLine("ÁÁÁÁÁÁ");
        }
        public string nev;
        public double hossz;
        public string szin;
        public double vizkiszoritas;
        public string meghajtas;
        public hajo(string nev, double hossz, string szin, double vizkiszoritas, string meghajtas)
        {
            this.nev = nev;
            this.hossz = hossz;
            this.szin = szin;
            this.vizkiszoritas = vizkiszoritas;
            this.meghajtas = meghajtas;
        }
    }
}
