using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowl
{
    internal class Eredmeny
    {
        //Ssz;Dátum;Győztes;Eredmény;Vesztes;Helyszín;VárosÁllam;Nézőszám
        string ssz;
        string datum;
        string gyoztes;
        string eredmeny;
        string vesztes;
        string helyszin;
        string varosAllam;
        int nezoszam;
        public Eredmeny(string ssz, string datum, string gyoztes, string eredmeny, string vesztes, string helyszin, string varosAllam, int nezoszam)
        {
            this.ssz = ssz;
            this.datum = datum;
            this.gyoztes = gyoztes;
            this.eredmeny = eredmeny;
            this.vesztes = vesztes;
            this.helyszin = helyszin;
            this.varosAllam = varosAllam;
            this.nezoszam = nezoszam;
        }
    }
}
