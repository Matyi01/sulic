using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    internal class KutyaNev
    {
        public string nev;
        public int id;
        public KutyaNev(string sor)
        {
            this.nev = sor.Split(";")[1];
            this.id = int.Parse(sor.Split(";")[0]);
        }
    }
}
