Module Module1

    Sub Main()


        Dim i As Integer = 0
        Dim cont As Integer


        For num As Integer = 1 To 999
            i = 1
            cont = 0
            While cont <= 2 AndAlso i <= num
                If num Mod i = 0 Then
                    cont += 1
                End If

                i += 1
            End While

            If cont = 2 Then
                Console.WriteLine(num)
            End If
        Next

        Console.ReadLine()


    End Sub

End Module
