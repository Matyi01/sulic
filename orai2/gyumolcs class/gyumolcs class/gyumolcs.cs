using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyumolcs_class
{
    internal class gyumolcs
    {
        public string nev;
        public int suly;
        public gyumolcs(string nev, int suly)
        {
            this.nev = nev;
            this.suly = suly;
        }
        public static gyumolcs operator +(gyumolcs a, gyumolcs b)
        {
            return new gyumolcs(a.nev + b.nev, a.suly +b.suly);
        }
        public static gyumolcs operator *(gyumolcs a, gyumolcs b)
        {
            throw new NotImplementedException();
        }
        public static gyumolcs operator *(gyumolcs a, int b)
        {
            return new gyumolcs(a.nev, a.suly * b);
        }
        public static gyumolcs operator *(int a, gyumolcs b)
        {
            return new gyumolcs(b.nev, b.suly * a);
        }
        public static gyumolcs operator /(gyumolcs a, gyumolcs b)
        {
            throw new NotImplementedException();
        }
        public static gyumolcs operator /(gyumolcs a, int b)
        {
            return new gyumolcs(a.nev, a.suly / b);
        }
        public static gyumolcs operator /(int a, gyumolcs b)
        {
            return new gyumolcs(b.nev, b.suly / a);
        }
        public override string ToString()
        {
            return $"név: {nev}, súly: {suly}";
        }
    }
}
