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


                    Console.WriteLine("Matriz simétrica")


            End Select

            Console.ReadLine()

        Loop While ejercicio < 10


        Console.ReadLine()
    End Sub

End Module
