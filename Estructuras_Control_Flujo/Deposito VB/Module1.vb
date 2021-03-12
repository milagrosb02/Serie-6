Module Module1

    Sub Main()

        Dim capitalInicial, capital, meses, interes, saldo, totalIntereses As Decimal

        Const tasa As Decimal = 0.36


        Console.WriteLine("Ingresar un capital inicial: ")

        capitalInicial = Console.ReadLine()

        Console.WriteLine("Ingresar una cantidad de meses: ")

        meses = Console.ReadLine()

        Console.WriteLine("MES | CAPITAL | INTERES | SALDO")


        For x = 1 To meses

            capital += capitalInicial

            interes = capital * (tasa / 12)

            saldo = capital + interes

            totalIntereses += interes

            Console.WriteLine(x & "      " & capital & "     " & interes & "    " & saldo)


        Next

        Console.WriteLine("El interes ganado es de: " & totalIntereses)

    End Sub

End Module
