using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 100; i += 5)
                Console.Write(i);
            Console.WriteLine();
            for (int i = 10; i < 100; i++)
                if (i % 5 == 0)
                    Console.Write(i);
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
                if (i >= 10 && i % 5 == 0)
                    Console.Write(i);
            Console.WriteLine();
        }
    }
}
