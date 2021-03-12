using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal capitalInicial, capital, meses, interes, saldo, totalIntereses;

            const decimal tasa = 0.36M;

            capital = 0;

            totalIntereses = 0;

            Console.WriteLine("Ingresar un capital inicial: ");

            capitalInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresar una cantidad de meses: ");

            meses = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("MES | CAPITAL | INTERES | SALDO");

            for (var x = 1; x <= meses; x++)
            {
                capital += capitalInicial;

                interes = capital * (tasa / 12);

                saldo = capital + interes;

                totalIntereses += interes;

                Console.WriteLine(x + "      " + capital + "     " + interes + "    " + saldo);
            }

            Console.WriteLine("El interes ganado es de: " + totalIntereses);

        }
    }
}
