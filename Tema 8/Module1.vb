Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim serie As String

        Console.WriteLine("Carpeta de ficheros: " & Directory.GetCurrentDirectory())
        Console.WriteLine("Introduce una serie decente , por favor")
        serie = Console.ReadLine()

        'Escribir en el fichero series.txt que está en Bin Debug
        'Tengo que crear una variable de tipo  StreamWriter
        Dim ruta As String = Directory.GetCurrentDirectory() + "/series.txt"
        'Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)

        'escritor.WriteLine(serie)

        'escritor.Close()

        Escribir(ruta, serie)

        'Recuperar datos de un fichero
        'NEcesito un StreamReader
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Directory.GetCurrentDirectory() + "/series.txt")

        'Mostrar por pantalla las series guardadas:
        Console.WriteLine("Las series guardadas son :")

        While Not lector.EndOfStream
            'Mientras hay registros los muestro por consola
            Console.WriteLine(lector.ReadLine())
        End While

        lector.Close()
        'Volver a escribir en el fichero
        Escribir(ruta, "Better Call Saul")

        'Volver a mostrar los datos de las series

        Dim registros() As String = VolcarFicheroAMatriz(ruta)

        For i As Integer = 0 To registros.Length - 1 Step 1
            If Not registros(i) Is Nothing Then
                Console.WriteLine(registros(i))
            Else
                Exit For
            End If

        Next


        Console.ReadLine()


    End Sub

End Module
