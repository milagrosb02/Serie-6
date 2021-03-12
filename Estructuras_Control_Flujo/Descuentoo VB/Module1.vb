Module Module1

    Sub Main()

        Dim cantidad, precioU, descuento, subtotal, montoDescontado, total As Decimal

        Dim porcentaje As String

        porcentaje = ""




        Do Until cantidad = 0

            Console.WriteLine("Ingresar cantidad a comprar: ")

            cantidad = Console.ReadLine()

            Console.WriteLine("Ingresar precio unitario: ")


            precioU = Console.ReadLine()

            Console.WriteLine("El subtotal es de: " & subtotal)


            If cantidad >= 10 And cantidad <= 50 Then

                descuento = 0.5

                porcentaje = "Descuento de 5%"

                subtotal = cantidad * precioU

                montoDescontado = precioU - descuento

                total = subtotal - montoDescontado


            ElseIf cantidad >= 51 And cantidad <= 250 Then

                descuento = 0.1

                porcentaje = "Descuento de 10%"

                subtotal = cantidad * precioU

                montoDescontado = precioU - descuento

                total = subtotal - montoDescontado



            ElseIf cantidad >= 251 Then

                descuento = 0.2

                porcentaje = "Descuento de 20%"

                subtotal = cantidad * precioU

                montoDescontado = precioU - descuento

                total = subtotal - montoDescontado

            End If


        Loop



        Console.WriteLine("Porcentaje aplicado: " & porcentaje)

        Console.WriteLine("Monto descontado: " & montoDescontado)

        Console.WriteLine("El total es de: " & total)






    End Sub

End Module
