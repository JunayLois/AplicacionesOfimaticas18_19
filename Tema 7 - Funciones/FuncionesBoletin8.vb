Option Strict On
Module FuncionesBoletin8

#Region "Funciones"

    'Ejercicio 1 : Función que dice si un numer es par o impar

    Function IsPar(ByVal n As Integer) As Boolean
        Dim par As Boolean = False
        If n Mod 2 = 0 Then
            par = True
        End If
        Return par
    End Function

    'Ejercicio 2: Calculo raiz

    Function Raiz(ByVal n As Double) As Double
        If n < 0 Then
            Return 0
        Else
            Return Math.Sqrt(n)
        End If
    End Function

    'Ejercicio 3 : Menor de dos valores Int

    Function CalcularMenor(ByVal n As Integer, ByVal n2 As Integer) As Integer
        'If n < n2 Then
        '    Return n
        'Else
        '    Return n2
        'End If

        Dim menor As Integer

        If n < n2 Then
            menor = n
        Else
            menor = n2

        End If
        Return menor
    End Function

    Function CalcularMenor(ByVal n As Double, ByVal n2 As Double) As Double
        If n < n2 Then
            Return n
        Else
            Return n2
        End If
    End Function

    Function ValidarCadenas(ByVal cadena1 As String, ByVal cadena2 As String) As Boolean
        Dim iguales As Boolean = False
        If cadena1 = cadena2 Then
            iguales = True
        End If
        Return iguales
    End Function

    'Ejercicio 6

    Sub Intercambiar(ByRef x As Integer, ByRef y As Integer)
        Dim z As Integer = x
        x = y
        y = z
    End Sub

    'Ejercicio 7
    Sub E(ByVal mens As String)
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine(mens)
    End Sub

    Sub EA(ByVal mens As String)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(mens)
    End Sub

    Sub E(ByVal mens As String, ByVal color As ConsoleColor)
        Console.ForegroundColor = color
        Console.WriteLine(mens)

    End Sub

    'Función ejercicio 8

    Sub SumaPorReferencia(ByVal n As Integer, ByRef resultado As Integer)
        Dim suma As Integer = 0
        For i As Integer = 1 To n Step 1
            If n Mod i = 0 Then
                suma += i
            End If

        Next
        resultado = suma
    End Sub

    'Ejercicio 9

    Function BuscarPrimerCero(ByRef matriz() As Integer) As Integer
        'Defino un valor para cuando no encuentre ceros: -1
        Dim posicion As Integer = -1

        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) = 0 Then
                posicion = i
                Exit For
            End If
        Next

        Return posicion
    End Function

    'Ejercicio 16

    'Sub SumaMatriz(ByRef m() As Integer, ByRef suma As Long)
    '    suma = 0
    '    For Each numero As Integer In m
    '        suma += numero

    '    Next
    'End Sub

    Function SumaMatriz2(ByRef m() As Integer) As Long
        Dim suma As Integer = 0
        For Each numero As Integer In m
            suma += numero
        Next
        Return suma
    End Function

    'Función Ejercicio 17

    Function getNegativos(ByRef m() As Integer) As Integer()
        Dim matriz2() As Integer

        Return matriz2
    End Function

    'Función ejercicio 19

    Sub guardarRegistro(ByRef m() As String, ByRef registro As String)
        Dim guardado As Boolean = False

        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) Is Nothing Then
                m(i) = registro
                guardado = True
                Exit For


            End If
        Next

        If Not guardado Then
            ReDim Preserve m(m.Length * 2)

            'Llamo a guardarRegistro
            'Recursividad
            guardarRegistro(m, registro)
        End If
    End Sub

    'Función Ejercicio 20
    Sub Reordenar(ByRef matriz() As String)

        Dim copia(matriz.Length - 1) As String
        Dim j As Integer = 0
        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) IsNot Nothing Then
                copia(j) = matriz(i)
                j += 1
                ' guardarRegistro(copia,matriz(i))
            End If
        Next

        'Igualar las matrices
        matriz = copia

    End Sub













#End Region
End Module
