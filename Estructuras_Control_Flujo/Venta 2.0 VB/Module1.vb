Module Module1

    Sub Main()

        Dim cantidad As Double

        Dim precioU, descuento, subtotal, montoDescontado, total As Decimal

        Dim porcentaje As String

        descuento = 0


        Console.WriteLine("Ingresar cantidad de productos a comprar: ")

        cantidad = Console.ReadLine()

        Console.WriteLine("Ingresar precio unitario: ")

        precioU = Console.ReadLine()


        Select Case cantidad
            Case 10 To 50

                descuento = 0.5

                porcentaje = "Descuento de 5%"

            Case 51 To 250

                descuento = 0.1

                porcentaje = "Descuento de 10%"

            Case >= 251

                descuento = 0.2

                porcentaje = "Descuento de 20%"

        End Select

        subtotal = cantidad * precioU

        montoDescontado = precioU - descuento

        total = subtotal - montoDescontado

        Console.WriteLine("El subtotal es de: " & subtotal)

        Console.WriteLine("Porcentaje aplicado: " & porcentaje)

        Console.WriteLine("Monto descontado: " & montoDescontado)

        Console.WriteLine("El total es de: " & total)

    End Sub

End Module
