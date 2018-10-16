Option Strict On

Module Module1

    Sub Main()

        Dim opcion As Integer

        Do
            Console.ForegroundColor = ConsoleColor.White

            Console.WriteLine("Escoge el ejercicio : ")
            Console.WriteLine("5. Evaluar nota")
            Console.WriteLine("6. Múltiplo de 4")
            Console.WriteLine("8. Calculadora.")
            Console.WriteLine("9. Calcular gasto de agua")
            Console.WriteLine("10. Calcular salario neto:")
            Console.WriteLine("12. Escoger color")
            Console.WriteLine("13. Resolver ecuación 2do grado")
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

                Case 6
                    Dim numero As Integer
                    Console.WriteLine("introduce un numero")
                    numero = Convert.ToInt32(Console.ReadLine())

                    Console.WriteLine()
                    Console.WriteLine("Numero introducido : " & numero)
                    If numero Mod 4 = 0 Then
                        numero += 25
                    ElseIf numero Mod 5 = 0 Then
                        numero += 50
                    Else
                        numero += 100
                    End If

                    Console.WriteLine("Numero modificado : " & numero)
                Case 7
                    Dim temp As Double = 34

                    If temp < 0 Then
                        Console.WriteLine("Hielo")
                    ElseIf temp < 100 Then
                        Console.WriteLine("Agua")
                    Else
                        Console.WriteLine("Vapor")
                    End If
                Case 8
                    Console.WriteLine("Introduzca una opción:")
                    Console.WriteLine("a. Sumar")
                    Console.WriteLine("b. Restar")
                    Console.WriteLine("c. Multiplicar")
                    Dim opcion2 As Char = Convert.ToChar(Console.ReadLine())

                    Select Case opcion2
                        Case "a"c
                            Dim n1, n2 As Integer
                            Console.WriteLine("Introduce n1")
                            n1 = Convert.ToInt32(Console.ReadLine())
                            Console.WriteLine("Introduce n2")
                            n2 = Convert.ToInt32(Console.ReadLine())
                            Dim suma As Integer = n1 + n2
                            Console.WriteLine("La suma es : " & suma)

                    End Select

                Case 9
                    Dim litros, pago As Double
                    Console.WriteLine("Introduce los litros.")
                    litros = Convert.ToDouble(Console.ReadLine())

                    If litros < 50 Then
                        pago = 0
                    ElseIf litros < 200 Then
                        pago = (litros - 50) * 10
                    Else
                        pago = 150 * 10 + (litros - 200) * 20
                    End If


                    If pago < 500 Then
                        pago = 500
                    End If

                    Console.WriteLine("Tiene que pagar : " & pago & " euros.")

                Case 10
                    Dim horas, tasa, tasaExtra, salarioBruto, salarioNeto As Double
                    Dim horasExtra As Double

                    Console.WriteLine("Horas trabajadas")
                    horas = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("Introduce la tasa :")
                    tasa = Convert.ToDouble(Console.ReadLine())

                    'Calcular horas Extra
                    horasExtra = horas - 38

                    'Calcular tasa extra = tasa + 50%

                    tasaExtra = 1.5 * tasa

                    If horas <= 38 Then
                        salarioBruto = horas * tasa
                    Else
                        salarioBruto = 38 * tasa + horasExtra * tasaExtra
                    End If

                    If salarioBruto <= 300 Then
                        salarioNeto = salarioBruto
                    Else
                        salarioNeto = salarioBruto * 0.9
                    End If

                    Console.WriteLine("Salario bruto : " & salarioBruto)
                    Console.WriteLine("Salario neto : " & salarioNeto)

                Case 12
                    Dim color As Char
                    Console.WriteLine("Escoge Rojo (r) , Verde(g) o Azul(b)")
                    color = Convert.ToChar(Console.ReadLine())

                    Select Case color
                        Case "r"c, "R"c
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("Has escogido el Rojo")
                        Case "g"c, "G"c
                            Console.ForegroundColor = ConsoleColor.Green
                            Console.WriteLine("Has escogido el Verde")
                        Case "b"c, "B"c
                            Console.ForegroundColor = ConsoleColor.Blue
                            Console.WriteLine("Has escogido el Azul")
                        Case Else
                            Console.ForegroundColor = ConsoleColor.Black
                            Console.WriteLine("Has escogido el negro")

                    End Select

                Case 13
                    'ax2 + bx + c = 0
                    Dim a, b, c As Integer
                    Dim sol1, sol2 As Double
                    Dim solucion As Boolean = True
                    a = 0
                    b = 0
                    c = 1

                    'Si a = 0 --> bx + c = 0 --> sol1 = -c/b
                    If a = 0 Then
                        If b = 0 Then
                            solucion = False
                            Console.WriteLine("No se puede resolver")
                        Else
                            sol1 = -c / b
                            sol2 = sol1
                        End If
                    ElseIf b = 0 Then
                        'Si b = 0 --> ax2 + c = 0 --> sol = +- Raiz(-c/a)
                        Dim radicando As Double = -c / a
                        If radicando > 0 Then
                            sol1 = Math.Sqrt(-c / a)
                            sol2 = -Math.Sqrt(-c / a)
                        Else
                            solucion = False
                            Console.WriteLine("No tiene solución real")
                        End If

                    ElseIf c = 0 Then
                        'Si c = 0 --> ax2 + bx = 0 --> sol1 = 0 , sol2 = -b/a
                        sol1 = 0
                        sol2 = -b / a
                    Else
                        'sol1 = -b +-Raiz(b2 -4ac)/2a
                        Dim radicando As Double = b * b - 4 * a * c

                        If radicando >= 0 Then
                            sol1 = (-b + Math.Sqrt(radicando)) / 2 * a
                            sol2 = (-b - Math.Sqrt(radicando)) / 2 * a
                        Else
                            solucion = False
                            Console.WriteLine("No tiene solución real")
                        End If

                    End If

                    If solucion Then
                        Console.WriteLine("Las soluciones son : ")
                        Console.WriteLine("x1 = " & sol1)
                        Console.WriteLine("x2 = " & sol2)
                    End If


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
