using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            double primerValor, segundoValor, tercerValor, menor1, menor2, menor3;

            menor1 = 0;

            menor2 = 0;

            menor3 = 0;

            Console.WriteLine("Ingresar valor: ");
            primerValor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar otro valor: ");
            segundoValor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar otro valor: ");
            tercerValor = Convert.ToDouble(Console.ReadLine());

            if(primerValor < segundoValor && primerValor < tercerValor)
            {
                menor1 = primerValor;
                Console.WriteLine("El menor es " + menor1);
            }

            if (segundoValor < tercerValor && segundoValor < primerValor)
            {
                menor2 = segundoValor;

                Console.WriteLine("El menor es " + menor2);

            }

            if(tercerValor < segundoValor && tercerValor < primerValor)
            {
                menor3 = tercerValor;

                Console.WriteLine("El menor es " + menor3);
            }

        }
    }
}
