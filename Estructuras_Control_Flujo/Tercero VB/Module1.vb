Module Module1

    Sub Main()

        Dim primerValor, segundoValor, tercerValor, cuartoValor, quintoValor, mayor1, mayor2, mayor3, mayor4, mayor5 As UShort

        Console.WriteLine("Ingresar valor: ")
        primerValor = Console.ReadLine()

        Console.WriteLine("Ingresar otro valor: ")
        segundoValor = Console.ReadLine()

        Console.WriteLine("Ingresar otro valor: ")
        tercerValor = Console.ReadLine()

        Console.WriteLine("Ingresar valor: ")
        cuartoValor = Console.ReadLine()

        Console.WriteLine("Ingresar otro valor: ")
        quintoValor = Console.ReadLine()


        If primerValor > segundoValor And primerValor > tercerValor And primerValor > cuartoValor And primerValor > quintoValor Then

            mayor1 = primerValor

            Console.WriteLine("El primer numero es el mayor: " & mayor1)

        ElseIf segundoValor > primerValor And segundoValor > tercerValor And segundoValor > cuartoValor And segundoValor > quintoValor Then

            mayor2 = segundoValor

            Console.WriteLine("El segundo numero es el mayor: " & mayor2)

        ElseIf tercerValor > primerValor And tercerValor > segundoValor And tercerValor > cuartoValor And tercerValor > quintoValor Then

            mayor3 = tercerValor

            Console.WriteLine("El tercer numero es el mayor: " & mayor3)

        ElseIf cuartoValor > primerValor And cuartoValor > segundoValor And cuartoValor > tercerValor And cuartoValor > quintoValor Then

            mayor4 = cuartoValor

            Console.WriteLine("El cuarto numero es el mayor: " & mayor4)

        ElseIf quintoValor > primerValor And quintoValor > segundoValor And quintoValor > tercerValor And quintoValor > cuartoValor Then

            mayor5 = quintoValor

            Console.WriteLine("El quinto numero es el mayor: " & mayor5)

        End If


    End Sub

End Module
