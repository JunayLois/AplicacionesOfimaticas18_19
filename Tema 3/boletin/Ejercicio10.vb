Module Ejercicio10
    Sub Main()

        Dim presion, temperatura As Double
        presion = 10
        temperatura = 300

        If presion > 2 Then
            Console.WriteLine("Abrir válvula de seguridad")

        End If

        If temperatura > 500 And temperatura < 800 Then
            Console.WriteLine("Reducir temperatura núcleo")
        End If

        If presion < 2 And temperatura < 500 Then
            Console.WriteLine("Todo en orden")
        End If


        Console.ReadLine()
    End Sub
End Module
