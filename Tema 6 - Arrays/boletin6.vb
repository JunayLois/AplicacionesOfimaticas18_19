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
            End Select
            Console.ReadLine()
            Console.Clear()
        Loop While ejercicio < 20
        Console.ReadLine()
    End Sub

End Module
