Option Strict On
Module Module1

    Sub Main()
        Dim palabras() As String = {"caballo", "lagartija", "estupendo"}
        Dim aleatorio As Random = New Random()
        Dim pos As Integer = aleatorio.Next(0, 3)

        Dim pGenerada As String = palabras(pos)

        Dim copia(pGenerada.Length - 1) As Char

        For i As Integer = 0 To pGenerada.Length - 1 Step 1
            copia(i) = "_"c
        Next

        For i As Integer = 0 To pGenerada.Length - 1 Step 1
            Console.Write(copia(i) + " ")
        Next
        Console.WriteLine()
        Dim letra As Char
        Dim vidas As Integer = 0
        Do


            Console.WriteLine("Introduce una letra")
            letra = Convert.ToChar(Console.ReadLine())
            Dim j As Integer = 0
            For i As Integer = 0 To pGenerada.Length - 1 Step 1
                If pGenerada(i) = letra Then
                    copia(i) = letra
                End If
            Next
            Console.WriteLine()
            For i As Integer = 0 To pGenerada.Length - 1 Step 1
                Console.Write(copia(i) + " ")
            Next
            Console.WriteLine()
        Loop While vidas < pGenerada.Length











    End Sub

End Module
