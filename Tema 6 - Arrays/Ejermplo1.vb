Option Strict On
Module Module1

    Sub Main()
        'Repasar matrices o arrays
        'Las matrices se inicializan a cero todas sus posiciones
        Dim matriz(40) As Integer
        Dim matriz2() As Integer = {3, 4, 2, 1, 5, 7, 3, 2}
        Dim cadenas2() As String = {"Pedro", "Juan", "Maria"}

        'Las matrices de String almacenan por defecto el valor nothing
        Dim cadenas(9) As String

        'Inicializar todos los valores de la matriz a -1

        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = -1

        Next

        'Acceder a elementos
        matriz(0) = 9
        matriz(1) = -4

        'Obtener el tamaño de una matriz
        Console.WriteLine("Capacidad de la matriz : " & matriz.Length)
        'Mostrar por pantalla valores de una matriz
        'Opción 1 del principiante
        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) > 5 Then
                Console.Write(matriz(i) & " posicion: " & i)
            End If
            Console.Write(matriz(i) & " ")
        Next

        'For each: Recorre matrices de forma segura pero solo
        'debo utilizarlo para leer , no para modificar la matriz
        Console.WriteLine()
        Console.WriteLine("Recorriendo una matriz con for each")
        Dim posicion As Integer = 0
        For Each valor As Integer In matriz
            valor = 0
            Console.Write(valor & " ")

        Next
        Console.WriteLine()
        For Each valor As Integer In matriz
            Console.Write(valor & " ")
        Next
        Console.ReadLine()
    End Sub

End Module
