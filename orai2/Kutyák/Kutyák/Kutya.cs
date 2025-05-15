using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    internal class Kutya
    {
        public int id;
        public int fajid;
        public int nevid;
        public int kor;
        public DateOnly datum;
        public Kutya(string sor)
        {
            this.id = int.Parse(sor.Split(";")[0]);
            this.fajid = int.Parse(sor.Split(";")[1]);
            this.nevid = int.Parse(sor.Split(";")[2]);
            this.kor = int.Parse(sor.Split(";")[3]);
            this.datum = DateOnly.Parse(sor.Split(";")[4]);
        }
    }
}
