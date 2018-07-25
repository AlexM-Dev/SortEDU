Imports System.Diagnostics
Imports Sorting
Module Program

    Sub Main()
        '' Reserve VB code for Searching.
        Dim arr As String() = {"Dog", "Apple", "Cat"}

        Dim s As String = arr(Search(arr, "Dog"))
        Console.WriteLine(s)



        Console.ReadKey()
    End Sub


End Module
