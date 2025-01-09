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
        public string ssz;
        public string datum;
        public string gyoztes;
        public string eredmeny;
        public string vesztes;
        public string helyszin;
        public string varosAllam;
        public int nezoszam;
        public Eredmeny(string[] tomb)
        {
            this.ssz = tomb[0];
            this.datum = tomb[1];
            this.gyoztes = tomb[2];
            this.eredmeny = tomb[3];
            this.vesztes = tomb[4];
            this.helyszin = tomb[5];
            this.varosAllam = tomb[6];
            this.nezoszam = Convert.ToInt32(tomb[7]);
        }
        /*
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
        */
    }
}
