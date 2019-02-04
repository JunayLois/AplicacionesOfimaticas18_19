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
    'Función ejercicio 4
    Function BuscarArroba(ByRef cadena As String) As Boolean
        '  Dim encontrado As Boolean = False
        If cadena.Contains("@") Then
            Return True
        End If
        Return False
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


    'funcion ejercicio 6

    Function GetDominio(ByRef cadena As String) As String
        'Forma 1
        'Dim trozos() As String = cadena.Split("@"c, "."c)
        'Dim dominio As String = Nothing
        'If trozos.Length >= 2 Then
        '    dominio = trozos(1)
        'End If
        'Return dominio

        'Forma 2
        Dim posArroba As Integer = cadena.IndexOf("@"c)
        Dim posPunto As Integer = cadena.LastIndexOf("."c)
        Dim dominio As String = Nothing
        If posArroba >= 1 And posPunto >= posArroba Then
            dominio = cadena.Substring(posArroba + 1, posPunto - posArroba - 1)
        End If
        Return dominio
    End Function

    'Función ejercicio 7

    Function VerificarAA99(ByRef cadena As String) As Boolean
        Dim correcto As Boolean = True
        If Not Char.IsLetter(cadena(0)) Or Not Char.IsLetter(cadena(1)) Or
                Not Char.IsDigit(cadena(2)) Or Not Char.IsDigit(cadena(3)) Then
            correcto = False
        End If
        Return correcto
    End Function

    'Function ejercicio 8

    Function Reemplazar(ByRef cadena As String) As String
        Dim cadenaCopia As String = cadena.Replace(" ", "*")
        Return cadenaCopia
    End Function






End Module
