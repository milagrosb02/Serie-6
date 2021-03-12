using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparar_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            double primerValor, segundoValor;

            Console.WriteLine("Ingresar valor: ");
            primerValor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar otro valor: ");
            segundoValor = Convert.ToDouble(Console.ReadLine());


            if(primerValor > segundoValor)
            {
                Console.WriteLine(primerValor + " " + "es el mayor y" + " " + segundoValor + " " + "es el menor.");
            }

            if(segundoValor > primerValor)
            {
                Console.WriteLine(segundoValor + " " + "es el mayor y" + " " + primerValor + " " + "es el menor.");
            }

            if(primerValor == segundoValor)
            {
                Console.WriteLine(primerValor + " " + "y" + " " + segundoValor + " " + "son iguales.");
            }

        }
            
    }
}
