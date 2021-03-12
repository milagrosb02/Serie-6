using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImpares_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            ushort valor, contPar, contImpar;

            contPar = 0;

            contImpar = 0;

            Console.WriteLine("Ingresar un valor cualquiera: ");

            valor = Convert.ToUInt16(Console.ReadLine());    // Leer primero valor


            while (valor != 0)
            {
                if ((valor % 2) != 0)
                    contImpar += 1;
                else
                    contPar += 1;


                Console.WriteLine("Ingresar un valor cualquiera: ");

                valor = Convert.ToUInt16(Console.ReadLine());  // Leer valor siguiente
            }


            Console.WriteLine("Cantidad de impares: " + contImpar);

            Console.WriteLine("Cantidad de pares: " + contPar);

        }
    }
}
