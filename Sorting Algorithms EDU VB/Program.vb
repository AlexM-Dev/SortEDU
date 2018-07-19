Imports System.Diagnostics
Imports Sorting
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


End Module
