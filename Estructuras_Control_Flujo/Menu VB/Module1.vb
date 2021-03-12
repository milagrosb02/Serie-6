Module Module1

    Enum Menu
        Fisica = 1
        Algebra
        Lengua
        Quimica
        Filosofia
    End Enum

    Sub Main()

        Dim opcion As Menu

        For opcion = 1 To 5

            Console.WriteLine("{0}) {1}", opcion.GetHashCode, opcion.ToString())

        Next

        Console.WriteLine("Ingresar una opcion: ")
        opcion = Console.ReadLine()

        Select Case opcion

            Case Menu.Fisica
                Console.WriteLine("Has elegido Fisica!")

            Case Menu.Algebra
                Console.WriteLine("Has elegido Algebra!")

            Case Menu.Lengua
                Console.WriteLine("Has elegido Lengua!")

            Case Menu.Quimica
                Console.WriteLine("Has elegido Quimica!")

            Case Menu.Filosofia
                Console.WriteLine("Has elegido Filosofia!")

        End Select

    End Sub

End Module
