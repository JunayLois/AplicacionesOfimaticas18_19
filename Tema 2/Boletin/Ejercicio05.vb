Option Strict On

Module Ejercicio05

    Sub Main()
        Dim precioUnidad As Double = 5.75
        Dim cantidad As Short = 1000
        Dim precioFinal As Single = Convert.ToSingle(precioUnidad * cantidad)
        Dim descuento As Byte = 15
        Dim precioConDescuento As Single

        Console.WriteLine("Precio final : " & precioFinal)

        ' Descuento --> precioConDescuento = (precioFinal * 15) / 100
        ' Precio con descuento --> precioConDescuento = precioFinal - Convert.ToSingle(precioFinal * 0.15)

        precioConDescuento = Convert.ToSingle(precioFinal * 0.85)
        Console.WriteLine("Aplicando un " & descuento & " % " & precioConDescuento)
        Console.ReadLine()

    End Sub
End Module
