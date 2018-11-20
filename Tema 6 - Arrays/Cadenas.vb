
Module Cadenas
    Sub Main()

        Dim dnis(9) As String
        dnis(0) = "12345678R"
        dnis(1) = "345671230S"

        Console.WriteLine("Introduzca su dni")
        Dim dni As String = Console.ReadLine()
        'Guardar el dni en la primera posición vacía
        Dim i As Integer
        Dim guardado As Boolean = False
        For i = 0 To dnis.Length - 1 Step 1
            If dnis(i) Is Nothing Then
                dnis(i) = dni
                guardado = True
                Exit For
            End If

        Next

        If guardado = False Then
            ReDim Preserve dnis(90)
        End If

        Console.WriteLine("Fin de la matriz")
        Console.ReadLine()
    End Sub
End Module
