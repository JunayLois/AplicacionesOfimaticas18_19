﻿Option Strict On
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
            Console.WriteLine("12 o 13. Numero perfecro")
            Console.WriteLine("18. Detectar numero primo")
            Console.WriteLine("22. Bucles anidados")
            Console.WriteLine("24. Detector números primos or debajo de n")
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

                Case 12, 13
                    Dim numero As Integer
                    Dim suma As Integer = 0

                    Dim i As Integer
                    Console.WriteLine("Introduce un número")
                    numero = Convert.ToInt32(Console.ReadLine())

                    Console.WriteLine()
                    While i <= numero / 2
                        If numero Mod i = 0 Then
                            suma = suma + i
                        End If
                        i += 1
                    End While

                    Console.WriteLine("12. La suma es : " & suma)
                    'Ejercicio 13: Un numero es perfecto si es igual
                    'a la suma de sus divisores sin contar el propio numero
                    If numero = suma Then
                        Console.WriteLine("Es perfecto")
                    Else
                        Console.WriteLine("No es perfecto")
                    End If
                Case 18
                    'Detectar si un número es primo
                    'Es primo si solo es divisible entre 1 y el propio numero
                    Dim numero As Integer = 0
                    Dim contadorLectura As Integer = 0
                    Do
                        Console.WriteLine("Intro un numero")
                        numero = Convert.ToInt32(Console.ReadLine())
                        contadorLectura += 1
                    Loop While numero < 0 And contadorLectura < 3

                    If contadorLectura = 3 Then
                        Console.WriteLine("Se te acabaron las vidas")
                    Else
                        Dim primo As Boolean = True
                        Dim contador As Integer = 0
                        For i As Integer = 2 To Convert.ToInt32(numero / 2) Step 1
                            If numero Mod i = 0 Then

                                primo = False
                                Exit For

                            End If
                        Next

                        If primo = True Then
                            Console.WriteLine("Numero primo")
                        Else
                            Console.WriteLine("Numero no primo")
                        End If
                    End If


                    '30 de octubre de 2018 a las 13:55
                    'Los alumnos de 1º de GMI se compromenten a no 
                    'escribir un else dentro de un bucle en aquellos algoritmos
                    'que impliquen búsquedas de cualquier tipo lease , divisores
                    'ocurrencias en una matriz etc...

                Case 22
                    Console.WriteLine("Apartado a)")
                    Dim contador As Integer = 6
                    For i As Integer = 6 To 0 Step -1

                        For j As Integer = 0 To i Step 1
                            Console.Write("*")
                        Next

                        Console.WriteLine()

                    Next

                    Console.WriteLine("Apartado b)")

                    For i As Integer = 0 To 6 Step 1

                        For j As Integer = 0 To i Step 1
                            Console.Write("*")
                        Next

                        Console.WriteLine()

                    Next

                    Console.WriteLine("Apartado c)")

                    For i As Integer = 0 To 6 Step 1

                        For j As Integer = 0 To i Step 1
                            Console.Write("*")
                        Next

                        Console.WriteLine()

                    Next

                    For i As Integer = 5 To 0 Step -1

                        For j As Integer = 0 To i Step 1
                            Console.Write("*")
                        Next

                        Console.WriteLine()

                    Next

                    Console.WriteLine("Apartado D")
                    Dim k, z As Integer

                    k = 7
                    z = 1
                    While k > 0
                        z = 1
                        While z <= k
                            Console.Write(z & " ")
                            z += 1
                        End While
                        k -= 1
                        Console.WriteLine()
                    End While
                Case 23
                    Dim numero As Integer = 10000
                    'Perfecto = suma de sus divisores menos el propio numero
                    Dim suma As Integer = 0

                    For i As Integer = 4 To numero Step 1
                        suma = 0
                        For j As Integer = 1 To Convert.ToInt32(i / 2) Step 1
                            If i Mod j = 0 Then
                                suma = suma + j
                            End If
                        Next

                        If suma = i Then
                            Console.WriteLine(i & " es perfecto.")
                        End If


                    Next







                Case 24
                    Dim numero As Long
                    Console.WriteLine("Introduce numero : ")
                    numero = Convert.ToInt64(Console.ReadLine())

                    Dim contador As Long = 0
                    For j As Long = 3 To numero Step 1
                        contador = 0
                        For i As Long = 2 To j - 1 Step 1
                            If j Mod i = 0 Then
                                contador += 1
                                Exit For
                            End If
                        Next

                        If contador = 0 Then
                            Console.WriteLine(j & " es primo")
                        End If
                    Next

                Case 25
                    Dim aleatorio As Random = New Random()
                    Dim contadorPositivos As Integer = 0
                    Dim contadorNegativos As Integer = 0
                    Dim porcentajePositivos As Double = 0
                    Dim porcentajeNegativos As Double = 0
                    Dim c1 As Integer = 0
                    Dim c2 As Integer = 0
                    Dim c3 As Integer = 0
                    Dim c4 As Integer = 0
                    Dim c5 As Integer = 0
                    Dim c_1 As Integer = 0
                    Dim c_2 As Integer = 0
                    Dim c_3 As Integer = 0
                    Dim c_4 As Integer = 0
                    Dim c_5 As Integer = 0
                    Dim c0 As Integer = 0

                    'contadorNegativos = 0
                    'contadorPositivos = 0
                    'porcentajeNegativos = 0
                    'porcentajePositivos = 0
                    For j As Integer = 0 To 9 Step 1
                        For i As Integer = 0 To 8 Step 1
                            Dim numero As Integer = aleatorio.Next(-5, 6)
                            Console.Write(numero & " ")
                            If numero >= 0 Then
                                contadorPositivos += 1
                            Else
                                contadorNegativos += 1
                            End If

                            Select Case numero
                                Case 0
                                    c0 += 1
                                Case 1
                                    c1 += 1
                                Case 2
                                    c2 += 1
                                Case 3
                                    c3 += 1
                                Case 4
                                    c4 += 1
                                Case 5
                                    c5 += 1
                                Case -1
                                    c_1 += 1
                                Case -2
                                    c_2 += 1
                                Case -3
                                    c_3 += 1
                                Case -4
                                    c_4 += 1
                                Case -5
                                    c_5 += 1

                            End Select

                        Next
                        Console.WriteLine()
                    Next

                    porcentajeNegativos = (contadorNegativos / 90) * 100
                    porcentajePositivos = (contadorPositivos / 90) * 100

                    Console.WriteLine("Hay " & contadorPositivos & " numeros positivo , que es un " & porcentajePositivos & "%")
                    Console.WriteLine("Hay " & contadorNegativos & " numeros negativos , que es un " & porcentajeNegativos & "%")

                    Dim moda As Integer = 0

                    'Copyright Santomé & Cousiño
                    Dim maximo As Integer = Math.Max(c1, Math.Max(c2, Math.Max(c3, Math.Max(c4, Math.Max(c5, Math.Max(c0, Math.Max(c_1, Math.Max(c_2, Math.Max(c_3, Math.Max(c_4, c_5))))))))))

                    If (maximo = c0) Then
                        moda = 0
                    ElseIf maximo = c1 Then
                        moda = 1
                    ElseIf maximo = c2 Then
                        moda = 2
                    ElseIf maximo = c3 Then
                        moda = 3
                    ElseIf maximo = c4 Then
                        moda = 4
                    ElseIf maximo = c5 Then
                        moda = 5
                    ElseIf maximo = c_1 Then
                        moda = -1
                    ElseIf maximo = c_2 Then
                        moda = -2
                    ElseIf maximo = c_3 Then
                        moda = -3
                    ElseIf maximo = c_4 Then
                        moda = -4
                    Else
                        moda = -5

                    End If
                    Console.WriteLine("El 1 aparece " & c1 & " veces")
                    Console.WriteLine("El 2 aparece " & c2 & " veces")
                    Console.WriteLine("El 3 aparece " & c3 & " veces")
                    Console.WriteLine("El 4 aparece " & c4 & " veces")
                    Console.WriteLine("El 5 aparece " & c5 & " veces")
                    Console.WriteLine("El 0 aparece " & c0 & " veces")
                    Console.WriteLine("El -1 aparece " & c_1 & " veces")
                    Console.WriteLine("El -2 aparece " & c_2 & " veces")
                    Console.WriteLine("El -3 aparece " & c_3 & " veces")
                    Console.WriteLine("El -4 aparece " & c_4 & " veces")
                    Console.WriteLine("El -5 aparece " & c_5 & " veces")
                    Console.WriteLine("El valor más repetido es " & moda)



            End Select

            'Código copyright by Cousiño & Davila 
            Console.ReadLine()
            Console.Clear()

        Loop While ejercicio < 26


    End Sub

End Module
