Module Module1

    Sub Main()

        Dim primerValor, segundoValor, tercerValor, menor1, menor2, menor3 As Double

        Console.WriteLine("Ingresar valor: ")
        primerValor = Console.ReadLine()

        Console.WriteLine("Ingresar otro valor: ")
        segundoValor = Console.ReadLine()

        Console.WriteLine("Ingresar otro valor: ")
        tercerValor = Console.ReadLine()

        If primerValor < segundoValor And primerValor < tercerValor Then

            menor1 = primerValor

            Console.WriteLine("El menor es " & menor1)

        ElseIf segundoValor < tercerValor And segundoValor < primerValor Then

            menor2 = segundoValor

            Console.WriteLine("El menor es " & menor2)

        ElseIf tercerValor < segundoValor And tercerValor < primerValor Then

            menor3 = tercerValor

            Console.WriteLine("El menor es " & menor3)

        End If



    End Sub

End Module
