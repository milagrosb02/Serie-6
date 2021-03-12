using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angulo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamano;

            Console.WriteLine("Ingresar tamanio del angulo: ");

            tamano = Convert.ToInt32(Console.ReadLine());

            switch (tamano)
            {
                case var @case when 1 <= @case && @case <= 89:
                    {
                        Console.WriteLine("Es un angulo agudo. ");

                        break;

                    }

                case 90:
                    {
                        Console.WriteLine("Es un angulo recto. ");

                        break;
                    }

                case var @case when 91 <= @case && @case <= 179:
                    {
                        Console.WriteLine("Es un angulo obtuso. ");

                        break;

                    }

                case 180:
                    {
                        Console.WriteLine("Es un angulo obtuso. ");

                        break;
                    }

                case var @case when 181 <= @case && @case <= 359:
                    {
                        Console.WriteLine("Es un angulo concavo. ");

                        break;

                    }

            }

                
        }
    }
}
