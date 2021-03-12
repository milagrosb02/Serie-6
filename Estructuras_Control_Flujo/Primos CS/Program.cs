using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            int cont;


            for(int num = 1; num <= 999; num++)
            {

                i = 1;

                cont = 0;

                while(cont <= 2 && i <= num)
                {

                    if (num % i == 0)

                        cont += 1;

                    i += 1;

                }

                if (cont == 2)

                    Console.WriteLine(num);

            }

            Console.ReadLine();
        }
    }
}
