using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreDia_CS
{
    class Program
    {
        enum Dias 
        {
            Domingo = 1,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        }

        static void Main(string[] args)
        {

            Dias diaSemana;

            Console.WriteLine("Ingresar un valor numerico: ");

            diaSemana = (Dias)Convert.ToInt32(Console.ReadLine());


            switch (diaSemana)

            {
                case (Dias)1:

                    Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Domingo);

                    break;

                case (Dias)2:

                    Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Lunes);

                    break;

                case (Dias)3:

                    Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Martes);

                    break;

                case (Dias)4:

                    Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Miercoles);

                    break;

                case (Dias)5:

                    Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Jueves);

                    break;

                case (Dias)6:

                    Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Viernes);

                    break;

                case (Dias)7:

                    Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Sabado);

                    break;

                default:
                    Console.WriteLine("Valor invalido!");
                    break;
            }



        }
    }
}
