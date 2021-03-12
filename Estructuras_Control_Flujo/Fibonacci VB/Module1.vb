Module Module1

    Sub Main()

        Dim i, a, b, c As Integer

        a = 0

        c = 1

        For i = 0 To 20

            b = a + c

            Console.WriteLine(b)

            a = c

            c = b

        Next

    End Sub

End Module
