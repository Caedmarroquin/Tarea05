Module Module1
    Sub Main()
        Dim acum, i, num, suma As Integer
        acum = 1
        Console.WriteLine("Ingrese Número:")
        num = Console.ReadLine()
        If (num > 0) Then
            For i = 1 To num
                acum = acum * i
            Next
        End If
        Console.WriteLine("Factorial: " & acum)
        Console.WriteLine("")
        Console.WriteLine("Multiplos de " & num)
        For indice As Integer = 0 To acum Step 4
            Console.WriteLine(indice)
            suma = suma + 1
        Next
        Console.WriteLine("Hay " & suma & " multiplos de " & num)
        Console.WriteLine("")
        Console.WriteLine("Pulse cualquier tecla para salir")
        Console.ReadKey()
    End Sub
    
End Module
