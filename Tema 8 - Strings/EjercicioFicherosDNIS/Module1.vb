Option Strict On
Imports System.IO
Module Module1
    Public ruta As String = Directory.GetCurrentDirectory() + "\dnis.txt"
    Sub Main()

        Dim opcion As Char
        Do

            'Presentación menú
            LeerOpcion(opcion)

            'Evaluar opcion
            Select Case opcion
                Case "a"c
                    Dim dniNuevo As String
                    Escribir("Escribe un nuevo dni")
                    dniNuevo = Console.ReadLine()

                    EscribirFichero(dniNuevo)

                Case "b"c
                    'Buscar registro registros
                    'volcar a matriz los registros
                    Dim registros() As String = VolcarRegistrosAMatriz()

                    Dim dniABuscar As String
                    Escribir("Introduce un dni")
                    dniABuscar = Console.ReadLine()
                    'Busco en la matriz
                    If BuscarRegistro(dniABuscar, registros) Then
                        Console.WriteLine("Está ya almacenado")
                    Else
                        Console.WriteLine("No está en los registros")
                    End If
                Case "c"c
                    'Mostrar todos los registros

                    'Dos formas de mostrar registros fichero
                    '1. Conectado
                    'Dim lector As StreamReader = New StreamReader(ruta)
                    'My.Computer.FileSystem.OpenTextFileReader(ruta)
                    'While Not lector.EndOfStream
                    '    Dim cadena As String = lector.ReadLine()
                    '    If Not cadena Is Nothing Then
                    '        Escribir(cadena)
                    '    End If
                    'End While
                    'lector.Close()

                    '2. Desconectado
                    Dim actual() As String = VolcarRegistrosAMatriz()

                    For Each registro As String In actual
                        If Not registro Is Nothing Then
                            Escribir(registro)
                        End If

                    Next
                Case "d"c
                    Dim actual() As String = VolcarRegistrosAMatriz()
                    Dim dniEliminar As String
                    Escribir("Introduce el dni que te quieres cargar")
                    dniEliminar = Console.ReadLine()
                    EliminarValor(actual, dniEliminar)

                    'Debo actualizar el fichero con este cambio
                    SobreEscribirFichero(actual)
                Case "e"c
                Case "f"c


            End Select

        Loop While opcion <> "f"c
    End Sub

End Module
