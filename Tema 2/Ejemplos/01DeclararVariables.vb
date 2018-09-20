Option Strict On
Module Module1

    Sub Main()
        'Declarando variables
        'Numéricas:byte , short , Integer , Long
        'Decimales:single , double , decimal
        'Char: un caracter
        'boolean: true o false

        'Declarar una variable sin inicializar
        Dim edad As Byte
        Console.WriteLine(edad)
        'Declarar e inicializar variables
        Dim numero As Short = 350
        Dim numero2 As Integer
        numero2 = 2000
        'Sumar 1 a la variable
        numero2 = numero2 + 1

        'Declarar varias variables a la vez
        Dim n1, n2, n3 As Integer
        n1 = 2
        n2 = n1
        n3 = n2

        'Declaración de constantes
        'Hay que inicializarlas en la declaracion
        Const maximo As Short = 150
        Dim numeroAlumnos As Short = maximo
        numeroAlumnos = maximo + 1

        'Declarar una variable char
        Dim letra As Char = "q"c
        Dim palabra As String = "Fernando"

        'Declarar variable booleana
        Dim condicion As Boolean = False
        Console.WriteLine(condicion)

        'Normas para nombrar variables
        '1. No puede comenzar por un numero :
        'Dim 1x As Integer--> Eeeeeerror
        '2. No pueden contener espacios
        'Dim temperatura noviembre As Single
        '3. No pueden ser palabras reservadas
        'Dim class As Integer = 4
        '4. No pueden contener caracteres especiales
        'Dim dolar_ As Integer


        'Mostrar por pantalla texto y variable
        Dim numero5 As Integer = 10
        numero5 = numero5 - 30
        Console.WriteLine("Numero5 vale : " & numero5 &
                          " te enteraste??")

























        Console.ReadLine()


    End Sub

End Module
