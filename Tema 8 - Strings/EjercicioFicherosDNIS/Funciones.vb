Imports System.IO
Module Funciones

    Sub Escribir(ByVal mensaje As String)
        Console.WriteLine(mensaje)
    End Sub
    Sub MostrarMenu()
        Escribir("Escoja una opción:")
        Escribir("a.Introducir nuevo dni")
        Escribir("b.Buscar DNI")
        Escribir("c.Mostrar DNIS")
        Escribir("d.Eliminar DNI")
    End Sub

    Sub LeerOpcion(ByRef opcion As Char)
        MostrarMenu()
        opcion = Convert.ToChar(Console.ReadLine())
    End Sub

    Sub EscribirFichero(ByVal registro As String)
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()


    End Sub
    Sub EscribirFichero(ByVal ruta As String, ByVal registro As String)
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()


    End Sub

    Sub SobreEscribirFichero(ByVal matriz() As String)
        Dim escritor As StreamWriter = New StreamWriter(ruta, False)

        For Each registro As String In matriz
            If Not registro Is Nothing Then
                escritor.WriteLine(registro)
            End If
        Next

        For i As Integer = 0 To matriz.Length - 1 Step 1
            If Not matriz(i) Is Nothing Then
                escritor.WriteLine(matriz(i))
            End If
        Next

        escritor.Close()
    End Sub


    Function VolcarRegistrosAMatriz() As String()
        Dim m(99) As String
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim i As Integer = 0
        While Not lector.EndOfStream
            m(i) = lector.ReadLine()
            i += 1
        End While
        lector.Close()
        Return m
    End Function

    Function BuscarRegistro(ByVal reg As String) As Boolean
        Dim encontrado As Boolean = False
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)

        While Not lector.EndOfStream
            If reg = lector.ReadLine() Then
                encontrado = True
                Exit While
            End If
        End While
        lector.Close()
        Return encontrado
    End Function

    Function BuscarRegistro(ByVal reg As String, ByRef m() As String) As Boolean
        Dim encontrado As Boolean = False
        For Each registro As String In m
            If registro = reg Then
                encontrado = True
                Exit For
            End If
        Next


        Return encontrado
    End Function

    Function GetPosicion(ByRef m() As String, ByRef valor As String) As Integer
        Dim posicion As Integer = -1

        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) = valor Then
                posicion = i
                Exit For
            End If

        Next
        Return posicion
    End Function

    Function EliminarValor(ByRef m() As String, ByRef valor As String) As Boolean
        Dim posicion As Integer = GetPosicion(m, valor)
        Dim eliminado As Boolean = False
        If posicion > -1 Then
            m(posicion) = Nothing
            eliminado = True
        End If
        Return eliminado
    End Function









End Module
