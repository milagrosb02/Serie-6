using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            int i,a, b, c;

            a = 0;

            c = 1;

            for (i = 0; i <= 20; i++)
            {
                b = a + c;

                Console.WriteLine(b);

                a = c;

                c = b;
            }

        }
    }
}
