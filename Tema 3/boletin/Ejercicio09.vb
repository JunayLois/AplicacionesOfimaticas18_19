Module Ejercicio09
    Sub Main()
        Dim a, b, potencia, menor, mayor As Integer
        a = 3
        b = 4

        If a < b Then
            potencia = Convert.ToInt32(Math.Pow(b, a))
            menor = a
            mayor = b
        Else
            potencia = Convert.ToInt32(Math.Pow(a, b))
            menor = b
            mayor = a
        End If
        Console.WriteLine(mayor & " elevado a " & menor & " = " & potencia)
        Console.ReadLine()
    End Sub
End Module
