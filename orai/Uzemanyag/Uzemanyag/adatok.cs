using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzemanyag
{
    internal class adatok
    {
        public DateTime datum;
        public int benzin;
        public int gazolaj;
        double euro = 307.7;
        public adatok(string sor)
        {
            string[] vag = sor.Split(";");
            datum = Convert.ToDateTime(vag[0]);
            benzin = Convert.ToInt32(vag[1]);
            gazolaj = Convert.ToInt32(vag[2]);
        }
        public int kulonbseg()
        {
            return Math.Abs(benzin - gazolaj);
        }
        public double benzineuro()
        {
            return benzin / euro;
        }
        public double gazolajeuro()
        {
            return gazolaj / euro;
        }
        public string fajlba()
        {
            return datum.ToString()+";"+Math.Round(benzineuro(), 2)+";"+Math.Round(gazolajeuro(), 2);
        }
    }
}
