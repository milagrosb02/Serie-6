Module Module1

    Enum Meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum

    Sub Main()

        Dim mes As Meses

        Dim anio As Double

        Console.WriteLine("Ingresar mes: ")
        mes = Console.ReadLine()

        Select Case mes
            Case Meses.Enero
                Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Enero)

            Case Meses.Marzo
                Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Marzo)

            Case Meses.Abril
                Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Abril)

            Case Meses.Mayo
                Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Mayo)

            Case Meses.Junio
                Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Junio)

            Case Meses.Julio
                Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Julio)

            Case Meses.Agosto
                Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Agosto)

            Case Meses.Septiembre
                Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Septiembre)

            Case Meses.Octubre
                Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Octubre)

            Case Meses.Noviembre
                Console.WriteLine("El mes {0} tiene 30 dias ", Meses.Noviembre)

            Case Meses.Diciembre
                Console.WriteLine("El mes {0} tiene 31 dias ", Meses.Diciembre)


            Case Meses.Febrero
                Console.WriteLine("Ingresar ano: ")
                anio = Console.ReadLine()

                If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then
                    Console.WriteLine("El mes {0} tiene 29 dias y es bisiesto", Meses.Febrero)
                Else
                    Console.WriteLine("El mes {0} tiene 28 dias y no es bisiesto", Meses.Febrero)
                End If

        End Select

    End Sub

End Module
