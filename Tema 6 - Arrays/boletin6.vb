Module Module1

    Sub Main()

        Dim ejercicio As Integer
        Do
            Console.WriteLine("Introduce el ejercicio.")
            Console.WriteLine("1. Ejercicio 1")
            Console.WriteLine("2. Ejercicio 2")
            Console.WriteLine("3. Ejercicio 3")
            Console.WriteLine("4. Ejercicio 4")
            Console.WriteLine("5. Ejercicio 5")
            ejercicio = Convert.ToInt32(Console.ReadLine())
            Console.Clear()
            Select Case ejercicio
                Case 1
                    Dim matriz(8) As Short

                    'Modificar posiciones 0 ,1 y 3
                    matriz(0) = 2
                    matriz(1) = 9
                    matriz(3) = -3

                    'Mostrar por pantalla valores 
                    Console.WriteLine("Valores guardados en la matriz:")
                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        Console.Write(matriz(i) & " ")
                    Next
                    Console.WriteLine()


                    'Guardar valor en última posición
                    Console.WriteLine("Introduce un valor para la última posicion")
                    matriz(matriz.Length - 1) = Convert.ToInt16(Console.ReadLine())

                    'Vuelvo a mostrar la matriz
                    Console.WriteLine()
                    'Mostrar por pantalla valores 
                    Console.WriteLine("Valores guardados en la matriz:")

                    For Each valor As Short In matriz
                        Console.Write(valor & " ")
                    Next

                Case 2
                    Dim matriz2() As Integer = {3, 4, 8, 9, 4}
                    Dim suma As Integer = 0
                    Dim media As Double = 0

                    For i As Integer = 0 To matriz2.Length - 1 Step 1
                        suma = suma + matriz2(i)
                    Next

                    media = suma / matriz2.Length

                    Console.WriteLine("La suma es : " & suma)
                    Console.WriteLine("La media es : " & media)
                    suma = 0
                    media = 0
                    For i As Integer = 0 To matriz2.Length - 1 Step 1
                        Console.WriteLine("Introduzca valor para posicion: " & i)
                        matriz2(i) = Convert.ToInt32(Console.ReadLine())
                    Next

                    'Vuelvo a calcular suma y media
                    For Each valor As Integer In matriz2
                        suma = suma + valor
                    Next
                    media = suma / matriz2.Length
                    Console.WriteLine("La suma es : " & suma)
                    Console.WriteLine("La media es : " & media)

                    'Evaluar media

                    If media < 0 Or media > 10 Then
                        Console.WriteLine("Error")
                    ElseIf media < 5 Then
                        Console.WriteLine("Suspenso")
                    ElseIf media < 7 Then
                        Console.WriteLine("Aprobado")
                    ElseIf media < 9 Then
                        Console.WriteLine("Notable")
                    Else
                        Console.WriteLine("Sobresaliente")
                    End If

                Case 3
                    Dim matriz3() As Integer = {6, 1, 3, 4, 5, 6, 7, 8, 9, 3}
                    Dim media As Double = 0
                    Dim suma As Integer = 0

                    For i As Integer = 0 To matriz3.Length - 1 Step 1
                        suma += matriz3(i)

                    Next
                    media = suma / matriz3.Length

                    Console.WriteLine("La media es : " & media)
                    'Declarar un array para las desviaciones
                    Dim desviaciones(matriz3.Length - 1) As Double

                    'Calculo las desviaciones

                    For i As Integer = 0 To matriz3.Length - 1 Step 1
                        desviaciones(i) = Math.Abs(matriz3(i) - media)
                    Next

                    'Mostrar las desviaciones
                    Dim posicion As Integer = 0
                    For Each valor As Double In desviaciones
                        Console.WriteLine("Desviacion de posicion " & posicion & " : " & valor)
                        posicion += 1
                    Next

                    'Calcular la desviacion media
                    Dim desviacionMedia As Double = 0
                    Dim sumaDesviaciones As Double = 0

                    For Each valor As Double In desviaciones
                        sumaDesviaciones += valor
                    Next

                    desviacionMedia = sumaDesviaciones / desviaciones.Length

                    Console.WriteLine("La desviación media es : " & desviacionMedia)

                Case 4
                    Dim n As Integer
                    Console.WriteLine("Cuantos valores vas a meter ?")
                    n = Convert.ToInt32(Console.ReadLine())
                    Dim matriz(n - 1) As Integer

                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        Console.WriteLine("Introduzca valor para posicion: " & i)
                        matriz(i) = Convert.ToInt32(Console.ReadLine())
                    Next

                    Dim negativos As Boolean = False
                    Dim contador As Integer = 0
                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        If matriz(i) < 0 Then
                            Console.WriteLine(matriz(i) & " posicion : " & i)
                            negativos = True

                        End If
                    Next

                    If negativos = False Then
                        Console.WriteLine("No hay números negativos")
                    End If

                Case 5
                    Dim m1(4), m2(4) As Integer

                    'Solicitar valores del primer array por teclado
                    For i As Integer = 0 To m1.Length - 1 Step 1
                        Console.WriteLine("Introduce el valor de la posicion " & i)
                        m1(i) = Convert.ToInt32(Console.ReadLine())
                    Next

                    'Dar valores al segundo array

                    For i As Integer = 0 To m1.Length - 1 Step 1
                        m2(i) = m1(i) + 10
                    Next

                    Console.WriteLine("Mostrar valores m2 : ")
                    'Mostrar m2
                    For Each valor As Integer In m2
                        Console.Write(valor & " ")
                    Next

                Case 8
                    Dim x As Integer = 5

                    'Crear un array de x elementos
                    Dim matriz(x - 1) As Integer

                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        Console.WriteLine("Introduce valor posicion " & i)
                        matriz(i) = Convert.ToInt32(Console.ReadLine())
                    Next
                    Dim posicion As Integer
                    Console.WriteLine("Escoja una posición : ")
                    posicion = Convert.ToInt32(Console.ReadLine())

                    'Intercambiar el último con el valor de la posición escogida
                    If posicion < 0 Or posicion > matriz.Length - 1 Then
                        Console.WriteLine("Error en la posición")
                    Else
                        Dim aux As Integer = matriz(matriz.Length - 1)
                        matriz(matriz.Length - 1) = matriz(posicion)
                        matriz(posicion) = aux
                    End If
                    Console.WriteLine("Array modificado: ")
                    'Mostrar el array modificado
                    For Each valor As Integer In matriz
                        Console.Write(valor & " ")
                    Next
                    Console.WriteLine()

                Case 9
                    Dim matriz() As Integer = {6, -3, 9, 0, 7, 1}
                    Dim posicion As Integer = -1
                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        If matriz(i) < 0 Then
                            posicion = i
                            Console.Write("El primer negativo es " & matriz(i) & " en la posición " & i)
                            Exit For
                        End If
                    Next
                    If posicion = -1 Then
                        Console.WriteLine("No hay números negativos")
                    End If

                Case 10
                    Dim matriz() As Integer = {5, 1, 3, 5, 8, 1, 8}
                    Dim valorBuscado As Integer
                    Console.WriteLine("Intro valor que desea buscar")
                    valorBuscado = Convert.ToInt32(Console.ReadLine())
                    Dim encontrado As Boolean = False
                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        If matriz(i) = valorBuscado Then
                            encontrado = True
                            Console.WriteLine("Posición " & i)
                        End If
                    Next

                    If Not encontrado Then
                        Console.WriteLine("No está en la matriz")
                    End If

                Case 11
                    Dim matriz1() As Integer = {3, 5, 1, 3, 7, 9}
                    Dim matriz2(matriz1.Length - 1) As Integer

                    Array.Copy(matriz1, matriz2, matriz1.Length)

                    Array.Sort(matriz1)

                    'Mostrar las dos matriz
                    Console.WriteLine("Matriz 1")
                    For Each p As Integer In matriz1
                        Console.Write(p & " ")
                    Next

                    Console.WriteLine()
                    Console.WriteLine("Matriz 2")

                    For Each p As Integer In matriz2
                        Console.Write(p & " ")
                    Next
                    Console.WriteLine()
                    Dim valor As Integer = 7

                    'Buscar en la primera matriz
                    Dim posicion1 As Integer = Array.BinarySearch(matriz1, valor)
                    If posicion1 < 0 Then
                        Console.WriteLine(valor & " no está en la matriz")
                    Else
                        Console.WriteLine(valor & " está en la posición : " & posicion1)
                    End If

                    'Buscar en la segunda matriz
                    Dim posicion2 As Integer = -1

                    For i As Integer = 0 To matriz2.Length - 1 Step 1
                        If matriz2(i) = valor Then
                            posicion2 = i
                            Exit For
                        End If
                    Next

                    If posicion2 < 0 Then
                        Console.WriteLine("No está en la matriz")
                    Else
                        Console.WriteLine(valor & " está en la posición " & posicion2)
                    End If

                Case 12
                    Dim matriz() As Integer = {9, 0, 11, 6, -5, 4, 3, 2, 1}
                    '0,9,6,11,-5
                    For j As Integer = 0 To matriz.Length - 1 Step 1
                        For i As Integer = 0 To matriz.Length - 2 Step 1
                            If matriz(i) > matriz(i + 1) Then

                                Dim auz As Integer = matriz(i)
                                matriz(i) = matriz(i + 1)
                                matriz(i + 1) = auz

                            End If

                        Next
                    Next
                    'Mostrar la matriz
                    Console.WriteLine("Matriz ")
                    For Each valor As Integer In matriz
                        Console.Write(valor & " ")
                    Next
                    Console.WriteLine()

                Case 13
                    Dim matriz() As Integer = {5, 6, 1, 3, 7, 9}
                    Dim maximo As Integer = matriz(0)
                    Dim minimo As Integer = matriz(0)
                    Dim posMax, posMin As Integer

                    For i As Integer = 1 To matriz.Length - 1 Step 1
                        If maximo < matriz(i) Then
                            maximo = matriz(i)
                            posMax = i + 1
                        End If
                    Next

                    For i As Integer = 1 To matriz.Length - 1 Step 1
                        If matriz(i) < minimo Then
                            minimo = matriz(i)
                            posMin = i + 1
                        End If
                    Next
                    'Mostrar los resultados
                    Console.WriteLine(maximo & " posicion: " & posMax)
                    Console.WriteLine(minimo & " posicion: " & posMin)

                Case 14
                    Dim matriz() As Integer = {13, 6, 17, 19, 5}
                    Dim primo As Boolean = True
                    Dim contadorPrimos As Integer = 0
                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        primo = True
                        For j As Integer = 2 To Convert.ToInt32(matriz(i) / 2) Step 1
                            If matriz(i) Mod j = 0 Then
                                primo = False
                                Exit For
                            End If
                        Next

                        If primo Then
                            contadorPrimos += 1
                            Console.Write(matriz(i) & " ")
                        End If
                    Next
                    Console.WriteLine()
                    Console.WriteLine("Hay " & contadorPrimos & " numeros primos")

                Case 15


                Case 16
                    Dim matriz(10) As Integer
                    Dim aleatorio As Random = New Random()

                    For i As Integer = 0 To matriz.Length - 1 Step 1
                        matriz(i) = aleatorio.Next(1, 11)
                    Next
                    Dim encontrado As Boolean = 0
                    'Mostrar la matriz
                    For j As Integer = 0 To matriz.Length - 1 Step 1
                        'Realizar una búsqueda en la matriz
                        encontrado = False
                        Dim contador As Integer = 0
                        For i As Integer = 0 To matriz.Length - 1 Step 1
                            If i <> j Then
                                If matriz(i) = matriz(j) Then
                                    encontrado = True
                                End If
                            End If
                        Next
                        If encontrado And contador = 0 Then
                            Console.Write("*" & matriz(j) & " ")
                            contador += 1
                        Else
                            Console.Write(matriz(j) & " ")
                        End If

                    Next
                    Console.WriteLine()


            End Select
            Console.ReadLine()





            Console.Clear()
        Loop While ejercicio < 20
        Console.ReadLine()
    End Sub

End Module
