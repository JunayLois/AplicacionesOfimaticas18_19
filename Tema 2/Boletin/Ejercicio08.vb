Option Strict On
Module Ejercicio08
    Sub Main()
        Dim p, v, n, t As Double
        Const R As Double = 0.082

        n = 10000

        'Leo el volumen
        Console.WriteLine("Dime los litros : ")
        v = Convert.ToDouble(Console.ReadLine())

        'Leo la temperatura
        Console.WriteLine("Dime los grados : ")
        t = Convert.ToDouble(Console.ReadLine())

        p = (n * R * t) / v


        Console.WriteLine("Con un volumen de " & v &
                          " litros y una temperatura de " & t & " kelvins ," &
                           n & " moles de un gas ideal , están a una presión de " & p &
                          " atmosferas")
        Console.ReadLine()


    End Sub
End Module
