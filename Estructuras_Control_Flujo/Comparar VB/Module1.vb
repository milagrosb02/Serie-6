Module Module1

    Sub Main()

        Dim primerValor, segundoValor As Double

        Console.WriteLine("Ingresar valor: ")
        primerValor = Console.ReadLine()

        Console.WriteLine("Ingresar otro valor: ")
        segundoValor = Console.ReadLine()


        If primerValor > segundoValor Then
            Console.WriteLine(primerValor & " " & "es el mayor y" & " " & segundoValor & " " & "es el menor.")

        ElseIf segundoValor > primerValor Then
            Console.WriteLine(segundoValor & " " & "es el mayor y" & " " & primerValor & " " & "es el menor.")

        ElseIf primerValor = segundoValor Then
            Console.WriteLine(primerValor & " " & "y" & " " & segundoValor & " " & "son iguales.")
        End If

    End Sub

End Module
