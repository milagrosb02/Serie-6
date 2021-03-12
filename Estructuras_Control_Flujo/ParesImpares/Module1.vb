Module Module1

    Sub Main()

        Dim valor, contPar, contImpar As UShort

        contPar = 0

        contImpar = 0

        Console.WriteLine("Ingresar un valor cualquiera: ")

        valor = Console.ReadLine()    ' Leer primero valor


        Do While valor <> 0

            If (valor Mod 2) <> 0 Then

                contImpar += 1

            Else

                contPar += 1

            End If


            Console.WriteLine("Ingresar un valor cualquiera: ")

            valor = Console.ReadLine()  ' Leer valor siguiente

        Loop


        Console.WriteLine("Cantidad de impares: " & contImpar)

        Console.WriteLine("Cantidad de pares: " & contPar)


    End Sub

End Module
