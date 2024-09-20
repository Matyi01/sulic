using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevjegyclass
{
    internal class Class1
    {
        public string vezetek_nev;
        public string kereszt_nev;
        public string anya_nev;
        public string apa_nev;
        public int telefon;
        public string email;
        public int szul_ev;
        public int szul_honap;
        public int szul_nap;
        public Class1(string vezetek_nev, string kereszt_nev, string anya_nev, string apa_nev, int telefon, string email, int szul_ev, int szul_honap, int szul_nap)
        {
            this.kereszt_nev = vezetek_nev;
            this.vezetek_nev = kereszt_nev;
            this.anya_nev = anya_nev;
            this.apa_nev = apa_nev;
            this.telefon = telefon;
            this.email = email;
            this.szul_ev = szul_ev;
            this.szul_honap = szul_honap;
            this.szul_nap = szul_nap;
        }
    }
}
