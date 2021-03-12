Module Module1

    Enum Dias

        Domingo = 1
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado

    End Enum

    Sub Main()

        Dim diaSemana As Dias

        Console.WriteLine("Ingresar un valor numerico: ")

        diaSemana = Console.ReadLine()


        Select Case diaSemana
            Case 1

                Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Domingo)

            Case 2

                Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Lunes)

            Case 3

                Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Martes)

            Case 4

                Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Miercoles)

            Case 5

                Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Jueves)

            Case 6

                Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Viernes)

            Case 7

                Console.WriteLine("Dia {0} es {1}", diaSemana.GetHashCode(), Dias.Sabado)

            Case Else

                Console.WriteLine("Valor invalido!")

        End Select


    End Sub

End Module
