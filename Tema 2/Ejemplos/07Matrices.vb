Option Strict On
Module Module1

    Sub Main()
        'Declarar matrices de tipo Integer
        Dim notas(4) As Integer
        Dim temperaturas() As Single = {4.5, 8.9, 12.89}
        Dim dnis(3) As String
        Console.WriteLine("Introduzca dni del primer alumno : ")
        dnis(0) = Console.ReadLine()
        Console.WriteLine("Introduzca dni del segundo alumno : ")
        dnis(1) = Console.ReadLine()
        Console.WriteLine("Introduzca dni del tercer alumno : ")
        dnis(2) = Console.ReadLine()
        Console.WriteLine("Introduzca dni del cuarto alumno : ")
        dnis(3) = Console.ReadLine()

        notas(0) = 10
        notas(1) = 4
        notas(2) = 8
        notas(3) = 6
        notas(4) = 1

        'Indice fuera de los límites de la matriz --> Esto provoca una excepción
        notas(5) = 9898

        'Mostrar por pantalla
        Console.WriteLine(notas(0) & " " & notas(1) & " " & notas(2))









        Console.ReadLine()
    End Sub

End Module
