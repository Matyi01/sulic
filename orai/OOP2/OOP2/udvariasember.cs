using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class udvariasember : ember
    {
        public udvariasember(string vnev, string knev) : base(vnev, knev)
        {

        }
        public void koszon()
        {
            Console.WriteLine("Szia uram!");
        }
        public void koszon(ember embervaltozonev)
        {
            Console.WriteLine("Szia {0} uram!", embervaltozonev.teljesnev);
        }
        public void koszonnevvel()
        {
            Console.WriteLine("Szia uram! {0} vagyok", teljesnev);
        }
        public void koszonnevvel(ember embervaltozonev)
        {
            Console.WriteLine("Szia {0} uram! {1} vagyok", embervaltozonev.teljesnev, teljesnev);
        }
    }
}
