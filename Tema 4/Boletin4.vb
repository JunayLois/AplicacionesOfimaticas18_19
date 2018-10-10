Option Strict On

Module Module1

    Sub Main()

        Dim opcion As Integer

        Do
            Console.ForegroundColor = ConsoleColor.White

            Console.WriteLine("Escoge el ejercicio : ")
            Console.WriteLine("5. Evaluar nota")
            Console.WriteLine("9. Calcular gasto de agua")
            Console.WriteLine("10. Calcular salario neto:")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 5
                    Dim nota As Single
                    Console.WriteLine("Introduce una nota: ")
                    nota = Convert.ToSingle(Console.ReadLine())
                    Dim mensaje As String = Nothing

                    If nota < 0 Or nota > 10 Then
                        mensaje = "Error en la nota"
                    ElseIf nota < 5 Then
                        mensaje = "Suspenso"
                    ElseIf nota < 7 Then
                        mensaje = "Aprobado"
                    ElseIf nota < 9 Then
                        mensaje = "Notable"
                    Else
                        mensaje = "Sobresaliente"
                    End If

                    Console.WriteLine(mensaje)

                Case 9
                    Console.WriteLine("Has escogido el 9.")
                Case 10
                Case Else
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Opción errónea")

            End Select



        Loop While opcion < 20

        Console.WriteLine("Salí del bucle")
        Console.ReadLine()







        Console.ReadLine()
    End Sub

End Module
