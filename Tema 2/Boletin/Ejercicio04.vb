Option Strict On
Module Ejercicio04

    Sub Main()
        Dim radio, area, longitud, volumen As Double
        Const PI As Double = 3.141516
        radio = 5

        longitud = 2 * Math.PI * radio

        area = Math.PI * Math.Pow(radio, 2)
        area = Math.Round(area, 2)

        volumen = Math.Round((4 / 3) * Math.PI * Math.Pow(radio, 3), 2)

        Console.WriteLine("Longitud : " & Math.Round(longitud, 2) & vbNewLine & "Area : " & area)
        Console.WriteLine("Volumen : " & volumen)

        Console.WriteLine(longitud)

        Console.ReadLine()



    End Sub

End Module
