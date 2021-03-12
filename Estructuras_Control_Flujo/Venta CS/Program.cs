using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            //double cantidad;

            decimal cantidad, precioU, descuento, subtotal, montoDescontado, total;

            string porcentaje;

            porcentaje = "";

            descuento = 0;

            Console.WriteLine("Ingresar cantidad de productos a comprar: ");

            cantidad = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresar precio unitario: ");

            precioU = Convert.ToDecimal(Console.ReadLine());

            
            if(cantidad >= 10 && cantidad <= 50)
            {

                descuento = 0.5M;

                porcentaje = "Descuento de 5%";
            }

            if(cantidad >= 51 && cantidad <= 250)
            {

                descuento = 0.1M;

                porcentaje = "Descuento de 10%";
            }

            if(cantidad >= 251)
            {

                descuento = 0.2M;

                porcentaje = "Descuento de 20%";

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
