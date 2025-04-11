using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class NyelvAdat
    {
        public string nyelv;
        public List<EvAdat> vizsgak = new List<EvAdat>();
        public NyelvAdat(string sor, int[] evszamok)
        {
            string[] vag = sor.Split(";");
            this.nyelv = vag[0];
            int[] adatok = new int[vag.Length - 1];
            for (int i = 1; i < vag.Length - 1; i++)
            {
                adatok[i] = int.Parse(vag[i]);
            }
            seged(nyelv, adatok, evszamok);
        }
        public NyelvAdat(string nyelv, int[] adatok, int[] evszamok)
        {
            seged(nyelv, adatok, evszamok);
        }
        private void seged(string nyelv, int[] adatok, int[] evszamok)
        {
            this.nyelv = nyelv;
            for (int i = 0; i < adatok.Length; i++)
            {
                this.vizsgak.Add(new EvAdat(evszamok[i], adatok[i]));
            }
        }
        public override string ToString()
        {
            return nyelv + ": " + vizsgak;
        }
    }
}
