
Module Ejercicio13
    Sub Main()
        Dim a, b, sumaCuadrados As Double
        Dim h As Double
        Dim cadena As String = "1234567sdfasdlfasdfjklh"
        Dim cadena2 As String = "232"
        a = 5
        Console.WriteLine("Introduzca el valor de b: ")
        b = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine(b)
        'Calculo la suma de los cuadrados de a y b
        sumaCuadrados = a * a + Math.Pow(b, 2)
        sumaCuadrados = a ^ 2 + b ^ 2
        'Calculo la raiz de sumacuadrados
        h = Math.Sqrt(sumaCuadrados)

        Console.WriteLine("La hipotenusa es : " & h)

        'Cáculo raiz cubo
        Dim raizCubo As Double = Math.Pow(10, 1 / 3)

        Console.WriteLine(raizCubo)

        Console.ReadLine()


    End Sub
End Module
