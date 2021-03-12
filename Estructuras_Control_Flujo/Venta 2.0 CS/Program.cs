using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_2._0_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            decimal  precioU, descuento, subtotal, montoDescontado, total;

            string porcentaje;

            porcentaje = "";

            descuento = 0;

            Console.WriteLine("Ingresar cantidad de productos a comprar: ");

            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar precio unitario: ");

            precioU = Convert.ToDecimal(Console.ReadLine());


            switch(cantidad)
            {


                   case var @case when 10 >= @case && @case <= 50:

                    {

                        descuento = 0.5M;

                        porcentaje = "Descuento de 5%";

                        break;

                    }

                    case var @case when 51 >= @case && @case <=250:

                    {

                        descuento = 0.1M;

                        porcentaje = "Descuento de 10%";

                        break;

                    }

                case >= 251:
                    {
                        descuento = 0.2M;

                        porcentaje = "Descuento de 20%";

                        break;
                    }


            }

            subtotal = Convert.ToDecimal(cantidad * precioU);

            montoDescontado = precioU - descuento;

            total = subtotal - montoDescontado;

            Console.WriteLine("El subtotal es de: " + subtotal);

            Console.WriteLine("Porcentaje aplicado: " + porcentaje);

            Console.WriteLine("Monto descontado: " + montoDescontado);

            Console.WriteLine("El total es de: " + total);
        }
    }
}
