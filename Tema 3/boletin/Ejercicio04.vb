Module Ejercicio4
    Sub Main()

        Dim a, b, c, d, menor As Integer
        a = -3
        b = -10
        c = 0
        d = 5

        If a > b Then
            menor = b
        Else
            menor = a
        End If

        If menor > c Then
            menor = c
        End If

        If menor > d Then
            menor = d
        End If

        Console.WriteLine("El más pequeño es : " & menor)

        Console.ReadLine()

    End Sub
End Module
