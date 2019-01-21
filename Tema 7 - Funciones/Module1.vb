Option Strict On
Imports FuncionesRamonRS.Matematicas


Module Module1

    Sub Main()
        Dim numeroPrueba As Integer = 4


#Region "Ejercicio1"
        If IsPar(numeroPrueba) Then
            Console.WriteLine("Es par")
        Else
            Console.WriteLine("Es impar")
        End If

#End Region

#Region "Ejercicio2"

        Dim numeroPrueba2 As Double = 3.45
        Dim resultado As Double = Raiz(numeroPrueba2)
        Console.WriteLine("La raiz es : " & resultado)

#End Region

#Region "Ejercicio3"

        Dim x As Integer = 30
        Dim y As Integer = 4

        Dim menor As Integer = CalcularMenor(x, y)
        Console.WriteLine("El menor es " & menor)
        Console.ReadLine()
#End Region

        'Prueba función ejerciico 5
        Dim cadena As String = "hola"
        Dim cadena2 As String = "Adios"

        If ValidarCadenas(cadena, cadena2) Then
            Console.WriteLine("Iguales")
        Else
            Console.WriteLine("Distintas")
        End If

        'Prueba ejercicio 6: Intercambiar ariables
        Dim a As Integer = 1
        Dim b As Integer = 2
        Intercambiar(a, b)
        Console.WriteLine("Después del intercambio: ")
        Console.WriteLine("a = " & a)
        Console.WriteLine("b = " & b)

        'Prueba ejercicio 7 .
        E("Esto es muy cómodo")
        EA("Ahora con colores ")
        Console.ForegroundColor = ConsoleColor.White
        'Prueba ejercicio 8

        Dim n8 As Integer = 6
        Dim resultadoSumaPorReferencia As Integer

        SumaPorReferencia(n8, resultadoSumaPorReferencia)

        Console.WriteLine("La suma es : " & resultadoSumaPorReferencia)

        SumaPorReferencia(n8, resultadoSumaPorReferencia)
        Console.WriteLine("La suma es : " & resultadoSumaPorReferencia)
        'Prueba Ejercicio 9
        Console.WriteLine()
        Console.WriteLine("Ejercicio 9: ")
        Dim m9() As Integer = {3, 4, 5, 0, 9, 7, 6}
        Dim posCero As Integer = BuscarPrimerCero(m9)
        If posCero = -1 Then
            Console.WriteLine("No hay ceros.")
        Else
            Console.WriteLine("Cero en la posición: " & posCero)
        End If
        Console.ReadLine()

        'Prueba Ejercicio 16

        Dim m16(10) As Integer
        LlenarMatriz(m16, 20)
        Dim suma As Long = SumaMatriz2(m16)

        ' SumaMatriz(m16, suma)


        Console.WriteLine(suma)


        'PRueba Ejercicio 19
        Dim nombres(2) As String

        guardarRegistro(nombres, "Pepito Grillo")
        guardarRegistro(nombres, "Doraemon")



        Dim opcion As Integer
        Do
            Console.WriteLine("Introduzca el nombre:")
            Dim nombre As String = Console.ReadLine()
            guardarRegistro(nombres, nombre)

            Console.WriteLine("Quiere seguir 1/0")
            opcion = Convert.ToInt32(Console.ReadLine())
        Loop While opcion = 1

        Console.WriteLine()
        Console.WriteLine("Nombres guardados:")
        For Each n As String In nombres
            If Not n Is Nothing Then
                Console.WriteLine(n)
            End If

        Next





        Console.ReadLine()

        'Prueba Ejercicio 20
        Dim matriz() As String = {"Pedro", Nothing, "Juan", "Saul", "Maria", Nothing}

        Reordenar(matriz)

        'Mostrar la matriz
        Console.WriteLine("Ejercicio 20:")
        Console.WriteLine("MAtriz reordenada")

        For Each valor As String In matriz
            Console.WriteLine(valor)
        Next


        'Prueba llenado matrices
        Dim m(19) As Integer

        LlenarMatriz(m)
        MostrarMatriz(m)

        LlenarMatriz(m, 15)
        MostrarMatriz(m)

        LlenarMatriz(m, 100, 50)
        MostrarMatriz(m)

        Dim az() As Integer = {4, 1, -3, 5, -7, 9}
        Dim copiaAz() As Integer = CorregirNegativos(az)

        Console.WriteLine("Matriz AZ")
        MostrarMatriz(az)
        Console.WriteLine("Copia Az")
        MostrarMatriz(copiaAz)

        az = copiaAz




        Console.ReadLine()


        'Prueba Dll
        Dim n1 As Integer = 3
        Dim n2 As Integer = 5
        Dim media As Double = Promedio(n1, n2)



        'Parámetros opcionales
        Dim resultadoMedia As Double
        Dim media1 As Double = PromedioOpcionales(resultadoMedia, 1, 2, 3, 4, 9)
        Dim media2 As Double = PromedioOpcionales(resultadoMedia, 3, 1)
        Dim media3 As Double = PromedioOpcionales(resultadoMedia, 4, 2, 1, 7)















        Console.ReadLine()




    End Sub

End Module
