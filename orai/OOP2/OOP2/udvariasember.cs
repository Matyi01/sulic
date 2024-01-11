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
            Random rand = new Random();
            int x = rand.Next(0, 3);
            if (x == 0)
            {
                Console.WriteLine("Szia uram!");
            }
            else if (x == 1)
            {
                Console.WriteLine("Szia uraság!");
            }
            else
            {
                Console.WriteLine("Jó napot!");
            }
        }
        public void koszon(ember embervaltozonev)
        {
            Random rand = new Random();
            int x = rand.Next(0, 3);
            if (x == 0)
            {
                Console.WriteLine("Szia {0} uram!", embervaltozonev.teljesnev);
            }
            else if (x == 1)
            {
                Console.WriteLine("Szia {0} uraság!", embervaltozonev.teljesnev);
            }
            else
            {
                Console.WriteLine("Jó napot {0}!", embervaltozonev.teljesnev);
            }
        }
        public void koszonnevvel()
        {
            Random rand = new Random();
            int x = rand.Next(0, 3);
            if (x == 0)
            {
                Console.WriteLine("Szia uram! {0} vagyok", teljesnev);
            }
            else if (x == 1)
            {
                Console.WriteLine("Szia uraság! {0} vagyok", teljesnev);
            }
            else
            {
                Console.WriteLine("Jó napot! {0} vagyok", teljesnev);
            }
        }
        public void koszonnevvel(ember embervaltozonev)
        {
            Random rand = new Random();
            int x = rand.Next(0, 3);
            if (x == 0)
            {
                Console.WriteLine("Szia {0} uram! {1} vagyok", embervaltozonev.teljesnev, teljesnev);
            }
            else if (x == 1)
            {
                Console.WriteLine("Szia {0} uraság! {1} vagyok", embervaltozonev.teljesnev, teljesnev);
            }
            else
            {
                Console.WriteLine("Jó napot {0}! {1} vagyok", embervaltozonev.teljesnev, teljesnev);
            }
        }
    }
}
