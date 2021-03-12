using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tercero_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            ushort primerValor, segundoValor, tercerValor, cuartoValor, quintoValor, mayor1, mayor2, mayor3, mayor4, mayor5;

            Console.WriteLine("Ingresar valor: ");
            primerValor = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Ingresar otro valor: ");
            segundoValor = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Ingresar otro valor: ");
            tercerValor = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Ingresar valor: ");
            cuartoValor = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Ingresar otro valor: ");
            quintoValor = Convert.ToUInt16(Console.ReadLine());


            if(primerValor > segundoValor && primerValor > tercerValor && primerValor > cuartoValor && primerValor > quintoValor)
            {
                mayor1 = primerValor;

                Console.WriteLine("El primer numero es el mayor: " + mayor1);
            }

            if(segundoValor > primerValor && segundoValor > tercerValor && segundoValor > cuartoValor && segundoValor > quintoValor)
            {
                mayor2 = segundoValor;

                Console.WriteLine("El segundo numero es el mayor: " + mayor2);
            }

            if(tercerValor > primerValor && tercerValor > segundoValor && tercerValor > cuartoValor && tercerValor > quintoValor)
            {
                mayor3 = tercerValor;

                Console.WriteLine("El tercer numero es el mayor: " + mayor3);
            }

            if(cuartoValor > primerValor && cuartoValor > segundoValor && cuartoValor > tercerValor && cuartoValor > quintoValor)
            {
                mayor4 = cuartoValor;

                Console.WriteLine("El cuarto numero es el mayor: " + mayor4);
            }

            if(quintoValor > primerValor && quintoValor > segundoValor && quintoValor > tercerValor && quintoValor > cuartoValor)
            {

                mayor5 = quintoValor;

                Console.WriteLine("El quinto numero es el mayor: " + mayor5);

            }
        }
    }
}
