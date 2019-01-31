
Option Strict On
Imports System.Text.RegularExpressions

Module Module1

    Sub Main()

        Dim ejercicio As Integer
        Dim opcion As Char
        Do
            LeerC(ejercicio)

            Select Case ejercicio
                Case 1
                    Dim cadena As String = "Probando probando"
                    Dim caracter As Char = "o"c

                    Dim contador As Integer = ContarCaracter(cadena, caracter)

                    Console.WriteLine(caracter & " aparece " & contador & " veces")
                Case 2
                    Dim letras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}
                    Dim correcto As Boolean = True
                    Dim dni As String
                    Do
                        correcto = True

                        Console.WriteLine("Introduce el dni")
                        dni = Console.ReadLine()

                        'Lo primero es validar la longitud del dni
                        If dni.Length <> 9 Then
                            Console.WriteLine("Número de caracteres erróneo")
                            correcto = False
                        Else
                            'Validar que el último es una letra y los 8 primeros son digitos
                            Dim subDni As String = dni.Substring(0, 8)

                            For i As Integer = 0 To subDni.Length - 1 Step 1
                                If Char.IsLetter(subDni(i)) Then
                                    Console.WriteLine("Error en los 8 primeros digitos")
                                    correcto = False
                                    Exit For
                                End If
                            Next

                            If Not Char.IsLetter(dni(8)) Or Char.IsWhiteSpace(dni(8)) Then
                                Console.WriteLine("Error en la última posicion")
                                correcto = False
                            End If

                        End If


                    Loop While Not correcto

                    'Comprobar la letra
                    Dim ochoPrimerosDigitos As String = dni.Substring(0, 8)
                    Dim resto As Integer = Convert.ToInt32(ochoPrimerosDigitos) Mod 23

                    Dim letra As Char = dni(8)

                    If letras(resto) = letra Then
                        Console.WriteLine("El dni es correcto")
                    Else
                        Console.WriteLine("La letra no es correcta")
                    End If





                Case 3
                    'Dim dniPrueba As String = "12345678Qt4"
                    'If Regex.IsMatch(dniPrueba, "^\d{8}[A-Za-z]{2}$") Then
                    '    Console.WriteLine("Expresion Regular : Correcta")
                    'End If

                    Dim cadena As String = "El niño y el balon bailaron juntos"
                    Dim palabras() As String = cadena.Split(" "c)

                    'For Each palabra As String In palabras
                    '    If palabra(0) = "b" Then

                    '    End If
                    '    If palabra.StartsWith("b") Then

                    '    End If

                    'Next

                    For i As Integer = 0 To palabras.Length - 1 Step 1
                        If palabras(i).StartsWith("b") Then

                        End If
                    Next








                Case 4
                Case 5
                    Dim coincidencas As List(Of String) = Buscador("Buscando a Nemo y buscando a Dory oryhuela orygami", "ory")

                    For i As Integer = 0 To coincidencas.Count() - 1 Step 1
                        Console.WriteLine(coincidencas(i))
                    Next



                Case Else

            End Select

            LeerC(opcion)
        Loop While opcion = "s"c
    End Sub

End Module
