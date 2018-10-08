
Module Ejercicio11
    Sub Main()
        Dim numero As Integer = 7

        If numero Mod 2 = 0 Or numero Mod 3 = 0 Then
            Console.WriteLine("Múltiplo de 2 o de 3")
        Else
            Console.WriteLine("No es múltiplo de 2 o 3")
        End If

        'Detectar si es múltiplo de 2 o de 3 o de ninguno o de los 2

        If numero Mod 2 = 0 Then
            If numero Mod 3 = 0 Then
                Console.WriteLine("Múltiplo de 2 y de 3")
            Else
                Console.WriteLine("Múltiplo de 2 no de 3")
            End If
        Else
            If numero Mod 3 = 0 Then
                Console.WriteLine("Múltiplo de 3 y no de 2")
            Else
                Console.WriteLine("Ni de 2 ni de 3")
            End If


        End If

        Console.ReadLine()



    End Sub
End Module
