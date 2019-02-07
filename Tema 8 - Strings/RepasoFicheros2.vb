Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim ruta As String = Directory.GetCurrentDirectory() + "\alumnos.txt"

        'Para escribir utilizo un StreamWriter
        ' Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        'Dim escritor2 As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        'escritor2.WriteLine("12345678R*Pedro Gutierrez?18*1GMI")
        'escritor2.WriteLine("2345678902*Maria Sanchez?20*2GSR")
        'escritor2.Close()

        'Para leer utilizo un StreamReader

        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim contenido As String = lector.ReadToEnd()

        Console.WriteLine(contenido)
        lector.Close()
        'Para leer registro por registro utilizo bucle while
        lector = My.Computer.FileSystem.OpenTextFileReader(ruta)

        While Not lector.EndOfStream
            Dim registro As String = lector.ReadLine()
            Dim dni As String = registro.Substring(0, 9)
            Console.WriteLine(dni)
        End While

        lector.Close()

        Console.ReadLine()

    End Sub

End Module
