Option Strict On
Module Ejercicio10
    Sub Main()
        Dim horas As Byte
        Dim tasa, salarioBruto, salarioNeto As Single
        Dim irpf As Single
        'Leer horas 
        Console.WriteLine("Introduzca las horas trabajadas : ")
        horas = Convert.ToByte(Console.ReadLine())

        'Leer la tasa
        Console.WriteLine("Introduce la tasa : ")
        tasa = Convert.ToSingle(Console.ReadLine())

        'Leer el irpf
        Console.WriteLine("Introduzca IRPF : ")
        irpf = Convert.ToSingle(Console.ReadLine())

        salarioBruto = horas * tasa

        'Salario Neto = salarioBruto - 21%salarioBruto

        'salarioNeto = Convert.ToSingle(salarioBruto - (irpf / 100) * salarioBruto)
        salarioNeto = salarioBruto * (1 - irpf / 100)


        Console.WriteLine("Salario bruto : " & salarioBruto & vbNewLine)
        Console.WriteLine()
        Console.WriteLine("Salario neto : " & salarioNeto)


        Console.ReadLine()


        Dim x1 As Single = 23
        Dim x2 As Double = 45
        Dim x3 As Decimal

        'Dim d As Short = 345
        'Dim db As Byte = Convert.ToByte(d)



        Dim y As Integer = 300000
        Dim x As Short = Convert.ToInt16(y)


    End Sub
End Module
