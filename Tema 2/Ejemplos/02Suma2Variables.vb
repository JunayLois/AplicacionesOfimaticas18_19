Option Strict On
Module Module1

    Sub Main()
        Dim n1, n2, suma As Single

        n1 = 10
        n2 = 5
        suma = n1 + n2
        Console.WriteLine("La suma vale " & suma)
        Console.ReadLine()

        n1 = n1 + 10
        n2 = n2 + 5

        suma = n1 + n2
        Console.WriteLine("La suma ahora vale " & suma)
        Console.ReadLine()
    End Sub

End Module
