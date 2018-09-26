Module Ejercicio09
    Sub Main()
        Dim x As Integer = 9
        Dim y As Integer = 2
        Dim copiaX As Integer

        'Intercambiar los valores de las variables x e y
        copiaX = x
        x = y
        y = copiaX


        Console.WriteLine("x = " & x)
        Console.WriteLine("y = " & y)
        Console.ReadLine()

    End Sub
End Module
