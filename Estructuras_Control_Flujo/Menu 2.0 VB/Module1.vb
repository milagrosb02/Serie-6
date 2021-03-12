Module Module1
    Enum Menu
        Salir = 0
        Fisica
        Algebra
        Lengua
        Quimica
        Filosofia
    End Enum
    Sub Main()

        Dim opcion As Menu

        For opcion = 0 To 4

            Console.WriteLine("{0}) {1}", opcion.GetHashCode, opcion.ToString())

        Next



        Do While opcion <> 0

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


        Loop




    End Sub

End Module
