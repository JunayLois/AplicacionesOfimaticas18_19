Module Funciones
    Sub LeerC(ByRef n As Integer)
        Console.WriteLine("Introduce un ejercicio:")
        n = Convert.ToInt32(Console.ReadLine())
    End Sub

    Sub LeerC(ByRef n As String)
        Console.WriteLine("Introduce una cadena:")
        n = Console.ReadLine()
    End Sub

    Sub LeerC(ByRef n As Char)
        Console.WriteLine("Quiere continuar s/n:")
        n = Convert.ToChar(Console.ReadLine())
    End Sub

    'Función Ejercicio 1

    Function ContarCaracter(ByRef cadena As String, ByVal caracter As Char) As Integer

        Dim contador As Integer = 0
        For i As Integer = 0 To cadena.Length - 1 Step 1
            If cadena(i) = caracter Then
                contador += 1
            End If
        Next

        Return contador
    End Function


    'Función ejercicio 5
    Function ContarAbas(ByRef cadena As String) As Integer
        Dim palabras() As String = cadena.Split(" ")
        Dim contador As Integer = 0
        For Each p As String In palabras
            If p.Contains("aba") Then
                contador += 1
            End If
        Next

        Return contador

    End Function

    'Sobrecargar funcion que genera matriz con palabras que les pasa algo

    Function Buscador(ByRef cadena As String, ByRef criterio As String) As List(Of String)
        'Dim palabras() As String = cadena.Split(" ")
        'Dim matrizCoincidencias(palabras.Length - 1) As String

        'For i As Integer = 0 To palabras.Length - 1 Step 1
        '    If palabras(i).Contains(criterio) Then
        '        For j As Integer = 0 To palabras.Length - 1 Step 1
        '            If matrizCoincidencias(j) Is Nothing Then
        '                matrizCoincidencias(j) = palabras(i)
        '                Exit For
        '            End If
        '        Next
        '    End If
        'Next
        ' Return matrizCoincidencias
        Dim palabras() As String = cadena.Split(" ")
        Dim listaCoincidencias As List(Of String) = New List(Of String)()

        For Each palabra As String In palabras
            If palabra.Contains(criterio) Then
                listaCoincidencias.Add(palabra)
            End If
        Next

        Return listaCoincidencias
    End Function













End Module
