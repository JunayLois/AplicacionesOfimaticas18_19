Option Strict On
Module Module1

    Sub Main()

        'Solicitar por teclado la edad y el dni del usuario
        Dim edad As Byte
        Dim dni As String

        'Solicito la edad
        Console.WriteLine("Introduce tu edad : ")
        edad = Convert.ToByte(Console.ReadLine())

        'Solicito el DNI

        Console.WriteLine("Introduzca su dni")
        dni = Console.ReadLine()


        Console.WriteLine("Su edad es " & edad)
        Console.WriteLine("Su dni es " & dni)
        Console.ReadLine()



    End Sub

End Module
