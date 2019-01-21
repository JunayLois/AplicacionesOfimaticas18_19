Module FuncionesMatrices

    Sub LlenarMatriz(ByRef matriz() As Integer)
        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = aleatorio.Next()
        Next
    End Sub

    Sub LlenarMatriz(ByRef matriz() As Integer, ByVal limiteSuperior As Integer)
        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = aleatorio.Next(limiteSuperior)
        Next
    End Sub

    Sub LlenarMatriz(ByRef matriz() As Integer, ByVal limiteSuperior As Integer, ByVal limiteInferior As Integer)
        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To matriz.Length - 1 Step 1
            matriz(i) = aleatorio.Next(limiteInferior, limiteSuperior)
        Next
    End Sub

    Sub MostrarMatriz(ByRef m() As Integer)
        For Each numero As Integer In m
            Console.Write(numero & " ")
        Next
        Console.WriteLine()
    End Sub


    Function CorregirNegativos(ByRef m() As Integer) As Integer()

        Dim local(m.Length - 1) As Integer

        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) < 0 Then
                local(i) = 0
            Else
                local(i) = m(i)
            End If
        Next

        Return local

    End Function

    Function PromedioOpcionales(ByRef resultado As Double, ParamArray ByVal n() As Integer) As Double
        Dim media As Double = 0
        Dim suma As Integer = 0

        For Each valor As Integer In n
            suma += valor
        Next

        media = suma / n.Length
        resultado = media
        Return media

    End Function


End Module
