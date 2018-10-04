Module Module1

    Sub Main()
        'Ejercicio
        Dim n1 As Double = 4
        Dim n2 As Double = 2
        Dim suma As Double = n1 + n2

        Dim positivo As Boolean = suma > 0

        If positivo Then
            Console.WriteLine("Raiz de " & suma & " : " & Math.Sqrt(suma))
        Else
            Console.WriteLine("No existe raiz de número negativo")
        End If
        Console.ReadLine()


    End Sub

End Module
