Option Strict On
Module Module1

    Sub Main()
        'Clase Math: Librería con funciones matemáticas
        'Función pow(base , potencia) 

        Dim x As Byte = 7
        'Calcular x a la cuarta
        'Dim resultado As Integer = x * x * x * x
        Dim resultado As Integer = Convert.ToInt32(Math.Pow(x, 4))

        'Calcular la raiz cuadrada de un número
        Dim raiz As Double = Math.Sqrt(13)

        Console.WriteLine(raiz)
        'Funciones para redondear
        Console.WriteLine("Valor raiz redondeado al entero superior mas cercano : " & Math.Ceiling(raiz))
        Dim raizBaja As Integer = Convert.ToInt32(Math.Floor(raiz))
        Console.WriteLine("Valor raiz a redondeado la baja " & raizBaja)
        raiz = 3.31234567
        Dim raizRedondeada As Integer = Convert.ToInt32(Math.Round(raiz))
        Console.WriteLine("Raiz correctamente redondeada : " & raizRedondeada)

        'Mostrar la raiz con 2 decimales
        Console.WriteLine("La raiz con dos decimales : " & Math.Round(raiz, 2))

        'Calcular el maximo y el minimo entre dos numeros
        Dim x1 As Byte = 10
        Dim y As Byte = 5

        Dim max As Byte = Math.Max(x1, y)
        Dim min As Byte = Math.Min(x1, y)


        Console.ReadLine()
    End Sub

End Module
