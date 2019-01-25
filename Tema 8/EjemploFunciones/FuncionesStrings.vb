Option Strict On
Module Module1

    Sub Main()
        Dim cadena As String = "665473737"
        Dim direccion As String = "Calle Paz Pardo 84, Vigo, Pontevedra"

        'Funciones
        'indexOf(char c) ->Posicion de la primera aparicion
        Dim pos As Integer = direccion.IndexOf("a")
        Dim pos2 As Integer = direccion.IndexOf("Vigo")
        Dim pos3 As Integer = direccion.IndexOf("a", pos2)

        'LastIndexOf(char c) ->Última aparicion
        Dim pos4 As Integer = direccion.LastIndexOf("c", pos2)
        'IndexOfAny(char ()c)
        Dim caracteres() As Char = {"a"c, "e"c, "i"c, " "c}
        Dim pos5 As Integer = direccion.IndexOfAny(caracteres)

        'substring(int indice)-->Devuelve los caracteres desde ese indice
        'hasta el final
        Dim subCadena As String = direccion.Substring(5)
        Console.WriteLine("Substring desde caracter 5 : " & subCadena)
        Console.ReadLine()
        'substring(int indice, int cantidad)
        Dim subCadena2 As String = direccion.Substring(6, 3)
        Console.WriteLine("Substring de 3 caracteres desde caracter 6 : " & subCadena2)
        Console.ReadLine()

        'StartsWith(String s) , EndsWith(String s)
        If direccion.StartsWith("Calle") Then
            Console.WriteLine("Es una calle")
        End If

        'Split(Char separador)-->Devuelve una matriz de strings , con
        'los trozos formados al separar el string original con el caracter
        'que recie como parámetro
        Dim palabras() As String = direccion.Split(" "c)

        'Mostrar la matriz de palabras
        For Each p As String In palabras
            Console.WriteLine(p)
        Next

        'contains(string s)--> Devuelve true si aparece s en el string original

        If direccion.Contains("Calle Paz") Then
            Console.WriteLine("Puede que la calle esté en Vigo")
        End If

        'Funciones para identificar si un char es digito , letra ,
        'espacio o una cosa rara
        Dim letra As Char = "w"c

        If Char.IsLetter(letra) Then
            Console.WriteLine("Es una letra")
        End If

        'Un string es un array de chars
        Dim letraInicial As Char = direccion(0)
        Console.WriteLine("Mayusculas:")
        'Comprobar si hay alguna mayuscula en la direccion
        'HAgo un bucle que recorra el string
        For i As Integer = 0 To direccion.Length - 1 Step 1
            If Char.IsUpper(direccion(i)) Then
                Console.Write(direccion(i) & " ")
            End If

        Next

        'Concatenar Strings
        'Dim cadenaFinal As String = direccion + " Galicia"
        'Dim cadenaFinal2 As String = cadenaFinal + " España"

        direccion += " Galicia"
        direccion += " España"
        Console.WriteLine(direccion)

        Dim direccionSinEspacios As String = direccion.Trim()
        Console.WriteLine(direccionSinEspacios)

        'Comparar Strings
        Dim cadena1 As String = "hola"
        Dim cadena2 As String = "hola"

        If cadena1.Equals(cadena2) Then
            Console.WriteLine("Son iguales")
        End If


        If cadena1 = cadena2 Then
            Console.WriteLine("Son iguales con ==")
        End If



















        Console.ReadLine()

    End Sub

End Module
