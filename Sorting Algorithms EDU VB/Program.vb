Imports System.Diagnostics
Module Program

    Sub Main()
        Dim vals As Integer() = {1, 10, 7, 2, 5, 8}

        Console.WriteLine(String.Join(", ", vals))

        Dim timer As New Stopwatch()
        timer.Start()

        InsertionSort_1(vals)

        timer.Stop()

        Console.WriteLine(String.Join(", ", vals))
        Console.WriteLine($"Took {timer.ElapsedMilliseconds} milliseconds.")

        Console.ReadKey()
    End Sub

End Module
