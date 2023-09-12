using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <= 10; i++)
            {
                double sqr = Math.Pow(i, 2);
                Console.WriteLine(sqr);
            }
        }
    }
}
