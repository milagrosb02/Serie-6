Module Module1

    Sub Main()

        Dim tamano As Integer

        Console.WriteLine("Ingresar tamanio del angulo: ")

        tamano = Console.ReadLine()


        Select Case tamano
            Case 1 To 89
                Console.WriteLine("Es un angulo agudo.")

            Case 90
                Console.WriteLine("Es un angulo recto. ")

            Case 91 To 179
                Console.WriteLine("Es un angulo obtuso. ")

            Case 180
                Console.WriteLine("Es un angulo llano. ")

            Case 181 To 359
                Console.WriteLine("Es un angulo concavo.")

            Case Else
                Console.WriteLine("Error.")
        End Select


    End Sub

End Module
