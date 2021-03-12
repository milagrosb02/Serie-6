using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_CS
{
    class Program
    {

        enum Menu
        {
            Salir = 0,
            Fisica,
            Algebra,
            Lengua,
            Quimica,
            Filosofia

        }
        static void Main(string[] args)
        {

            Menu opcion;

            for (opcion = 0; (byte)opcion <= 5; opcion++)

            {

                Console.WriteLine("{0}) {1}", opcion.GetHashCode(), opcion.ToString());

            }

            Console.WriteLine("Ingrese una opcion: ");
            opcion = (Menu)Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {

                case Menu.Fisica:

                    Console.WriteLine("Has elegido Fisica!");

                    break;



                case Menu.Algebra:

                    Console.WriteLine("Has elegido Algebra!");

                    break;


                case Menu.Lengua:

                    Console.WriteLine("Has elegido Lengua!");

                    break;


                case Menu.Quimica:

                    Console.WriteLine("Has elegido Quimica!");

                    break;


                case Menu.Filosofia:

                    Console.WriteLine("Has elegido Filosofia!");

                    break;
            }
        }
    }
}
