Option Strict On
Module Module1

    Sub Main()
        Dim ejercicio As Integer

        Do
            Console.Clear()
            Console.WriteLine("1. Ejercicio1")
            Console.WriteLine("4. Ejercicio4: Simétrica")
            ejercicio = Convert.ToInt32(Console.ReadLine())
            Select Case ejercicio
                Case 1
                    Dim matriz2D(,) As Integer = {{1, 2, 3, 8, 3}, {4, 5, 6, 6, 2}, {9, 4, 3, 1, 7}}
                    Console.WriteLine("Escoja la fila que desea visualizar")
                    Dim fila As Integer = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Ùltimo índice de fila:" & matriz2D.GetUpperBound(0))
                    Console.WriteLine("Ùltimo índice de columna:" & matriz2D.GetUpperBound(1))
                    Console.WriteLine("Elementos fila " & fila)



                    For i As Integer = 0 To matriz2D.GetUpperBound(1) Step 1
                        Console.Write(matriz2D(fila, i) & " ")
                    Next

                    'Guardar un cero en las últimas posiciones de cada fila
                    '1,2,0

                    Console.WriteLine("Matriz después de poner a cero últimas posiciones de cada fila")
                    For i As Integer = 0 To matriz2D.GetUpperBound(0) Step 1
                        matriz2D(i, matriz2D.GetUpperBound(1)) = 0
                    Next
                    Console.WriteLine()
                    'Para comprobarlo visualizamos la matriz
                    For i As Integer = 0 To matriz2D.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz2D.GetUpperBound(1) Step 1
                            Console.Write(matriz2D(i, j) & " ")
                        Next
                        Console.WriteLine()
                    Next

                    'Suma todos los valores de la primera fila

                    Dim suma As Integer = 0

                    For i As Integer = 0 To matriz2D.GetUpperBound(1) Step 1
                        suma = suma + matriz2D(0, i)
                    Next
                    Dim mediaFila0 As Double
                    mediaFila0 = suma / matriz2D.GetLength(0)

                    Console.ReadLine()
                Case 2
                Case 3
                Case 4
                    Dim matriz(,) As Integer = {{1, 6, 1}, {0, 1, 0}, {1, 0, 1}}
                    Dim traspuesta(matriz.GetUpperBound(0), matriz.GetUpperBound(1)) As Integer

                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            traspuesta(i, j) = matriz(j, i)
                        Next j
                    Next i

                    Console.WriteLine("Matriz original")
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            Console.Write(matriz(i, j) & " ")
                        Next j
                        Console.WriteLine()
                    Next i

                    Console.WriteLine("Matriz traspuesta")
                    For i As Integer = 0 To traspuesta.GetUpperBound(0) Step 1
                        For j As Integer = 0 To traspuesta.GetUpperBound(1) Step 1
                            Console.Write(traspuesta(i, j) & " ")
                        Next j
                        Console.WriteLine()
                    Next i

                    'Comprobar si es simétrica
                    Dim simetrica As Boolean = True

                    'Son simétricas: Si original es igual a la traspues
                    For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                        For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                            If matriz(i, j) <> traspuesta(i, j) Then
                                simetrica = False
                                Exit For
                            End If
                        Next
                        If Not simetrica Then
                            Console.WriteLine("No simétrica")
                            Exit For
                        End If
                    Next

                    If simetrica Then
                        Console.WriteLine("Matriz simétrica")
                    End If

                Case 6
                    Dim m(,) As Integer = {{1, 2, 3}, {8, 9, 0}, {2, 3, 1}, {9, 0, 8}}
                    Dim sumaUltimaColumna As Integer

                    'Mostrar la matriz
                    For i As Integer = 0 To m.GetUpperBound(0) Step 1
                        For j As Integer = 0 To m.GetUpperBound(1) Step 1
                            Console.Write(m(i, j) & " ")
                        Next
                        Console.WriteLine()
                    Next

                    For i As Integer = 0 To m.GetUpperBound(0) Step 1
                        sumaUltimaColumna += m(i, m.GetUpperBound(1))
                    Next

                    Console.WriteLine("La suma de la última columna : " & sumaUltimaColumna)

                Case 7
                    Dim m(,) As Integer = {{1, 2, 3, 4, 5}, {9, 8, 7, 6, 3}}
                    Dim max, min, suma, posIMax, posJMax As Integer
                    Dim media, desviacionMax, desviacionMin As Double
                    max = m(0, 0)
                    min = m(0, 0)

                    For i As Integer = 0 To m.GetUpperBound(0) Step 1
                        For j As Integer = 0 To m.GetUpperBound(1) Step 1
                            If max < m(i, j) Then
                                max = m(i, j)
                                posIMax = i
                                posJMax = j
                            End If
                        Next
                    Next



                    For Each valor As Integer In m
                        If min > valor Then
                            min = valor
                        End If
                    Next

                    'Calcular la media
                    For Each valor As Integer In m
                        suma += valor
                    Next

                    media = suma / m.Length

                    desviacionMax = Math.Abs(max - media)
                    desviacionMin = Math.Abs(min - media)

                    Console.WriteLine("Mínimo : " & min)
                    Console.WriteLine("Máximo : " & max & " Posición : " & posIMax & "," & posJMax)
                    Console.WriteLine("Media : " & media)
                    Console.WriteLine("Desviación máximo : " & desviacionMax)
                    Console.WriteLine("Desviación minimo : " & desviacionMin)

                Case 8
                    Dim m(,) As Integer = {{0, 0, 1}, {0, 0, 0}, {0, 0, 0}}
                    Dim contador As Integer = 0

                    'Detectar filas con solo ceros
                    For i As Integer = 0 To m.GetUpperBound(0) Step 1
                        contador = 0
                        For j As Integer = 0 To m.GetUpperBound(1) Step 1
                            If m(i, j) = 0 Then
                                contador += 1
                            End If
                        Next
                        If contador = 3 Then
                            Console.WriteLine("Rango 2 o 1")
                            Console.WriteLine("Fila " & i & " con todo ceros")
                            Exit For
                        End If
                    Next
                    'Todo Crear variable de no se que

                Case 9
#Region "variables matrices"
                    Dim m1(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {4, 2, 1}}
#Region "matriz2"
                    Dim m2(,) As Integer = {{2, 3, 4}, {1, 1, 1}, {5, 9, 9}}
#End Region

                    Dim suma(m1.GetUpperBound(0), m1.GetUpperBound(1)) As Integer
                    ' Dim suma2(m1.GetLength(0) - 1, m2.GetLength(1) - 1) As Integer
#End Region

                    For i As Integer = 0 To m1.GetUpperBound(0) Step 1
                        For j As Integer = 0 To m1.GetUpperBound(1) Step 1
                            suma(i, j) = m1(i, j) + m2(i, j)
                        Next
                    Next

                    For i As Integer = 0 To m1.GetUpperBound(0) Step 1
                        For j As Integer = 0 To m1.GetUpperBound(1) Step 1
                            Console.WriteLine(suma(i, j) & " ")
                        Next
                        Console.WriteLine()
                    Next
                Case 10


                Case 11


                Case 12
                    Dim m(,) As Integer = {{1, 0, 0, 0}, {2, 3, 6, 0}, {1, 3, 4, 0}, {1, 1, 1, 1}}

                    Dim tInferior As Boolean = True
                    Dim tSuperiro As Boolean = True

                    For i As Integer = 0 To m.GetUpperBound(0) Step 1
                        For j As Integer = 0 To m.GetUpperBound(1) Step 1
                            If j > i Then
                                If m(i, j) <> 0 Then
                                    tInferior = False
                                    Exit For
                                End If
                            End If
                        Next
                        If tInferior = False Then
                            Exit For
                        End If
                    Next

                    If tInferior Then
                        Console.WriteLine("Triangular inferior")
                    Else
                        Console.WriteLine("No es triangular inferior")
                    End If

                Case 13
                    Dim m(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {9, 0, 1}}

                    If m.GetUpperBound(0) = m.GetUpperBound(1) Then
                        For i As Integer = 0 To m.GetUpperBound(0) Step 1
                            For j As Integer = 0 To m.GetUpperBound(1) Step 1
                                If i = j Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    Console.Write(m(i, j) & " ")
                                Else
                                    Console.Write("  ")
                                End If

                            Next
                            Console.WriteLine()
                        Next
                    End If


            End Select

            Console.ReadLine()

        Loop While ejercicio < 15


        Console.ReadLine()
    End Sub

End Module
