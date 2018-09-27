Option Strict On
Module Ejercicio07
    Sub Main()
        Dim gradosFahrenheit, gradosCelsius As Double

        ''Solicitar grados celsius
        Console.WriteLine("Introduzca grados celsius : ")
        gradosCelsius = Convert.ToDouble(Console.ReadLine())


        gradosFahrenheit = (9 / 5) * gradosCelsius + 32

        Console.WriteLine(gradosCelsius & " celsius = " & gradosFahrenheit & " fahrenheit")
        Console.ReadLine()



    End Sub
End Module
