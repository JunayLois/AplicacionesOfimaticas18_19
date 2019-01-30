Imports System.IO
Module Ficheros

    Sub Escribir(ByRef ruta As String, ByRef registro As String)
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()

    End Sub

    Function VolcarFicheroAMatriz(ByRef ruta As String) As String()
        Dim registros(99) As String
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim i As Integer = 0
        While Not lector.EndOfStream
            registros(i) = lector.ReadLine()
            i += 1
        End While

        Return registros
    End Function


End Module
