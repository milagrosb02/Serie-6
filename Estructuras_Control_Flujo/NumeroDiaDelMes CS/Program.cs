using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroDiaDelMes_CS
{
    class Program
    {
        enum Meses
        {
            Enero = 1,
            Febrero,
            Marzo,
            Abril,
            Mayo,
            Junio,
            Julio,
            Agosto,
            Septiembre,
            Octubre,
            Noviembre,
            Diciembre
        }
        static void Main(string[] args)
        {

            Meses mes;

            double anio;

            Console.WriteLine("Ingresar mes: ");

            mes = (Meses)Convert.ToByte(Console.ReadLine());

            switch(mes)
            {


                    case Meses.Enero:

                    Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Enero);

                    break;


                    case Meses.Marzo:

                    Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Marzo);

                    break;


                    case Meses.Abril:

                    Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Abril);

                    break;


                    case Meses.Mayo:

                    Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Mayo);

                    break;


                    case Meses.Junio:

                    Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Junio);

                    break;


                    case Meses.Julio:

                    Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Julio);

                    break;


                    case Meses.Agosto:

                    Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Agosto);

                    break;


                    case Meses.Septiembre:

                    Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Septiembre);

                    break;


                    case Meses.Octubre:

                    Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Octubre);

                    break;


                    case Meses.Noviembre:

                    Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Noviembre);

                    break;


                    case Meses.Diciembre:

                    Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Diciembre);

                    break;


                    case Meses.Febrero:

                    Console.WriteLine("Ingresar ano: ");
                    anio = Convert.ToDouble(Console.ReadLine());


                    if ((anio % 4 == 0 & anio % 100 != 0 | anio % 400 == 0))
                        Console.WriteLine("El mes {0} tiene 29 dias y es bisiesto", Meses.Febrero);
                    else
                        Console.WriteLine("El mes {0} tiene 28 dias y no es bisiesto", Meses.Febrero);
                    break;

            }

        }
    }
}
