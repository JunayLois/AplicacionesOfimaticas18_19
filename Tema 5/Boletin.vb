Option Strict On
Module Module1

    Sub Main()

        Dim ejercicio As Integer = 1000
        Console.ForegroundColor = ConsoleColor.White
        'While ejercicio = 0
        '    Console.WriteLine("Código inaccesible")
        'End While

        Do


            Console.WriteLine("Escoja el ejercicio que quiere ejecutar")
            Console.WriteLine("1. Ejercicio 1")
            Console.WriteLine("5. Ejercicio 5")
            Console.WriteLine("7. Ejercicio 7")
            ejercicio = Convert.ToInt32(Console.ReadLine())
            Console.Clear()
            Select Case ejercicio
                Case 1
                    Console.WriteLine("Apartado a.")
                    Dim i As Integer = 1

                    While i <= 11
                        Console.Write(i & " ")
                        i += 2

                    End While
                    Console.WriteLine()
                    Console.WriteLine("Apartado b.")

                    i = 2
                    While i <= 10
                        Console.Write(i & " ")
                        i += 2
                    End While
                    Console.WriteLine()
                    Console.WriteLine("Apartado c.")

                    i = 5

                    While i <= 25
                        Console.Write(i & " ")
                        i += 5
                    End While

                    Console.WriteLine()
                    Console.WriteLine("Apartado c.")

                    i = 100

                    While i >= 50
                        Console.Write(i & " ")
                        i -= 10
                    End While
                    Console.WriteLine()

                Case 5
                    Dim i As Integer = 320

                    While i >= 160
                        Console.Write(i & " ")
                        i -= 20
                    End While

                Case 6
                    For i As Integer = 5 To 100 Step 1
                        Console.Write(i & " ")
                    Next
                Case 7
                    Dim numero As Integer
                    Console.WriteLine("Introduzca un número")
                    numero = Convert.ToInt32(Console.ReadLine())

                    Dim i As Integer = 1

                    For i = 1 To 10 Step 1
                        Console.WriteLine(numero & " * " & i & " = " & numero * i)
                    Next

                Case 8
                    Dim n As Integer = 9
                    'Mostrar el cuadrado y el cubo de los 5 primeros numeros 
                    'a partir de n
                    For i As Integer = n + 1 To n + 5 Step 1
                        Console.WriteLine(i & " " & i * i & " " & Math.Pow(i, 3))
                    Next

                Case 9

                    For j As Double = 16 To 0 Step -2.5
                        Console.WriteLine(j & "  " & Math.Sqrt(j))
                    Next

                Case 10
                    Dim n, i, contador As Integer
                    Dim suma As Integer = 0

                    Do
                        Console.WriteLine("Introduce un número positivo")
                        n = Convert.ToInt32(Console.ReadLine())
                        contador += 1

                    Loop While n < 0 And contador < 3

                    If contador = 3 Then
                        Console.WriteLine("Dejalo , meter números positivos no es lo tuyo")
                    Else
                        i = 1

                        While i <= n
                            suma += i
                            i += 1
                        End While
                        Console.WriteLine("La suma es : " & suma)
                    End If

            End Select

            'Código copyright by Cousiño & Davila 
            Console.ReadLine()
            Console.Clear()

        Loop While ejercicio < 20









    End Sub

End Module
