
Option Strict On
Imports System.Text.RegularExpressions
Imports System.IO

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
                    Dim email As String = "prueba@ciclos.com"

                    If BuscarArroba(email) Then
                        Console.WriteLine("Tiene una arroba")
                    Else
                        Console.WriteLine("No tiene una arroba")
                    End If

                Case 5
                    Dim coincidencas As List(Of String) = Buscador("Buscando a Nemo y buscando a Dory oryhuela orygami", "ory")

                    For i As Integer = 0 To coincidencas.Count() - 1 Step 1
                        Console.WriteLine(coincidencas(i))
                    Next

                    Dim contador As Integer = ContarAbas("Estaba estudiando y cantaba de contento")

                    Dim cadena As String = "Estoy aprendiendo un monton"
                    cadena = cadena.Replace("o", "e")

                Case 6
                    Dim correo As String = "prueba@gmail.com"
                    Dim dominio As String = GetDominio(correo)
                    If dominio IsNot Nothing Then
                        Console.WriteLine("Dominio : " & dominio)
                    Else
                        Console.WriteLine("Error en la direccion")
                    End If

                Case 7
                    Dim codigo As String = "WE34"
                    If VerificarAA99(codigo) Then
                        Console.WriteLine("Código correcto")
                    Else
                        Console.WriteLine("Código erróneo")
                    End If

                Case 8
                    Dim cadena As String = "Pedro 34567889R Calle Del Olvido 19"
                    Console.WriteLine(Reemplazar(cadena))
                    Console.WriteLine(cadena)
                Case 9
                    Dim casoA As String = "Pedro Jimenez*14Julio1990?250"

                    'Aqui el salario está después del ?
                    Dim salario As String = casoA.Substring(casoA.IndexOf("?"c) + 1)
                    'Para comprobar que es > 1000 hayq eu convertir a Integer
                    Dim salarioNumerico As Integer = Convert.ToInt32(salario)
                    If salarioNumerico > 1000 Then
                        Console.WriteLine("Superior a 1000")
                    Else
                        Console.WriteLine("Inferior a 1000")
                    End If


                    Dim casoB As String = "Maria Benitez*900!06Agosto1998"

                    'Aqui el salario esta entre * y !

                    Dim salario2 As String = casoB.Split("*"c, "!"c)(1)

                    Dim salario2Numerico As Integer = Convert.ToInt32(salario2)

                    If salario2Numerico > 1000 Then
                        Console.WriteLine("Mayor que 1000")
                    Else
                        Console.WriteLine("Menor que 1000")
                    End If

                Case 14
                    Dim ruta1 As String = Directory.GetCurrentDirectory() + "/fichero1.txt"
                    Dim nombre1 As String = ruta1.Substring(ruta1.LastIndexOf("/") + 1)
                    Dim ruta2 As String = Directory.GetCurrentDirectory() + "/fichero2.txt"
                    Dim nombre2 As String = ruta2.Substring(ruta2.LastIndexOf("/") + 1)

                    Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta1)
                    Dim lector2 As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta2)

                    Dim contenido1 As String = lector.ReadToEnd()
                    lector.Close()

                    Dim contenido2 As String = lector2.ReadToEnd()
                    lector.Close()

                    Dim contenidoTotal As String = contenido1 + vbNewLine + contenido2

                    Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Directory.GetCurrentDirectory() + "/" + nombre1 + "_" + nombre2, False)
                    escritor.WriteLine(contenidoTotal)
                    escritor.Close()



                Case Else

            End Select

            LeerC(opcion)
        Loop While opcion = "s"c
    End Sub

End Module
