using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    internal class KutyaFajta
    {
        public string nev;
        public int id;
        public string eredetiNev;
        public KutyaFajta(string sor)
        {
            this.nev = sor.Split(";")[1];
            this.id = int.Parse(sor.Split(";")[0]);
            this.eredetiNev = sor.Split(";")[2];
        }
    }
}
