Option Strict On
Module _02EjercicioMatrices
    Sub Main()
        'Zona declaración de variables
        Dim temperaturas(2) As Single
        Dim media, temperaturaMaxima, temperaturaMinima As Single


        'Solicitar al usuario que meta valores por teclado

        Console.WriteLine("Introduzca temperatura 1 ")
        temperaturas(0) = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("Introduzca temperatura 2 ")
        temperaturas(1) = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("Introduzca temperatura 3 ")
        temperaturas(2) = Convert.ToSingle(Console.ReadLine())

        'Calcular la media y la temperatura máxima
        media = (temperaturas(0) + temperaturas(1) + temperaturas(2)) / 3

        'La temperatura maxima

        Dim intermedia As Single = Math.Max(temperaturas(0), temperaturas(1))
        temperaturaMaxima = Math.Max(intermedia, temperaturas(2))

        temperaturaMaxima = Math.Max(Math.Max(temperaturas(0), temperaturas(1)), temperaturas(2))

        Console.WriteLine("La temperatura media : " & media)
        Console.WriteLine("La temperatura máxima es " & temperaturaMaxima)



        Console.ReadLine()
    End Sub
End Module
