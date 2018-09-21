Option Strict On
Module Conversiones
    Sub Main()
        'Conversiones implícitas: Un dato se guarda en una variable de un tipo con más capacidad
        'byte-->short-->integer-->long
        Dim n As Byte = 100
        Dim nShort As Short = n

        'Conversiones explicitas: Guardar un tipo de variable en una varaible de menor tamaño
        'Clase Convert
        'Convert.toByte() , Convert.toInt16() , Convert.toInt32()
        'Convert.toInt64() , Convert.toSingle() , Convert.toDouble()

        Dim n2 As Integer = 10
        Dim n3 As Short = Convert.ToInt16(n2)

        'Problema: overflow
        Dim n4 As Short = 100
        Dim n5 As Byte = Convert.ToByte(n4)

        'Problema pérdida de precision
        Dim temperatura As Single = 17.8
        Dim t As Integer = Convert.ToInt32(temperatura)
         Console.WriteLine(t)
        'Variables double y single
        Dim dato As Double = 34.67
        Dim dato2 As Single = Convert.ToSingle(dato)

        'Situaciones menos evidentes
        Dim numero As Byte = 5
        numero = Convert.ToByte(numero + 1)





        

        Console.ReadLine()






    End Sub
End Module
