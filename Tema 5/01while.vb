Option Strict On
Module Module1

    Sub Main()
        'Mostrar por pantalla numeros del 1 al 100

        Dim i As Integer = 1

        'while , for

        While i <= 50
            Console.Write(i & " ")

            i = i + 1
        End While
        Console.WriteLine("Salí del bucle. Bieeeeen!!!!")

        Dim matriz() As Integer = {2, 5, 4, 3, 1, 1, 6, 8, 4, 2, 2}

        Console.WriteLine("Datos guardados en la matriz")


        i = 0

        'Ejercicio 1: Mostrar los números pares de la matriz
        While i < 11

            If matriz(i) Mod 2 = 0 Then
                Console.Write(matriz(i) & " ")

            End If
            i = i + 1

        End While
        'Ejercicio 2: Calcular la suma de los n primeros números
        'Ejemplo : Si n = 10 , suma = 1 + 2 +3 +4 +5 +6 +7 +8 +9 +10

        Dim n As Integer = 8000
        Dim suma As Integer = 0
        i = 1

        '  suma = 1 + 2 + 3 + 4 + 5 + 6 +7 + ..

        'i = 1 --> suma = 0 + 1
        'i = 2 --> suma = 1 + 2
        'i = 3 --> suma = 3 + 3
        'i = 4 --> suma = 6 + 4
        '...   --> suma = suma + i

        Dim x As Integer = 1
        x = x + 1


        While i <= n

            suma = suma + i
            i = i + 1
        End While

        i = 1
        Dim sumaCuadrados As Double = 0
        'Calcular : 1^2 + 2^2 + 3^2 + 4^2 + ... n^2
        While i <= n

            sumaCuadrados = sumaCuadrados + i * i
            i = i + 1
        End While

        Console.WriteLine(sumaCuadrados)







        Console.ReadLine()
    End Sub

End Module
