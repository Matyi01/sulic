using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezerLoveszet
{
    internal class JatekosLovese
    {
        public string nev;
        public double x;
        public double y;
        public int sorszam;
        public JatekosLovese(string sor, int sorszam)
        {
            string[] temp = sor.Split(";");
            this.nev = temp[0];
            this.x = Convert.ToDouble(temp[1]);
            this.y = Convert.ToDouble(temp[2]);
            this.sorszam = sorszam;
        }
        public double Tavolsag(float CéltáblaX, float CéltáblaY)
        {
            double dx = CéltáblaX - x;
            double dy = CéltáblaY - y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
