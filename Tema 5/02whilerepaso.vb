Option Strict On
Module Module1

    Sub Main()

        'Ejercicio 1 : Mostrar por pantalla los n primeros números
        Dim n As Integer = 25

        Dim i As Integer = 1

        While i <= n
            Console.Write(i & " ")
            i = i + 1
        End While

        'Ejercicio 2: Mostrar por pantalla los números
        'múltiplos de 3 y 7 que sean inferiores a n

        n = 1000

        i = 21
        Console.WriteLine()
        Console.WriteLine("Múltiplos de 3 y 7")
        While i <= n
            If i Mod 3 = 0 And i Mod 7 = 0 Then
                Console.Write(i & " ")

            End If

            i += 1

        End While

        'Ejercicio 3 : Calcular la suma de los n primeros números
        n = 50
        Dim suma As Integer = 0
        i = 1

        While i <= n
            suma = suma + i
            i = i + 1
        End While

        Console.WriteLine("La suma es : " & suma)

        'Ejercicio 4 : Mostrar por pantalla los valores
        'almacenados en una matriz
        Dim matriz(3) As Integer
        matriz(0) = 9
        matriz(1) = 3
        matriz(2) = 9
        matriz(3) = 1
        Console.WriteLine()
        Dim matriz2() As Integer = {2, 3, 4, 5, 1, 3, 4, 1, -9, 4}
        Console.WriteLine("Ejercicio 4")
        Console.WriteLine("Valores almacenados en una matriz")
        i = 0
        While i < 10
            Console.Write(matriz2(i) & " ")
            i += 1
        End While
        Console.WriteLine()
        'Ejercicio 5 : Llenar una matriz con valores aleatorios

        Dim matrizAleatoria(24) As Integer
        Dim aleatorio As Random = New Random()
        Console.WriteLine("Matriz de valores aleatorios")
        i = 0
        While i < 25
            matrizAleatoria(i) = aleatorio.Next(1, 100)

            i += 1
        End While

        'Bucle para mostrar valores de una matriz

        i = 0
        While i < 25
            Console.Write(matrizAleatoria(i) & " ")
            i += 1
        End While
        Console.ReadLine()
    End Sub

End Module
