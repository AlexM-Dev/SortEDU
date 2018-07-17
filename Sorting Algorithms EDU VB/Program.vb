Imports System.Diagnostics
Module Program

    Sub Main()
        Dim vals As Integer() = generateValues(50000)

        Console.WriteLine(String.Join(", ", vals))
        Dim timer As New Stopwatch()
        timer.Start()

        InsertionSort(vals)

        timer.Stop()

        Console.WriteLine(String.Join(", ", vals))
        Console.WriteLine($"Took {timer.ElapsedMilliseconds} milliseconds.")

        Console.ReadKey()
    End Sub

    Function generateValues(ByVal length As Integer) As Integer()
        Dim vals(length) As Integer
        Dim random As New Random

        For i = 0 To length - 1
            vals(i) = random.Next(length)
        Next

        Return vals
    End Function
End Module
