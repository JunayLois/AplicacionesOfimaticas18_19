Module Ejercicio12
    Sub Main()
        Dim precio, precioDescuento As Double
        precio = 120

        If precio < 100 Then
            'precio = precio - 0.1 * precio
            precioDescuento = 0.9 * precio
        Else
            precioDescuento = 0.85 * precio
        End If

        Console.WriteLine("Precio final " & precioDescuento)

    End Sub
End Module
